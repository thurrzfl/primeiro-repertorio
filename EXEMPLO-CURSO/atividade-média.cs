using System;

namespace Media
{
    class Program
    {
        static void Main()
        {
            float nota1, nota2;
            int faltas;

         
            while (true)
            {
                Console.WriteLine("Digite a primeira nota:");
                string? primeiranota = Console.ReadLine();

                if (!string.IsNullOrEmpty(primeiranota) && float.TryParse(primeiranota, out nota1))
                {
                    break; 
                }

                Console.WriteLine("Valor inválido, tente novamente.");
            }

            
            while (true)
            {
                Console.WriteLine("Digite a segunda nota:");
                string? segundanota = Console.ReadLine();

                if (!string.IsNullOrEmpty(segundanota) && float.TryParse(segundanota, out nota2))
                {
                    break;
                }

                Console.WriteLine("Valor inválido, tente novamente.");
            }

            float media = (nota1 + nota2) / 2;

            // FALTAS
            while (true)
            {
                Console.WriteLine("Digite a quantidade de faltas:");
                string? entrada = Console.ReadLine();

                if (int.TryParse(entrada, out faltas))
                {
                    break;
                }

                Console.WriteLine("Valor inválido, tente novamente.");
            }

            Console.WriteLine("Sua média é: " + media);
            Console.WriteLine("Quantidade de faltas: " + faltas);

            if (media >= 7)
                Console.WriteLine("Parabéns, você foi aprovado por nota.");
            else
                Console.WriteLine("Infelizmente você foi reprovado por nota.");

            if (faltas >= 5)
                Console.WriteLine("Infelizmente você foi reprovado por faltas.");
            else
                Console.WriteLine("Parabéns, você foi aprovado por faltas.");
        }
    }
}