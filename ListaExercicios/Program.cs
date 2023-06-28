using System;

class ExercicioConta
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Conta conexao = new Conta();
            Console.WriteLine("Escolha uma operação: ");
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                //SOMA
                case 1:
                    Console.WriteLine("Digite um numero: ");
                    double valor1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite um numero: ");
                    double valor2 = Convert.ToDouble(Console.ReadLine());
                    conexao.Soma(valor1, valor2);
                    Console.WriteLine("Resultado: " + conexao.Soma(valor1, valor2));
                    break;

                //SUBTRACAO
                case 2:
                    Console.WriteLine("Digite um numero: ");
                    double valor3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite um numero: ");
                    double valor4 = Convert.ToDouble(Console.ReadLine());
                    conexao.Subtracao(valor3, valor4);
                    Console.WriteLine("Resultado: " + conexao.Subtracao(valor3, valor4));
                    break;

                //MULTIPLICACAO
                case 3:
                    Console.WriteLine("Digite um numero: ");
                    double valor5 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite um numero: ");
                    double valor6 = Convert.ToDouble(Console.ReadLine());
                    conexao.Multiplicacao(valor5, valor6);
                    Console.WriteLine("Resultado: " + conexao.Multiplicacao(valor5, valor6));
                    break;

                //DIVISAO
                case 4:
                    Console.WriteLine("Digite um numero: ");
                    double valor7 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite um numero: ");
                    double valor8 = Convert.ToDouble(Console.ReadLine());
                    conexao.Divisao(valor7, valor8);
                    Console.WriteLine("Resultado: " + conexao.Divisao(valor7, valor8));
                    break;
            }
        }
    }
}