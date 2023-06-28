using System;

class AtividadeCaixa
{
    static void Main(string[] args)
    {
        Caixa conexao0 = new Caixa();//CHAMAR A CLASSE CONTA.CS
        Console.WriteLine("Digite o seu nome: ");
        conexao0.nome = Console.ReadLine();

        Console.WriteLine("Tipo da conta: ");
        Console.WriteLine("1- Poupança");
        Console.WriteLine("2- Corrente");
        conexao0.tipoconta = Convert.ToInt32(Console.ReadLine());
        conexao0.valor = 0;

        while (true)
        {
            Console.WriteLine("Selecione o que deseja: ");
            Console.WriteLine("1- Sacar");
            Console.WriteLine("2- Depositar");

            int operacao = Convert.ToInt32(Console.ReadLine());
            switch (operacao)
            {
                case 1:
                    Console.Write("Digite um valor que deseja sacar: \nR$ ");
                    double valor = Convert.ToDouble(Console.ReadLine());
                    conexao0.Saque(valor);
                    break;

                case 2:
                    Console.Write("Digite um valor que deseja depositar: \nR$ ");
                    double valor1 = Convert.ToDouble(Console.ReadLine());
                    conexao0.Deposito(valor1);
                    break;
            }
        }
    }
}