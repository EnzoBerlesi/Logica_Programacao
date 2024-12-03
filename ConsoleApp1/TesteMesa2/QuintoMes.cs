using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TesteMesa2 //tem que fazer hard code
{
    public class QuintoMes // exercicio 4
    {
        public static void Quinto()
        {
            QuintoMes quintoMes = new QuintoMes();

            Console.WriteLine("Digite o valor presente:");
            double vp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a taxa de juros (em percentual):");
            double tx = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.WriteLine("Digite o período (em meses):");
            double pe = Convert.ToDouble(Console.ReadLine());

            double saldo = vp;
            double juros;

            for (int i = 1; i <= pe; i++)
            {
                juros = saldo * tx;
                saldo += juros;
                Console.WriteLine($"Mês {i} - Saldo acumulado: {saldo:F2}");

                if (i == 5)
                {
                    saldo -= 1000;
                    Console.WriteLine($"Saque de 1000,00 realizado no mês {i}. Novo saldo: {saldo:F2}");


                }
               
            }
        }
    }
}

