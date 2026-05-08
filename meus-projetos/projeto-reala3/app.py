from flask import Flask, request, jsonify, session, send_from_directory
import os
import banco  # importa tudo que criamos no banco.py

# ============================================================
#  CONFIGURAÇÃO DO FLASK
#  Flask é um framework web leve para Python.
#  Ele recebe requisições do HTML e devolve respostas.
# ============================================================
app = Flask(__name__, static_folder='templates')

# Chave secreta para criptografar a sessão do usuário
# (guarda quem está logado entre as requisições)
app.secret_key = 'mercafacil_super_secreto_2026'


# ============================================================
#  ROTA PRINCIPAL — serve o HTML
#  Quando o usuário abre o navegador, o Flask entrega o HTML
# ============================================================
@app.route('/')
def index():
    return send_from_directory('templates', 'index.html')


# ============================================================
#  ROTAS DE AUTENTICAÇÃO
# ============================================================

# POST /cadastrar — recebe nome, email, senha e cria conta
@app.route('/cadastrar', methods=['POST'])
def cadastrar():
    dados = request.json               # pega o JSON enviado pelo HTML
    nome  = dados.get('nome', '').strip()
    email = dados.get('email', '').strip().lower()
    senha = dados.get('senha', '')

    # validações básicas
    if not nome or not email or not senha:
        return jsonify({"ok": False, "msg": "Preencha todos os campos."})
    if len(senha) < 6:
        return jsonify({"ok": False, "msg": "A senha deve ter pelo menos 6 caracteres."})

    resultado = banco.cadastrar_usuario(nome, email, senha)

    # se cadastrou com sucesso, já loga o usuário automaticamente
    if resultado['ok']:
        usuario = banco.buscar_usuario_por_email(email)
        session['id_usuario'] = usuario['id']
        session['nome']       = usuario['nome']
        resultado['nome']     = usuario['nome']

    return jsonify(resultado)


# POST /login — recebe email e senha, verifica e loga
@app.route('/login', methods=['POST'])
def login():
    dados = request.json
    email = dados.get('email', '').strip().lower()
    senha = dados.get('senha', '')

    resultado = banco.fazer_login(email, senha)

    if resultado['ok']:
        usuario = resultado['usuario']
        # salva na sessão quem está logado
        session['id_usuario'] = usuario['id']
        session['nome']       = usuario['nome']
        resultado['nome']     = usuario['nome']
        # remove a senha do retorno por segurança
        del resultado['usuario']

    return jsonify(resultado)


# POST /logout — encerra a sessão
@app.route('/logout', methods=['POST'])
def logout():
    session.clear()
    return jsonify({"ok": True})


# GET /sessao — verifica se tem alguém logado
# O HTML chama isso ao carregar para saber o estado
@app.route('/sessao')
def sessao():
    if 'id_usuario' in session:
        return jsonify({
            "logado": True,
            "nome": session['nome'],
            "id": session['id_usuario']
        })
    return jsonify({"logado": False})


# ============================================================
#  ROTAS DE COMPRAS
# ============================================================

# POST /finalizar — salva a compra no banco
@app.route('/finalizar', methods=['POST'])
def finalizar():
    # visitante não pode finalizar sem login
    if 'id_usuario' not in session:
        return jsonify({"ok": False, "requer_login": True,
                        "msg": "Faça login para finalizar sua compra."})

    dados     = request.json
    total     = dados.get('total', 0)
    itens     = dados.get('itens', [])

    if not itens:
        return jsonify({"ok": False, "msg": "Carrinho vazio."})

    resultado = banco.salvar_compra(session['id_usuario'], total, itens)
    return jsonify(resultado)


# GET /minhas-compras — retorna histórico do usuário logado
@app.route('/minhas-compras')
def minhas_compras():
    if 'id_usuario' not in session:
        return jsonify({"ok": False, "requer_login": True})

    compras = banco.listar_compras(session['id_usuario'])
    return jsonify({"ok": True, "compras": compras})


# GET /compra/<id> — retorna os itens de uma compra específica
@app.route('/compra/<int:id_compra>')
def detalhe_compra(id_compra):
    if 'id_usuario' not in session:
        return jsonify({"ok": False, "requer_login": True})

    resultado = banco.detalhar_compra(id_compra)

    # garante que o usuário só vê suas próprias compras
    if resultado['compra'] and resultado['compra']['id_usuario'] != session['id_usuario']:
        return jsonify({"ok": False, "msg": "Acesso negado."})

    return jsonify({"ok": True, **resultado})


# DELETE /compra/<id> — remove uma compra do histórico
@app.route('/compra/<int:id_compra>', methods=['DELETE'])
def remover_compra(id_compra):
    if 'id_usuario' not in session:
        return jsonify({"ok": False, "requer_login": True})

    # verifica se a compra pertence ao usuário antes de deletar
    resultado = banco.detalhar_compra(id_compra)
    if resultado['compra'] and resultado['compra']['id_usuario'] != session['id_usuario']:
        return jsonify({"ok": False, "msg": "Acesso negado."})

    return jsonify(banco.deletar_compra(id_compra))


# ============================================================
#  ROTAS DE CONTA (CRUD DO USUÁRIO)
# ============================================================

# PUT /conta — atualiza nome e/ou senha
@app.route('/conta', methods=['PUT'])
def atualizar_conta():
    if 'id_usuario' not in session:
        return jsonify({"ok": False, "requer_login": True})

    dados      = request.json
    novo_nome  = dados.get('nome', '').strip()
    nova_senha = dados.get('senha', '')

    resultado = banco.atualizar_usuario(
        session['id_usuario'],
        novo_nome  or None,
        nova_senha or None
    )

    # atualiza o nome na sessão se mudou
    if novo_nome:
        session['nome'] = novo_nome

    return jsonify(resultado)


# DELETE /conta — remove a conta do usuário
@app.route('/conta', methods=['DELETE'])
def deletar_conta():
    if 'id_usuario' not in session:
        return jsonify({"ok": False, "requer_login": True})

    banco.deletar_usuario(session['id_usuario'])
    session.clear()
    return jsonify({"ok": True, "msg": "Conta removida com sucesso."})


# ============================================================
#  INICIAR O SERVIDOR
# ============================================================
if __name__ == '__main__':
    print("🚀 Servidor iniciado em http://localhost:5000")
    app.run(debug=True)
