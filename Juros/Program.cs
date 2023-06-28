using System;

class Juros1
{
    public static void Main(string[] args)
    {
        Juros conexao = new Juros();

        Console.WriteLine("Digite um valor: ");
        double valor = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a taxa de juros: ");
        double taxa = Convert.ToDouble(Console.ReadLine());
        conexao.CalcularJuros(valor, taxa);

    }
}