public class Juros
{
    public void CalcularJuros(double valor, double percentual)
    {
        double resultado = (valor * percentual) / 100;//VALOR DE JUROS
        Console.WriteLine("Valor de juros: " + resultado);
        double resultado1 = resultado + valor;
        Console.WriteLine("Valor total: " + resultado1);
    }
}