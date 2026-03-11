using System;
using System.Security.AccessControl;
namespace Dia1
{
    class Exercicio01
    {
        static void Main()
        {
             int num1 = 20;
        string nome;
        double n1 = 50000000.0000;
        float n2= 3.14f;
        Console.WriteLine("digite seu nome:");
        nome = Console.ReadLine();
        if(nome == "arthur")
            {
             Console.WriteLine("olá é você msm arthur\n");
            }
            else
            {
                Console.WriteLine("não é o arthur, vocêa não acesso");
            }
            Console.WriteLine("agora me dia sua idade:");
            num1 = int.Parse(Console.ReadLine());
            if(num1 >= 18)
            {
             Console.WriteLine("você é de maior, acesso autorizado.");
            }
            else
            {
                Console.WriteLine("você é menor de idade, volte quando fizer 18 anos.");
            }
            int cadastro;
            
            while (true)
            {
              Console.WriteLine("deseja fazer outro cadastro? digite '1' para sim e '2' para não");
              cadastro = int.Parse(Console.ReadLine());
              if(cadastro == 1)
                { int idade2;
                 Console.WriteLine("digite o seu nome:");
                 Console.ReadLine();
                 Console.WriteLine("digite a sua idade");
                 idade2 = int.Parse(Console.ReadLine());
                 if(idade2 >= 18)
                    {
                      Console.WriteLine("você está autorizado");
                    }
                    else
                    {
                        Console.WriteLine("VOCÊ NÃO TEM ACESSO POR SER DE MENOR");
                    }
                }
                  else if(cadastro == 2)
                {
                     break;
                }
                       
                
                
            }
        }
    }
}