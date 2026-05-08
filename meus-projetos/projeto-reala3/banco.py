import sqlite3
import hashlib
import os

# Caminho do banco de dados
BASE_DIR = os.path.dirname(os.path.abspath(__file__))
BANCO = os.path.join(BASE_DIR, 'banco.db')


# ============================================================
#  CONEXÃO
#  Toda vez que precisamos falar com o banco, abrimos
#  uma conexão. O "with" garante que ela fecha sozinha.
# ============================================================
def conectar():
    conn = sqlite3.connect(BANCO)
    conn.row_factory = sqlite3.Row   # retorna linhas como dicionário
    return conn


# ============================================================
#  CRIAR TABELAS
#  Rodado uma única vez ao iniciar o sistema.
#  "IF NOT EXISTS" evita erro se já existirem.
# ============================================================
def criar_tabelas():
    with conectar() as conn:
        conn.executescript("""

            -- Tabela de usuários
            CREATE TABLE IF NOT EXISTS usuarios (
                id        INTEGER PRIMARY KEY AUTOINCREMENT,
                nome      TEXT    NOT NULL,
                email     TEXT    NOT NULL UNIQUE,
                senha     TEXT    NOT NULL,
                criado_em TEXT    DEFAULT (datetime('now','localtime'))
            );

            -- Tabela de compras (cabeçalho do pedido)
            CREATE TABLE IF NOT EXISTS compras (
                id         INTEGER PRIMARY KEY AUTOINCREMENT,
                id_usuario INTEGER NOT NULL,
                total      REAL    NOT NULL,
                data       TEXT    DEFAULT (datetime('now','localtime')),
                FOREIGN KEY (id_usuario) REFERENCES usuarios(id)
            );

            -- Tabela de itens de cada compra (detalhe do pedido)
            CREATE TABLE IF NOT EXISTS itens_compra (
                id         INTEGER PRIMARY KEY AUTOINCREMENT,
                id_compra  INTEGER NOT NULL,
                produto    TEXT    NOT NULL,
                quantidade REAL    NOT NULL,
                tipo       TEXT    NOT NULL,
                subtotal   REAL    NOT NULL,
                FOREIGN KEY (id_compra) REFERENCES compras(id)
            );

        """)
    print("✅ Tabelas criadas/verificadas com sucesso!")


# ============================================================
#  SEGURANÇA — HASH DE SENHA
#  Nunca salvamos a senha pura no banco.
#  Usamos SHA-256 para transformá-la em um código seguro.
#  Ex: "senha123" → "a665a45920..." (irreversível)
# ============================================================
def hash_senha(senha):
    return hashlib.sha256(senha.encode()).hexdigest()


# ============================================================
#  CRUD — USUÁRIOS
# ============================================================

# CREATE — cadastrar novo usuário
def cadastrar_usuario(nome, email, senha):
    try:
        with conectar() as conn:
            conn.execute(
                "INSERT INTO usuarios (nome, email, senha) VALUES (?, ?, ?)",
                (nome, email, hash_senha(senha))
            )
        return {"ok": True, "msg": "Cadastro realizado com sucesso!"}
    except sqlite3.IntegrityError:
        # UNIQUE do email não deixa duplicar
        return {"ok": False, "msg": "Este e-mail já está cadastrado."}


# READ — buscar usuário pelo email (para login)
def buscar_usuario_por_email(email):
    with conectar() as conn:
        row = conn.execute(
            "SELECT * FROM usuarios WHERE email = ?", (email,)
        ).fetchone()
    return dict(row) if row else None


# READ — buscar usuário pelo id
def buscar_usuario_por_id(id_usuario):
    with conectar() as conn:
        row = conn.execute(
            "SELECT * FROM usuarios WHERE id = ?", (id_usuario,)
        ).fetchone()
    return dict(row) if row else None


# UPDATE — atualizar nome e/ou senha do usuário
def atualizar_usuario(id_usuario, novo_nome=None, nova_senha=None):
    with conectar() as conn:
        if novo_nome and nova_senha:
            conn.execute(
                "UPDATE usuarios SET nome = ?, senha = ? WHERE id = ?",
                (novo_nome, hash_senha(nova_senha), id_usuario)
            )
        elif novo_nome:
            conn.execute(
                "UPDATE usuarios SET nome = ? WHERE id = ?",
                (novo_nome, id_usuario)
            )
        elif nova_senha:
            conn.execute(
                "UPDATE usuarios SET senha = ? WHERE id = ?",
                (hash_senha(nova_senha), id_usuario)
            )
    return {"ok": True, "msg": "Dados atualizados!"}


# DELETE — remover usuário e todas as suas compras
def deletar_usuario(id_usuario):
    with conectar() as conn:
        # apaga os itens das compras do usuário
        conn.execute("""
            DELETE FROM itens_compra
            WHERE id_compra IN (
                SELECT id FROM compras WHERE id_usuario = ?
            )
        """, (id_usuario,))
        # apaga as compras
        conn.execute(
            "DELETE FROM compras WHERE id_usuario = ?", (id_usuario,)
        )
        # apaga o usuário
        conn.execute(
            "DELETE FROM usuarios WHERE id = ?", (id_usuario,)
        )
    return {"ok": True, "msg": "Usuário removido."}


# ============================================================
#  LOGIN — verificar email + senha
# ============================================================
def fazer_login(email, senha):
    usuario = buscar_usuario_por_email(email)
    if not usuario:
        return {"ok": False, "msg": "E-mail não encontrado."}
    if usuario['senha'] != hash_senha(senha):
        return {"ok": False, "msg": "Senha incorreta."}
    return {"ok": True, "msg": "Login realizado!", "usuario": usuario}


# ============================================================
#  CRUD — COMPRAS
# ============================================================

# CREATE — salvar compra completa (cabeçalho + itens)
def salvar_compra(id_usuario, total, itens):
    """
    itens é uma lista de dicionários:
    [{ nome, quantidade, tipo, subtotal }, ...]
    """
    with conectar() as conn:
        # insere o cabeçalho da compra
        cursor = conn.execute(
            "INSERT INTO compras (id_usuario, total) VALUES (?, ?)",
            (id_usuario, total)
        )
        id_compra = cursor.lastrowid  # pega o id gerado automaticamente

        # insere cada item da compra
        for item in itens:
            conn.execute(
                """INSERT INTO itens_compra
                   (id_compra, produto, quantidade, tipo, subtotal)
                   VALUES (?, ?, ?, ?, ?)""",
                (id_compra, item['nome'], item['quantidade'],
                 item['tipo'], item['subtotal'])
            )
    return {"ok": True, "id_compra": id_compra}


# READ — listar todas as compras de um usuário
def listar_compras(id_usuario):
    with conectar() as conn:
        compras = conn.execute(
            """SELECT * FROM compras
               WHERE id_usuario = ?
               ORDER BY data DESC""",
            (id_usuario,)
        ).fetchall()
    return [dict(c) for c in compras]


# READ — buscar detalhes (itens) de uma compra específica
def detalhar_compra(id_compra):
    with conectar() as conn:
        compra = conn.execute(
            "SELECT * FROM compras WHERE id = ?", (id_compra,)
        ).fetchone()

        itens = conn.execute(
            "SELECT * FROM itens_compra WHERE id_compra = ?", (id_compra,)
        ).fetchall()

    return {
        "compra": dict(compra) if compra else None,
        "itens": [dict(i) for i in itens]
    }


# DELETE — remover uma compra e seus itens
def deletar_compra(id_compra):
    with conectar() as conn:
        conn.execute(
            "DELETE FROM itens_compra WHERE id_compra = ?", (id_compra,)
        )
        conn.execute(
            "DELETE FROM compras WHERE id = ?", (id_compra,)
        )
    return {"ok": True, "msg": "Compra removida."}


# ============================================================
#  INICIALIZAR — roda ao importar o arquivo
# ============================================================
criar_tabelas()
