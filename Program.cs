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
        ExibirMenu();

        string opcao = Console.ReadLine();
        if (opcao == "4")
        {
          Console.WriteLine("Obrigado por usar o MoneyConverter!");
          break;
        }

        if (!ValidarOpcao(opcao))
        {
          Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
          continue;
        }

        decimal valor = LerValor();
        if (valor == -1m)
        {
          continue;
        }

        decimal valorConvertido = RealizarConversao(opcao, valor, taxaUSDparaBRL, taxaEURparaBRL, taxaBRLparaUSD, taxaBRLparaEUR);

        ExibirResultado(opcao, valor, valorConvertido);
      }

      static void ExibirMenu()
      {
        Console.WriteLine("\nEscolha uma opção:");
        Console.WriteLine("1 - Converter USD para BRL");
        Console.WriteLine("2 - Converter EUR para BRL");
        Console.WriteLine("3 - Converter BRL para USD");
        Console.WriteLine("4 - Sair");
      }

      static bool ValidarOpcao(string opcao)
      {
        return opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4";
      }

      static decimal LerValor()
      {
        Console.WriteLine("Digite o valor a ser convertido:");
        if (decimal.TryParse(Console.ReadLine(), out decimal valor) && valor > 0)
        {
          return valor;
        }
        else
        {
          Console.WriteLine("Valor inválido. Por favor, digite um número maior que zero.");
          return -1m;
        }
      }

      static decimal RealizarConversao(string opcao, decimal valor, decimal taxaUSDparaBRL, decimal taxaEURparaBRL, decimal taxaBRLparaUSD, decimal taxaBRLparaEUR)
      {
        switch (opcao)
        {
          case "1":
            return valor * taxaUSDparaBRL;
          case "2":
            return valor * taxaEURparaBRL;
          case "3":
            return valor * taxaBRLparaUSD;
          default:
            return 0m;
        }
      }

      static void ExibirResultado(string opcao, decimal valor, decimal resultado)
      {
        string moedaOrigem = "";
        string moedaDestino = "";

        switch (opcao)
        {
          case "1":
            moedaOrigem = "USD";
            moedaDestino = "BRL";
            break;
          case "2":
            moedaOrigem = "EUR";
            moedaDestino = "BRL";
            break;
          case "3":
            moedaOrigem = "BRL";
            moedaDestino = "USD";
            break;
        }

        Console.WriteLine($"O valor {valor} {moedaOrigem} equivale a {resultado} {moedaDestino}");
      }
    }

  }
}




