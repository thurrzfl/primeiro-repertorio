using System;
using System.Collections;

namespace Calculadora
{
    class Program
    {
        static void Main()
        {  
           double totalvalor = 0;
           bool continuar = true;
           Console.WriteLine("aperte a tecla 'enter' para iniciar suas compras ou digite 'sair' para finalizar suas compras");
           while(continuar)
           { 
    
             var sair = Console.ReadLine();
            if (sair == "sair")
                { Console.WriteLine("obrigado por visitar nossa loja! sua compra total foi de R$ " + totalvalor);
                    break;
                }

        Console.WriteLine("Você Deseja Realizar uma compra? se sim digite 'sim', se não digite 'sair'");
        string resposta = Console.ReadLine();
        if(resposta == "sim")
            {
                Console.WriteLine("digite qual Alimento você deseja comprar?\n");
                Console.WriteLine("Temos os seguintes produtos:\n");
                Console.WriteLine("1-Arroz\n2-Feijão\n3-Macarrão\n4-Carne de boi\n5-saco de gelo\n6-água mineral\n-7-refrigerante\n8-suco\n9-pão\n10-frutas\n");
                
                string produto = Console.ReadLine();
                switch (produto)
                {
                    case "1":
                        Console.WriteLine("você deseja comprar o arroz em fardo ou unidade?");
                        string resposta2 = Console.ReadLine();
                        if(resposta2 == "fardo")
                        {
                            Console.WriteLine("O preço do arroz em fardo é R$ 50,00");
                            double precoFardo = 50.00;
                            Console.WriteLine("Quantos fardos você deseja comprar?");
                            int quantidadeFardo = Convert.ToInt32(Console.ReadLine());
                            double totalFardo = precoFardo * quantidadeFardo;
                            Console.WriteLine("O total a pagar é R$ " + totalFardo);
                            totalvalor += totalFardo;
                            Console.WriteLine("Deseja comprar mais algum produto? se sim, digite 'sim', se não, digite 'sair'");
                        }
        
                     
                        else if(resposta2 == "unidade")
                        {
                            Console.WriteLine("Quantas unidades você deseja comprar?");
                            int quantidadeUnidade = Convert.ToInt32(Console.ReadLine());
                            double precoUnidade = 5.00;
                            double totalUnidade = precoUnidade * quantidadeUnidade;
                            Console.WriteLine("O total a pagar é R$ " + totalUnidade);
                            totalvalor += totalUnidade;
                            Console.WriteLine("Deseja comprar mais algum produto? se sim, digite 'sim', se não, digite 'sair'\n");
                        }
                        break;
                    case "2":
                        Console.WriteLine("vocêdeseja comprar o feijão em fardo ou unidade?");
                        string resposta3 = Console.ReadLine();
                        if(resposta3 == "fardo")
                        {
                            Console.WriteLine("O preço do feijão em fardo é R$ 70,00");
                            double precoFardo = 70.00;
                            Console.WriteLine("Quantos fardos você deseja comprar?");
                            int quantidadeFardo = Convert.ToInt32(Console.ReadLine());
                            double totalFardo = precoFardo * quantidadeFardo;
                            Console.WriteLine("O total a pagar é R$ " + totalFardo);
                            totalvalor += totalFardo;
                        }
                        else if(resposta3 == "unidade")
                        {
                            Console.WriteLine("Quantas unidades você deseja comprar?");
                            int quantidadeUnidade = Convert.ToInt32(Console.ReadLine());
                            double precoUnidade = 7.00;
                            double totalUnidade = precoUnidade * quantidadeUnidade;
                            Console.WriteLine("O total a pagar é R$ " + totalUnidade);
                            totalvalor += totalUnidade;
                        }

                        break;
                    case "3":
                        Console.WriteLine("você deseja comprar o macarrão em fardo ou unidade?");
                        string resposta4 = Console.ReadLine();
                        if(resposta4 == "fardo")
                        {
                            Console.WriteLine("O preço do macarrão em fardo é R$ 30,00");
                            double precoFardo = 30.00;
                            Console.WriteLine("Quantos fardos você deseja comprar?");
                            int quantidadeFardo = Convert.ToInt32(Console.ReadLine());
                            double totalFardo = precoFardo * quantidadeFardo;
                            Console.WriteLine("O total a pagar é R$ " + totalFardo);
                            totalvalor += totalFardo;
                        }
                        else if(resposta4 == "unidade")
                        {
                            Console.WriteLine("Quantas unidades você deseja comprar?");
                            int quantidadeUnidade = Convert.ToInt32(Console.ReadLine());
                            double precoUnidade = 3.00;
                            double totalUnidade = precoUnidade * quantidadeUnidade;
                            Console.WriteLine("O total a pagar é R$ " + totalUnidade);
                            totalvalor += totalUnidade;
                        }
                        break; 
                        case "4":
                        Console.WriteLine("O preço da carne de boi é R$ 20,00 por kg");
                        Console.WriteLine("Quantos kg de carne de boi você deseja comprar?");
                        int quantidadeCarneBoi = Convert.ToInt32(Console.ReadLine());
                        double totalCarneBoi = 20.00 * quantidadeCarneBoi;
                        Console.WriteLine("O total a pagar é R$ " + totalCarneBoi);
                        totalvalor += totalCarneBoi;
                        break;
                        case "5":
                        Console.WriteLine("O preço do saco de gelo é R$ 10,00");
                        Console.WriteLine("Quantos sacos de gelo você deseja comprar?");
                        int quantidadeSacoGelo = Convert.ToInt32(Console.ReadLine());
                        double totalSacoGelo = 10.00 * quantidadeSacoGelo;
                        Console.WriteLine("O total a pagar é R$ " + totalSacoGelo);
                        totalvalor += totalSacoGelo;
                        case "6":
                        Console.WriteLine("O preço da água mineral é R$ 2,00");
                        Console.WriteLine("Quantas garrafas de água mineral você deseja comprar?");
                        int quantidadeAguaMineral = Convert.ToInt32(Console.ReadLine());
                        double totalAguaMineral = 2.00 * quantidadeAguaMineral;
                        Console.WriteLine("O total a pagar é R$ " + totalAguaMineral);
                        totalvalor += totalAguaMineral;
                        case "7":
                        Console.WriteLine("O preço do refrigerante 2L é R$ 5,00");
                        Console.WriteLine("Quantas garrafas de refrigerante você deseja comprar?");
                        int quantidadeRefrigerante = Convert.ToInt32(Console.ReadLine());
                        double totalRefrigerante = 5.00 * quantidadeRefrigerante;
                        Console.WriteLine("O total a pagar é R$ " + totalRefrigerante);
                        totalvalor += totalRefrigerante;
                        case "8":
                        Console.WriteLine("O preço do suco de laranja 1L é R$ 4,00");
                        Console.WriteLine("Quantas garrafas de suco de laranja você deseja comprar?");
                        int quantidadeSucoLaranja = Convert.ToInt32(Console.ReadLine());
                        double totalSucoLaranja = 4.00 * quantidadeSucoLaranja;
                        console.WriteLine("O total a pagar é R$ " + totalSucoLaranja);
                        totalvalor += totalSucoLaranja;
                        break;
                    default:
                        Console.WriteLine("Produto não encontrado");
                        break;
                    }
                }
            }    
          
        }
    }
}