using System;
using System.Collections;

namespace Calculadora
{
    class Program
    {
        static void Main()
        {  
        
        Console.WriteLine("Você Deseja Realizar uma compra? 's' se sim 'n' se não");
        string resposta = Console.ReadLine();
        if(resposta == "s")
            {
                Console.WriteLine("digite qual Alimento você deseja comprar");
                string produto = Console.ReadLine();
                switch (produto)
                {
                    case "arroz":
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
                        }
                        else if(resposta2 == "unidade")
                        {
                            Console.WriteLine("Quantas unidades você deseja comprar?");
                            int quantidadeUnidade = Convert.ToInt32(Console.ReadLine());
                            double precoUnidade = 5.00;
                            double totalUnidade = precoUnidade * quantidadeUnidade;
                            Console.WriteLine("O total a pagar é R$ " + totalUnidade);
                        }
                        break;
                    case "feijão":
                        Console.WriteLine("voc~e deseja comprar o feijãoo em fardo ou unidade?");
                        string resposta3 = Console.ReadLine();
                        if(resposta3 == "fardo")
                        {
                            Console.WriteLine("O preço do feijão em fardo é R$ 70,00");
                            double precoFardo = 70.00;
                            Console.WriteLine("Quantos fardos você deseja comprar?");
                            int quantidadeFardo = Convert.ToInt32(Console.ReadLine());
                            double totalFardo = precoFardo * quantidadeFardo;
                            Console.WriteLine("O total a pagar é R$ " + totalFardo);
                        }
                        else if(resposta3 == "unidade")
                        {
                            Console.WriteLine("Quantas unidades você deseja comprar?");
                            int quantidadeUnidade = Convert.ToInt32(Console.ReadLine());
                            double precoUnidade = 7.00;
                            double totalUnidade = precoUnidade * quantidadeUnidade;
                            Console.WriteLine("O total a pagar é R$ " + totalUnidade);
                        }

                        break;
                    case "macarrão":
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
                        }
                        else if(resposta4 == "unidade")
                        {
                            Console.WriteLine("Quantas unidades você deseja comprar?");
                            int quantidadeUnidade = Convert.ToInt32(Console.ReadLine());
                            double precoUnidade = 3.00;
                            double totalUnidade = precoUnidade * quantidadeUnidade;
                            Console.WriteLine("O total a pagar é R$ " + totalUnidade);
                        }
                        break;
                    default:
                        Console.WriteLine("Produto não encontrado");
                        break;
                    
                }
            }    
          
        }
    }
}