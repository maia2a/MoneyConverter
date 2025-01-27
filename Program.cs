using System;

namespace MoneyConverter
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Bem-vindo ao MoneyConverter!");

      decimal taxaUSDparaBRL = 5.50m;
      decimal taxaEURparaBRL = 6.00m;
      decimal taxaBRLparaUSD = 0.20m;
      decimal taxaBRLparaEUR = 0.18m;

      while (true)
      {
        Console.WriteLine("\nEscolha uma opção:");
        Console.WriteLine("1 - Converter USD para BRL");
        Console.WriteLine("2 - Converter EUR para BRL");
        Console.WriteLine("3 - Converter BRL para USD");
        Console.WriteLine("4 - Converter BRL para EUR");
        Console.WriteLine("5 - Sair");

        int opcao = Convert.ToInt32(Console.ReadLine());

        if (opcao == 5)
        {
          Console.WriteLine("Obrigado por usar o MoneyConverter!");
          break;
        }

        Console.Write("Digite o valor a ser convertido: ");
        decimal valor;
        if (!decimal.TryParse(Console.ReadLine(), out valor))
        {
          Console.WriteLine("Valor inválido. Tente novamente.");
          continue;
        }

        decimal resultado = 0;

        switch (opcao)
        {
          case 1:
            resultado = valor * taxaUSDparaBRL;
            Console.WriteLine("O valor convertido para BRL é: " + resultado);
            break;
          case 2:
            resultado = valor * taxaEURparaBRL;
            Console.WriteLine("O valor convertido para BRL é: " + resultado);
            break;
          case 3:
            resultado = valor * taxaBRLparaUSD;
            Console.WriteLine("O valor convertido para USD é: " + resultado);
            break;
          case 4:
            resultado = valor * taxaBRLparaEUR;
            Console.WriteLine("O valor convertido para EUR é: " + resultado);
            break;
          default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
        }
      }



    }
  }
}