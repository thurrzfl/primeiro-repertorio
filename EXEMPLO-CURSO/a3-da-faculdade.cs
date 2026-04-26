using System;

class Program
{
    static void Main()
    {
        double totalValor = 0;
        bool continuarLoja = true;

        Console.WriteLine("=== Bem-vindo ao Supermercado Virtual ===");

        while (continuarLoja)
        {
            Console.WriteLine("\nO que deseja comprar?");
            Console.WriteLine("1 - Alimentos");
            Console.WriteLine("2 - Bebidas");
            Console.WriteLine("3 - Produtos de Limpeza");
            Console.WriteLine("sair - Finalizar compras");
            Console.Write("Escolha: ");
            string categoria = Console.ReadLine();

            if (categoria == "sair")
            {
                continuarLoja = false;
            }
            else if (categoria == "1")
            {
                bool continuarAlimentos = true;

                while (continuarAlimentos)
                {
                    Console.WriteLine("\n--- ALIMENTOS ---");
                    Console.WriteLine("1  - Banana       R$ 3,99/kg");
                    Console.WriteLine("2  - Maçã         R$ 6,99/kg");
                    Console.WriteLine("3  - Laranja      R$ 4,49/kg");
                    Console.WriteLine("4  - Alface       R$ 2,99/unid");
                    Console.WriteLine("5  - Tomate       R$ 4,99/kg");
                    Console.WriteLine("6  - Batata       R$ 3,99/kg");
                    Console.WriteLine("7  - Frango       R$ 12,99/kg");
                    Console.WriteLine("8  - Carne moída  R$ 22,99/kg");
                    Console.WriteLine("9  - Ovos");
                    Console.WriteLine("10 - Arroz");
                    Console.WriteLine("11 - Feijão");
                    Console.WriteLine("12 - Macarrão");
                    Console.WriteLine("13 - Queijo       R$ 39,99/kg");
                    Console.WriteLine("14 - Leite        R$ 4,99/unid");
                    Console.WriteLine("sair - Voltar ao menu principal");
                    Console.Write("Escolha: ");
                    string produto = Console.ReadLine();

                    if (produto == "sair")
                    {
                        continuarAlimentos = false;
                    }
                    else if (produto == "1")
                    {
                        Console.Write("Quantos kg de Banana? ");
                        double kg = double.Parse(Console.ReadLine());
                        double subtotal = kg * 3.99;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else if (produto == "2")
                    {
                        Console.Write("Quantos kg de Maçã? ");
                        double kg = double.Parse(Console.ReadLine());
                        double subtotal = kg * 6.99;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else if (produto == "3")
                    {
                        Console.Write("Quantos kg de Laranja? ");
                        double kg = double.Parse(Console.ReadLine());
                        double subtotal = kg * 4.49;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else if (produto == "4")
                    {
                        Console.Write("Quantas unidades de Alface? ");
                        int qtd = int.Parse(Console.ReadLine());
                        double subtotal = qtd * 2.99;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else if (produto == "5")
                    {
                        Console.Write("Quantos kg de Tomate? ");
                        double kg = double.Parse(Console.ReadLine());
                        double subtotal = kg * 4.99;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else if (produto == "6")
                    {
                        Console.Write("Quantos kg de Batata? ");
                        double kg = double.Parse(Console.ReadLine());
                        double subtotal = kg * 3.99;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else if (produto == "7")
                    {
                        Console.Write("Quantos kg de Frango? ");
                        double kg = double.Parse(Console.ReadLine());
                        double subtotal = kg * 12.99;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else if (produto == "8")
                    {
                        Console.Write("Quantos kg de Carne moída? ");
                        double kg = double.Parse(Console.ReadLine());
                        double subtotal = kg * 22.99;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else if (produto == "9")
                    {
                        Console.WriteLine("Como deseja comprar os Ovos?");
                        Console.WriteLine("1 - Por unidade  R$ 0,79");
                        Console.WriteLine("2 - Bandeja 12   R$ 8,49");
                        Console.WriteLine("3 - Bandeja 30   R$ 19,99");
                        Console.Write("Escolha: ");
                        string tipoOvo = Console.ReadLine();

                        if (tipoOvo == "1")
                        {
                            Console.Write("Quantos ovos? ");
                            int qtd = int.Parse(Console.ReadLine());
                            double subtotal = qtd * 0.79;
                            totalValor += subtotal;
                            Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                        }
                        else if (tipoOvo == "2")
                        {
                            Console.Write("Quantas bandejas de 12? ");
                            int qtd = int.Parse(Console.ReadLine());
                            double subtotal = qtd * 8.49;
                            totalValor += subtotal;
                            Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                        }
                        else if (tipoOvo == "3")
                        {
                            Console.Write("Quantas bandejas de 30? ");
                            int qtd = int.Parse(Console.ReadLine());
                            double subtotal = qtd * 19.99;
                            totalValor += subtotal;
                            Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida.");
                        }
                    }
                    else if (produto == "10")
                    {
                        Console.WriteLine("Como deseja comprar o Arroz?");
                        Console.WriteLine("1 - Unidade (5kg)    R$ 24,99");
                        Console.WriteLine("2 - Fardo (10 sacos) R$ 219,99");
                        Console.Write("Escolha: ");
                        string tipoArroz = Console.ReadLine();

                        if (tipoArroz == "1")
                        {
                            Console.Write("Quantos sacos? ");
                            int qtd = int.Parse(Console.ReadLine());
                            double subtotal = qtd * 24.99;
                            totalValor += subtotal;
                            Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                        }
                        else if (tipoArroz == "2")
                        {
                            Console.Write("Quantos fardos? ");
                            int qtd = int.Parse(Console.ReadLine());
                            double subtotal = qtd * 219.99;
                            totalValor += subtotal;
                            Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida.");
                        }
                    }
                    else if (produto == "11")
                    {
                        Console.WriteLine("Como deseja comprar o Feijão?");
                        Console.WriteLine("1 - Unidade (1kg)      R$ 8,99");
                        Console.WriteLine("2 - Fardo (10 pacotes) R$ 79,99");
                        Console.Write("Escolha: ");
                        string tipoFeijao = Console.ReadLine();

                        if (tipoFeijao == "1")
                        {
                            Console.Write("Quantos pacotes? ");
                            int qtd = int.Parse(Console.ReadLine());
                            double subtotal = qtd * 8.99;
                            totalValor += subtotal;
                            Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                        }
                        else if (tipoFeijao == "2")
                        {
                            Console.Write("Quantos fardos? ");
                            int qtd = int.Parse(Console.ReadLine());
                            double subtotal = qtd * 79.99;
                            totalValor += subtotal;
                            Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida.");
                        }
                    }
                    else if (produto == "12")
                    {
                        Console.WriteLine("Escolha a marca do Macarrão:");
                        Console.WriteLine("1 - Barilla   R$ 5,99");
                        Console.WriteLine("2 - Renata    R$ 3,99");
                        Console.WriteLine("3 - Vitarella R$ 3,49");
                        Console.Write("Escolha: ");
                        string marcaMacarrao = Console.ReadLine();

                        if (marcaMacarrao == "1")
                        {
                            Console.Write("Quantos pacotes de Barilla? ");
                            int qtd = int.Parse(Console.ReadLine());
                            double subtotal = qtd * 5.99;
                            totalValor += subtotal;
                            Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                        }
                        else if (marcaMacarrao == "2")
                        {
                            Console.Write("Quantos pacotes de Renata? ");
                            int qtd = int.Parse(Console.ReadLine());
                            double subtotal = qtd * 3.99;
                            totalValor += subtotal;
                            Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                        }
                        else if (marcaMacarrao == "3")
                        {
                            Console.Write("Quantos pacotes de Vitarella? ");
                            int qtd = int.Parse(Console.ReadLine());
                            double subtotal = qtd * 3.49;
                            totalValor += subtotal;
                            Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida.");
                        }
                    }
                    else if (produto == "13")
                    {
                        Console.Write("Quantos kg de Queijo? ");
                        double kg = double.Parse(Console.ReadLine());
                        double subtotal = kg * 39.99;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else if (produto == "14")
                    {
                        Console.Write("Quantas unidades de Leite? ");
                        int qtd = int.Parse(Console.ReadLine());
                        double subtotal = qtd * 4.99;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida.");
                    }
                }
            }
            else if (categoria == "2")
            {
                bool continuarBebidas = true;

                while (continuarBebidas)
                {
                    Console.WriteLine("\n--- BEBIDAS ---");
                    Console.WriteLine("1 - Água mineral     R$ 2,49/unid");
                    Console.WriteLine("2 - Refrigerante 2L  R$ 7,99/unid");
                    Console.WriteLine("3 - Suco caixinha    R$ 3,49/unid");
                    Console.WriteLine("4 - Cerveja lata     R$ 4,99/unid");
                    Console.WriteLine("5 - Vinho            R$ 34,99/garrafa");
                    Console.WriteLine("6 - Café 500g        R$ 12,99/unid");
                    Console.WriteLine("7 - Energético       R$ 8,99/unid");
                    Console.WriteLine("sair - Voltar ao menu principal");
                    Console.Write("Escolha: ");
                    string bebida = Console.ReadLine();

                    if (bebida == "sair")
                    {
                        continuarBebidas = false;
                    }
                    else if (bebida == "1")
                    {
                        Console.Write("Quantas unidades de Água mineral? ");
                        int qtd = int.Parse(Console.ReadLine());
                        double subtotal = qtd * 2.49;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else if (bebida == "2")
                    {
                        Console.Write("Quantas unidades de Refrigerante? ");
                        int qtd = int.Parse(Console.ReadLine());
                        double subtotal = qtd * 7.99;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else if (bebida == "3")
                    {
                        Console.Write("Quantas caixinhas de Suco? ");
                        int qtd = int.Parse(Console.ReadLine());
                        double subtotal = qtd * 3.49;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else if (bebida == "4")
                    {
                        Console.Write("Quantas latas de Cerveja? ");
                        int qtd = int.Parse(Console.ReadLine());
                        double subtotal = qtd * 4.99;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else if (bebida == "5")
                    {
                        Console.Write("Quantas garrafas de Vinho? ");
                        int qtd = int.Parse(Console.ReadLine());
                        double subtotal = qtd * 34.99;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else if (bebida == "6")
                    {
                        Console.Write("Quantos pacotes de Café? ");
                        int qtd = int.Parse(Console.ReadLine());
                        double subtotal = qtd * 12.99;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else if (bebida == "7")
                    {
                        Console.Write("Quantas latas de Energético? ");
                        int qtd = int.Parse(Console.ReadLine());
                        double subtotal = qtd * 8.99;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida.");
                    }
                }
            }
            else if (categoria == "3")
            {
                bool continuarLimpeza = true;

                while (continuarLimpeza)
                {
                    Console.WriteLine("\n--- PRODUTOS DE LIMPEZA ---");
                    Console.WriteLine("1 - Detergente        R$ 2,99/unid");
                    Console.WriteLine("2 - Sabão em pó       R$ 14,99/unid");
                    Console.WriteLine("3 - Amaciante 2L      R$ 9,99/unid");
                    Console.WriteLine("4 - Água sanitária    R$ 5,49/unid");
                    Console.WriteLine("5 - Desinfetante      R$ 7,99/unid");
                    Console.WriteLine("6 - Esponja de louça  R$ 3,49/pacote");
                    Console.WriteLine("7 - Papel higiênico   R$ 19,99/pacote");
                    Console.WriteLine("sair - Voltar ao menu principal");
                    Console.Write("Escolha: ");
                    string limpeza = Console.ReadLine();

                    if (limpeza == "sair")
                    {
                        continuarLimpeza = false;
                    }
                    else if (limpeza == "1")
                    {
                        Console.Write("Quantas unidades de Detergente? ");
                        int qtd = int.Parse(Console.ReadLine());
                        double subtotal = qtd * 2.99;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else if (limpeza == "2")
                    {
                        Console.Write("Quantas unidades de Sabão em pó? ");
                        int qtd = int.Parse(Console.ReadLine());
                        double subtotal = qtd * 14.99;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else if (limpeza == "3")
                    {
                        Console.Write("Quantas unidades de Amaciante? ");
                        int qtd = int.Parse(Console.ReadLine());
                        double subtotal = qtd * 9.99;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else if (limpeza == "4")
                    {
                        Console.Write("Quantas unidades de Água sanitária? ");
                        int qtd = int.Parse(Console.ReadLine());
                        double subtotal = qtd * 5.49;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else if (limpeza == "5")
                    {
                        Console.Write("Quantas unidades de Desinfetante? ");
                        int qtd = int.Parse(Console.ReadLine());
                        double subtotal = qtd * 7.99;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else if (limpeza == "6")
                    {
                        Console.Write("Quantos pacotes de Esponja? ");
                        int qtd = int.Parse(Console.ReadLine());
                        double subtotal = qtd * 3.49;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else if (limpeza == "7")
                    {
                        Console.Write("Quantos pacotes de Papel higiênico? ");
                        int qtd = int.Parse(Console.ReadLine());
                        double subtotal = qtd * 19.99;
                        totalValor += subtotal;
                        Console.WriteLine("Subtotal: R$ " + subtotal.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }

        Console.WriteLine("\n=== Obrigado por comprar conosco! ===");
        Console.WriteLine("Total da sua compra: R$ " + totalValor.ToString("F2"));
    }
}
