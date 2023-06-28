using System;

class ExercicioAluno
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Aluno conexao = new Aluno();//CONEXAO

            Console.WriteLine("Digite seu nome: ");
            conexao.nome = Console.ReadLine();
            Console.WriteLine("Digite seu email: ");
            conexao.email = Console.ReadLine();

            Console.WriteLine("Digite sua primeira nota: ");
            conexao.nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua segunda nota: ");
            conexao.nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O " + conexao.nome + " do email " + conexao.email + " ficou com a média de: " + conexao.Calculo() + " pontos.);
        }
    }
}