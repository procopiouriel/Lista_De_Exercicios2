public class Caixa
{
    public string nome;
    public int tipoconta;
    public double sacar;
    public double depositar;
    public double valor;

    public void Saque(double valorSaque)
    {
        double valo = valor;


        if (valorSaque > valor)
        {
            Console.WriteLine("Saldo insuficiente, deposite uma quantia!");
        }
        else
        {
            valor -= valorSaque;
            Console.WriteLine("Saque concluido!");
            Console.WriteLine("Saldo da sua conta no momento é: " + valor.ToString("C2"));
        }
    }

    public void Deposito(double valorDeposito)
    {
        if (valorDeposito <= 0)
        {
            Console.WriteLine("Quantia invalida!");
        }
        else
        {
            valor += valorDeposito;
            Console.WriteLine("Deposito concluido!");
            Console.WriteLine("Saldo da sua conta no momento é: " + valor.ToString("C2"));
        }
    }
}