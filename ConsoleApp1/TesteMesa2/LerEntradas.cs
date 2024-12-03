    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

        public class LerEntradas
        {
            public static void Entradas() // exercicio 3
            {
                LerEntradas lerEntrada = new LerEntradas();

                Console.WriteLine("Digite o valor total: ");
                double valorAtual = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor de juros: ");
                double juros = Convert.ToDouble (Console.ReadLine());
                Console.WriteLine("Digite o valor periodo(meses): ");
                double periodo = Convert.ToDouble(Console.ReadLine());

                double resultado = valorAtual * Math.Pow(1 + juros, periodo);

                Console.WriteLine(valorAtual + juros + periodo);
                Console.WriteLine("O valor final após " + periodo + " meses é: " + resultado);
        }
        }
    
