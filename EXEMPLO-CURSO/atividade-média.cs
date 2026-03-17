using System;
namespace Media
{
    class Program
    {
        static void Main()
        {
          float nota1,nota2;
          Console.WriteLine("digite a primeira nota :");
          nota1 = float.Parse(Console.ReadLine());
          Console.WriteLine("digite a segunda nota : ");
          nota2 = float.Parse(Console.ReadLine());
          float media;
          media = (nota1 + nota2) /2;
          Console.WriteLine("sua média é :" + media);
          if(media >= 7)
            {
                Console.WriteLine("parabéns você foi aprovado.");
            }
            else
            {
                Console.WriteLine("infelimente você foi reprovado por nota.");
            }
        }
    }
}