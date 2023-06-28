using System;

class EmprestimoLivro
{
    static void Main(string[] args)
    {       
        while (true)
        {
            DateTime datahoraatual = DateTime.Now;


            Console.WriteLine("Digite o nome do livro que deseja pegar: ");
            string livro = Console.ReadLine();

            Livro conexao1 = new Livro(livro, "Machado de Assis", new DateTime(2023, 04, 07).Date, true, 06131);
            Emprestimo conexao2 = new Emprestimo();
            Pessoa conexao3 = new Pessoa("Uriel", 034416542, "procopiouriel928@gmail.com");

            conexao2.Emprestimo1(conexao3, conexao1, datahoraatual);

            Console.WriteLine("Digite o nome do livro que deseja devolver: ");
            string livro1 = Console.ReadLine();
            conexao2.DevoluçaoLIVRO(livro1);
        }
    }
}
