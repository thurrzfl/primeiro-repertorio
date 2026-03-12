using System;
using System.Collections;

namespace Calculadora
{
    class Program
    {
        static void Main()
        {  
          double num1;
          double num2;
          Console.WriteLine("Digite o primeiro número\n");
          num1 = double.Parse (Console.ReadLine());
          Console.WriteLine("Digite segundo número\n");
          num2 = double.Parse (Console.ReadLine());
          Console.WriteLine("Digite a sua operção: '1' para + '2' para - '3' para * '4' para /");
          string operação = Console.ReadLine();
          double resultado = 0;

                switch (operação)
            {
                case "1" :  resultado = num1 + num2;
                break;
                case "2" :  resultado =  num1 - num2;
                break;
                case "3" :  resultado = num1 * num2;
                break;
                case "4" :  resultado =num1 / num2;
                break;
            }  
               Console.WriteLine("RESULTADO DA OPERAÇÃO É :\n" + resultado);
            
          
        }
    }
}