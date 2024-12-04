using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TesteMesa3
{
    public class Menu
    {
        public void MostrarMenu()
        {
            Console.WriteLine("---Calculo de Rendimento Futuro ---");
            Console.WriteLine("1. Inserir valores e calcular");
            Console.WriteLine("0.Sair");
        }

        public void Executar()
        {
            int opcao;
            do
            {
                MostrarMenu();
                Console.WriteLine("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        LerDados();
                        break;

                    case 0:
                        Console.WriteLine("Saindo do Programa");
                        break;

                    default:
                        Console.WriteLine("Opção Inválida!! Tenta denovo");
                        break;

                }

            } while (opcao != 0);

        }   

        private void LerDados()
        {
            Console.Write("Digite o valor inicial (R$): ");
            decimal valorInicial = decimal.Parse(Console.ReadLine());

            Console.Write("Digite a taxa mensal (%): ");
            decimal taxaMensal = decimal.Parse(Console.ReadLine()) / 100;

            Console.Write("Digite a data inicial (formato: dd/MM/yyyy): ");
            DateTime dataInicial = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Digite a data final (formato: dd/MM/yyyy): ");
            DateTime dataFinal = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Digite o valor do saque: ");
            decimal valorSaque = decimal.Parse(Console.ReadLine());


            Rendimento rendimento = new Rendimento(valorInicial, taxaMensal, dataInicial, dataFinal)
            {
                ValorSaque = valorSaque
            };

            decimal rendimentoFuturo = rendimento.CalcularRendimentoFuturo();

            Console.WriteLine($"Valor Investido: R$ {valorInicial}, Taxa: {taxaMensal * 100}%, Rendimento Futuro: R$ {rendimentoFuturo:F2}");
        }

    }
}

