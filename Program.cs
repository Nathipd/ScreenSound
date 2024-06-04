using System;

namespace ScreenSound
{
    class Program
    {
        static List<string> listaDasBandas = new List<string>();

        static void ExibirLogo()
        {
            Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
            Console.WriteLine("\nBoa vindas ao Screen Sound");

        }

        static void ExibirOpcoesDoMenu()
        {
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para mostrar todas as bandas");
            Console.WriteLine("Digite 3 para avaliar uma banda");
            Console.WriteLine("Digite 4 para exibit a média de uma banda");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\n Digite a sua opção: ");
            int opcaoEscolhida = int.Parse(Console.ReadLine());

            switch (opcaoEscolhida)
            {
                case 1:
                    RegistrarBandas();
                    break;
                case 2:
                    Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}");
                    break;
                case 3:
                    Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}");
                    break;
                case 4:
                    Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}");
                    break;
                case -1:
                    Console.WriteLine($"Tchau Tchau :)");
                    break;
                default:
                    Console.WriteLine("Opção Invalida!");
                    break;
            }
        }

        static void RegistrarBandas()
        {
            Console.Clear();
            Console.WriteLine("Registro de Bandas");
            Console.WriteLine("Digite o nome da banda que deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            listaDasBandas.Add(nomeDaBanda);
            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();

            ExibirLogo();
            ExibirOpcoesDoMenu();

        }
        static void Main(string[] args)
        {
            ExibirLogo();
            ExibirOpcoesDoMenu();
        }
    }
}