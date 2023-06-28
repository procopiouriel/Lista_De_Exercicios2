using System;

public class Emprestimo
{
    public Livro livro;
    public Pessoa pessoa;
    public DateTime dataEmprestimo;
    public DateTime horaEmprestimo;
    public DateTime dataDevolucao;

    public bool Emprestimo1(Pessoa pessoa, Livro livro, DateTime dataDevolucao)
    {
        

        dataDevolucao = new DateTime(2023, 04, 12).Date;
        if (livro.status == true)
        {
            livro.status = false;
            this.livro = livro;
            Console.WriteLine("Livro emprestado!!!");
            Console.WriteLine("Voce deve devolver o livro em:" + dataDevolucao);
        }
        return false;
    }


    public bool DevoluçaoLIVRO(string livro1)
    {
        if (this.livro.titulo == livro1)//MESMO LIVRO
        {
            this.livro.status = true;
            Console.WriteLine("Livro devolvido!");
            return true;
        }
        else
        {
            Console.WriteLine("Esse livro nao foi emprestado");
            return false;
        }
    }
}