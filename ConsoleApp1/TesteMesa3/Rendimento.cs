using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TesteMesa3
{
    public class Rendimento
    {
        //atributos
        public decimal ValorInicial { get; set; }
        public decimal TaxaMensal { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public decimal ValorSaque { get; set; }

        // construtor que é utilizado para inicializar as propriedades de um objeto.
        public Rendimento(decimal ValorInicial, decimal TaxaMensal, DateTime DataInicial, DateTime DataFinal)
        {
            this.ValorInicial = ValorInicial;
            this.TaxaMensal = TaxaMensal;
            this.DataInicial = DataInicial;
            this.DataFinal = DataFinal;
            this.ValorSaque = ValorSaque;

        }

        //metodos
        public decimal CalcularRendimentoFuturo()
        {

            decimal valorAtual = ValorInicial;
            int totalMeses = (int)((DataFinal - DataInicial).TotalDays / 30);

            Console.WriteLine("Mês | Taxa | Saldo Inicial | Rendimento | Saque | Saldo Final");
            Console.WriteLine("-----------------------------------------------------");

            decimal rendimento = ValorInicial * (decimal)Math.Pow((double)(1 + TaxaMensal), totalMeses);


            for (int i = 1; i <= totalMeses; i++)
            {
                decimal saldoInicial = valorAtual;
                decimal rendimentoMensal = saldoInicial * TaxaMensal;
                decimal saque = 0;

                if (i == 5)
                {
                    saque = ValorSaque;
                    valorAtual -= saque;
                }

                valorAtual += rendimentoMensal;

                Console.WriteLine($"{i,3} | {TaxaMensal:P2} | {saldoInicial,14:C2} | {rendimentoMensal,10:C2} | {saque,5:C2} | {valorAtual,12:C2}");
            }

            return valorAtual;
        }
    }
}