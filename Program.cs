using System;

namespace ScreenSound
{
    class Program
    {
      static Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

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
                    MostrarBandasRegistradas();
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
            ExibirTituloDaOpcao("Registro Das Bandas");
            Console.WriteLine("Digite o nome da banda que deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            bandasRegistradas.Add(nomeDaBanda, new List<int>());
            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();

            ExibirLogo();
            ExibirOpcoesDoMenu();

        }

        static void MostrarBandasRegistradas()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

            foreach (string banda in bandasRegistradas.Keys) {
                Console.WriteLine($"Banda: {banda}");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }

        static void ExibirTituloDaOpcao(string titulo)
        {
            int quantidadeDeLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }

        static void Main(string[] args)
        {
            bandasRegistradas.Add("Linkin Park", new List<int> {10, 8, 6 });
            bandasRegistradas.Add("The Beatles", new List<int>());

            ExibirLogo();
            ExibirOpcoesDoMenu();
        }
    }
}