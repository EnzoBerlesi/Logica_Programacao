public class Juros
{
    public static void CalcularJuros () //Exercicio 1
    {
        Juros juros = new Juros ();
        double valorFuturo;
        double valorPresente = 1000.00;
        double taxaJuros = 0.053;
        double periodoAM = 10;
        valorFuturo = valorPresente * Math.Pow(taxaJuros + 1 ,periodoAM);

        Console.WriteLine("O valor após a taxação é: " + valorFuturo);
    }
}