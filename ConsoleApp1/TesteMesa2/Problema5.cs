using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TesteMesa2
{
    public class Problema5
    {
        public static void Problema()
        {
            try
{
    // Código que pode lançar uma exceção
}
catch (Exception e)
{
    // Exibe a mensagem de erro
    Console.WriteLine($"Erro: {e.Message}");
}

            Problema5 problema5 = new Problema5();

            Console.Write("Informe o Valor Futuro (R$): ");
            double valorFuturo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da taxa de juros:");
            double txj = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.WriteLine("Digite o valor do periodo de meses:");
            int periodo = Convert.ToInt32(Console.ReadLine());

            double valorPresente = valorFuturo / Math.Pow ((1 + txj), periodo );
            Console.WriteLine($"O valor presente é: {valorPresente:F10}");
        }
    }
}
