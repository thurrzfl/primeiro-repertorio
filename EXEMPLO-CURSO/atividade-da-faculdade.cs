using System;
namespace AtiviadeDaFaculdade;
class Progam
{
    static void Main()
    {
        int quantidade;
        Console.WriteLine("Oque você deseja: arroz, feijão ou macarrão? Digite o número correspondente: '1' para arroz, '2' para feijão e '3' para macarrão");
        string opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1" : Console.WriteLine("Quantos kg ou fardos de arroz você deseja?");
            quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("O valor total é: " + (quantidade * 5.00) + "reais");
            break;
            case "2" : Console.WriteLine("Quantos kg de feijão você deseja?");
            quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("O valor total é: " + (quantidade * 7.00) + " reais");
            break;
            case "3" : Console.WriteLine("Quantos kg de macarrão você deseja?");
            quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("O valor total é: " + (quantidade * 4.00) + " reais");
            break;
        }
    }
}

