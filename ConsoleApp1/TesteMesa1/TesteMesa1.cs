using ConsoleApp1.TesteMesa2;

public class TesteMesa1
{
    static void Main(string[] args)
    {
        int[] v = new int[5];
        int a = 10;
        int b = 20;
        int c = (a + b) / 2;
        c = c - 40;
        v[3] = a + b + c;
        Console.WriteLine("O resultado de v[3] é " + v[3]);

        LerEntradas.Entradas();

        Juros.CalcularJuros();

        Rendimento.RendimentoMensal();

        QuintoMes.Quinto();

        Problema5.Problema();

    }
}