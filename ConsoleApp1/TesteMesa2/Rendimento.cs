     public class Rendimento
    {
        public static void RendimentoMensal()
        {
         
        Rendimento rendimento = new Rendimento(); //exercicio 2

        double resultado;
        double vp = 3800;
        double juros = 0.0125;
        double periodo = 6;

        for (int i = 1; i <= periodo; i++) { 
                resultado = vp * Math.Pow(1 + juros, i);
                Console.WriteLine("O rendimento atual é: " + resultado);
            }
        }
    }
