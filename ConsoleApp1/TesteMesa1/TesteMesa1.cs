using ConsoleApp1.TesteMesa2;
using ConsoleApp1.TesteMesa3;

public class TesteMesa1
{
    static void Main()
    {

        int[] v = new int[5];
        int a = 10;
        int b = 20;
        int c = (a + b) / 2;
        c = c - 40;
        v[3] = a + b + c;
        Console.WriteLine("O resultado de v[3] é " + v[3]);


        bool sair = false;

        while (!sair)
        {

            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine("0 - Sair do Programa!!!");
            Console.WriteLine("1 - Teste de Mesa 1");
            Console.WriteLine("2 - Exercicio 1 (Juros)");
            Console.WriteLine("3 - Exercicio 2 (Rendimento)");
            Console.WriteLine("4 - Exercicio 3 (LerEntradas)");
            Console.WriteLine("5 - Exercicio 4 (QuintoMês)");
            Console.WriteLine("6 - Exercicio 5 (Problema5)");
            Console.WriteLine("7 - Exercicio 6 (Menu)");

            String opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    TesteMesa1.Main();
                    break;

                case "2":
                    Juros.CalcularJuros();
                    break;

                case "3":
                    Rendimento.RendimentoMensal();
                    break;

                case "4":
                    LerEntradas.Entradas();
                    break;

                case "5":
                    QuintoMes.Quinto();
                    break;

                case "6":
                    Problema5.Problema();
                    break;

                case "7":
                    Menu menu = new Menu(); menu.Executar();
                    break;

                case "0":
                    sair = true;
                    Console.WriteLine("E por hoje é tudo pessoal... ");
                    break;

                default:
                    Console.WriteLine("Ai nao da ne patrao vamo le direito");
                    break;
            }
        }
    }
}