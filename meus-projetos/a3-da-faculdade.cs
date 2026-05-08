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
                    else
                    {
                        switch (produto)
                        {
                            case "1":
                                Console.Write("Quantos kg de Banana? ");
                                double kg1 = double.Parse(Console.ReadLine());
                                double sub1 = kg1 * 3.99;
                                totalValor += sub1;
                                Console.WriteLine("Subtotal: R$ " + sub1.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            case "2":
                                Console.Write("Quantos kg de Maçã? ");
                                double kg2 = double.Parse(Console.ReadLine());
                                double sub2 = kg2 * 6.99;
                                totalValor += sub2;
                                Console.WriteLine("Subtotal: R$ " + sub2.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            case "3":
                                Console.Write("Quantos kg de Laranja? ");
                                double kg3 = double.Parse(Console.ReadLine());
                                double sub3 = kg3 * 4.49;
                                totalValor += sub3;
                                Console.WriteLine("Subtotal: R$ " + sub3.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            case "4":
                                Console.Write("Quantas unidades de Alface? ");
                                int qtd4 = int.Parse(Console.ReadLine());
                                double sub4 = qtd4 * 2.99;
                                totalValor += sub4;
                                Console.WriteLine("Subtotal: R$ " + sub4.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            case "5":
                                Console.Write("Quantos kg de Tomate? ");
                                double kg5 = double.Parse(Console.ReadLine());
                                double sub5 = kg5 * 4.99;
                                totalValor += sub5;
                                Console.WriteLine("Subtotal: R$ " + sub5.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            case "6":
                                Console.Write("Quantos kg de Batata? ");
                                double kg6 = double.Parse(Console.ReadLine());
                                double sub6 = kg6 * 3.99;
                                totalValor += sub6;
                                Console.WriteLine("Subtotal: R$ " + sub6.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            case "7":
                                Console.Write("Quantos kg de Frango? ");
                                double kg7 = double.Parse(Console.ReadLine());
                                double sub7 = kg7 * 12.99;
                                totalValor += sub7;
                                Console.WriteLine("Subtotal: R$ " + sub7.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            case "8":
                                Console.Write("Quantos kg de Carne moída? ");
                                double kg8 = double.Parse(Console.ReadLine());
                                double sub8 = kg8 * 22.99;
                                totalValor += sub8;
                                Console.WriteLine("Subtotal: R$ " + sub8.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            case "9":
                                Console.WriteLine("Como deseja comprar os Ovos?");
                                Console.WriteLine("1 - Por unidade  R$ 0,79");
                                Console.WriteLine("2 - Bandeja 12   R$ 8,49");
                                Console.WriteLine("3 - Bandeja 30   R$ 19,99");
                                Console.Write("Escolha: ");
                                string tipoOvo = Console.ReadLine();

                                switch (tipoOvo)
                                {
                                    case "1":
                                        Console.Write("Quantos ovos? ");
                                        int qtdOvo1 = int.Parse(Console.ReadLine());
                                        double subOvo1 = qtdOvo1 * 0.79;
                                        totalValor += subOvo1;
                                        Console.WriteLine("Subtotal: R$ " + subOvo1.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                        break;
                                    case "2":
                                        Console.Write("Quantas bandejas de 12? ");
                                        int qtdOvo2 = int.Parse(Console.ReadLine());
                                        double subOvo2 = qtdOvo2 * 8.49;
                                        totalValor += subOvo2;
                                        Console.WriteLine("Subtotal: R$ " + subOvo2.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                        break;
                                    case "3":
                                        Console.Write("Quantas bandejas de 30? ");
                                        int qtdOvo3 = int.Parse(Console.ReadLine());
                                        double subOvo3 = qtdOvo3 * 19.99;
                                        totalValor += subOvo3;
                                        Console.WriteLine("Subtotal: R$ " + subOvo3.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                        break;
                                    default:
                                        Console.WriteLine("Opção inválida.");
                                        break;
                                }
                                break;

                            case "10":
                                Console.WriteLine("Como deseja comprar o Arroz?");
                                Console.WriteLine("1 - Unidade (5kg)    R$ 24,99");
                                Console.WriteLine("2 - Fardo (10 sacos) R$ 219,99");
                                Console.Write("Escolha: ");
                                string tipoArroz = Console.ReadLine();

                                switch (tipoArroz)
                                {
                                    case "1":
                                        Console.Write("Quantos sacos? ");
                                        int qtdArroz1 = int.Parse(Console.ReadLine());
                                        double subArroz1 = qtdArroz1 * 24.99;
                                        totalValor += subArroz1;
                                        Console.WriteLine("Subtotal: R$ " + subArroz1.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                        break;
                                    case "2":
                                        Console.Write("Quantos fardos? ");
                                        int qtdArroz2 = int.Parse(Console.ReadLine());
                                        double subArroz2 = qtdArroz2 * 219.99;
                                        totalValor += subArroz2;
                                        Console.WriteLine("Subtotal: R$ " + subArroz2.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                        break;
                                    default:
                                        Console.WriteLine("Opção inválida.");
                                        break;
                                }
                                break;

                            case "11":
                                Console.WriteLine("Como deseja comprar o Feijão?");
                                Console.WriteLine("1 - Unidade (1kg)      R$ 8,99");
                                Console.WriteLine("2 - Fardo (10 pacotes) R$ 79,99");
                                Console.Write("Escolha: ");
                                string tipoFeijao = Console.ReadLine();

                                switch (tipoFeijao)
                                {
                                    case "1":
                                        Console.Write("Quantos pacotes? ");
                                        int qtdFeijao1 = int.Parse(Console.ReadLine());
                                        double subFeijao1 = qtdFeijao1 * 8.99;
                                        totalValor += subFeijao1;
                                        Console.WriteLine("Subtotal: R$ " + subFeijao1.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                        break;
                                    case "2":
                                        Console.Write("Quantos fardos? ");
                                        int qtdFeijao2 = int.Parse(Console.ReadLine());
                                        double subFeijao2 = qtdFeijao2 * 79.99;
                                        totalValor += subFeijao2;
                                        Console.WriteLine("Subtotal: R$ " + subFeijao2.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                        break;
                                    default:
                                        Console.WriteLine("Opção inválida.");
                                        break;
                                }
                                break;

                            case "12":
                                Console.WriteLine("Escolha a marca do Macarrão:");
                                Console.WriteLine("1 - Barilla   R$ 5,99");
                                Console.WriteLine("2 - Renata    R$ 3,99");
                                Console.WriteLine("3 - Vitarella R$ 3,49");
                                Console.Write("Escolha: ");
                                string marcaMacarrao = Console.ReadLine();

                                switch (marcaMacarrao)
                                {
                                    case "1":
                                        Console.Write("Quantos pacotes de Barilla? ");
                                        int qtdMac1 = int.Parse(Console.ReadLine());
                                        double subMac1 = qtdMac1 * 5.99;
                                        totalValor += subMac1;
                                        Console.WriteLine("Subtotal: R$ " + subMac1.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                        break;
                                    case "2":
                                        Console.Write("Quantos pacotes de Renata? ");
                                        int qtdMac2 = int.Parse(Console.ReadLine());
                                        double subMac2 = qtdMac2 * 3.99;
                                        totalValor += subMac2;
                                        Console.WriteLine("Subtotal: R$ " + subMac2.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                        break;
                                    case "3":
                                        Console.Write("Quantos pacotes de Vitarella? ");
                                        int qtdMac3 = int.Parse(Console.ReadLine());
                                        double subMac3 = qtdMac3 * 3.49;
                                        totalValor += subMac3;
                                        Console.WriteLine("Subtotal: R$ " + subMac3.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                        break;
                                    default:
                                        Console.WriteLine("Opção inválida.");
                                        break;
                                }
                                break;

                            case "13":
                                Console.Write("Quantos kg de Queijo? ");
                                double kg13 = double.Parse(Console.ReadLine());
                                double sub13 = kg13 * 39.99;
                                totalValor += sub13;
                                Console.WriteLine("Subtotal: R$ " + sub13.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            case "14":
                                Console.Write("Quantas unidades de Leite? ");
                                int qtd14 = int.Parse(Console.ReadLine());
                                double sub14 = qtd14 * 4.99;
                                totalValor += sub14;
                                Console.WriteLine("Subtotal: R$ " + sub14.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            default:
                                Console.WriteLine("Opção inválida.");
                                break;
                        }
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
                    else
                    {
                        switch (bebida)
                        {
                            case "1":
                                Console.Write("Quantas unidades de Água mineral? ");
                                int qtdB1 = int.Parse(Console.ReadLine());
                                double subB1 = qtdB1 * 2.49;
                                totalValor += subB1;
                                Console.WriteLine("Subtotal: R$ " + subB1.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            case "2":
                                Console.Write("Quantas unidades de Refrigerante? ");
                                int qtdB2 = int.Parse(Console.ReadLine());
                                double subB2 = qtdB2 * 7.99;
                                totalValor += subB2;
                                Console.WriteLine("Subtotal: R$ " + subB2.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            case "3":
                                Console.Write("Quantas caixinhas de Suco? ");
                                int qtdB3 = int.Parse(Console.ReadLine());
                                double subB3 = qtdB3 * 3.49;
                                totalValor += subB3;
                                Console.WriteLine("Subtotal: R$ " + subB3.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            case "4":
                                Console.Write("Quantas latas de Cerveja? ");
                                int qtdB4 = int.Parse(Console.ReadLine());
                                double subB4 = qtdB4 * 4.99;
                                totalValor += subB4;
                                Console.WriteLine("Subtotal: R$ " + subB4.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            case "5":
                                Console.Write("Quantas garrafas de Vinho? ");
                                int qtdB5 = int.Parse(Console.ReadLine());
                                double subB5 = qtdB5 * 34.99;
                                totalValor += subB5;
                                Console.WriteLine("Subtotal: R$ " + subB5.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            case "6":
                                Console.Write("Quantos pacotes de Café? ");
                                int qtdB6 = int.Parse(Console.ReadLine());
                                double subB6 = qtdB6 * 12.99;
                                totalValor += subB6;
                                Console.WriteLine("Subtotal: R$ " + subB6.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            case "7":
                                Console.Write("Quantas latas de Energético? ");
                                int qtdB7 = int.Parse(Console.ReadLine());
                                double subB7 = qtdB7 * 8.99;
                                totalValor += subB7;
                                Console.WriteLine("Subtotal: R$ " + subB7.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            default:
                                Console.WriteLine("Opção inválida.");
                                break;
                        }
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
                    else
                    {
                        switch (limpeza)
                        {
                            case "1":
                                Console.Write("Quantas unidades de Detergente? ");
                                int qtdL1 = int.Parse(Console.ReadLine());
                                double subL1 = qtdL1 * 2.99;
                                totalValor += subL1;
                                Console.WriteLine("Subtotal: R$ " + subL1.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            case "2":
                                Console.Write("Quantas unidades de Sabão em pó? ");
                                int qtdL2 = int.Parse(Console.ReadLine());
                                double subL2 = qtdL2 * 14.99;
                                totalValor += subL2;
                                Console.WriteLine("Subtotal: R$ " + subL2.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            case "3":
                                Console.Write("Quantas unidades de Amaciante? ");
                                int qtdL3 = int.Parse(Console.ReadLine());
                                double subL3 = qtdL3 * 9.99;
                                totalValor += subL3;
                                Console.WriteLine("Subtotal: R$ " + subL3.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            case "4":
                                Console.Write("Quantas unidades de Água sanitária? ");
                                int qtdL4 = int.Parse(Console.ReadLine());
                                double subL4 = qtdL4 * 5.49;
                                totalValor += subL4;
                                Console.WriteLine("Subtotal: R$ " + subL4.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            case "5":
                                Console.Write("Quantas unidades de Desinfetante? ");
                                int qtdL5 = int.Parse(Console.ReadLine());
                                double subL5 = qtdL5 * 7.99;
                                totalValor += subL5;
                                Console.WriteLine("Subtotal: R$ " + subL5.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            case "6":
                                Console.Write("Quantos pacotes de Esponja? ");
                                int qtdL6 = int.Parse(Console.ReadLine());
                                double subL6 = qtdL6 * 3.49;
                                totalValor += subL6;
                                Console.WriteLine("Subtotal: R$ " + subL6.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            case "7":
                                Console.Write("Quantos pacotes de Papel higiênico? ");
                                int qtdL7 = int.Parse(Console.ReadLine());
                                double subL7 = qtdL7 * 19.99;
                                totalValor += subL7;
                                Console.WriteLine("Subtotal: R$ " + subL7.ToString("F2") + " | Total: R$ " + totalValor.ToString("F2"));
                                break;

                            default:
                                Console.WriteLine("Opção inválida.");
                                break;
                        }
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