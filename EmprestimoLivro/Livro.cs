public class Livro
{
    public string titulo;
    public string autor;
    public DateTime anoLancamento;
    public bool status;
    public int codigo;

    public Livro(string titulo, string autor, DateTime anoLancamento, bool status, int codigo)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.status = status;
        this.codigo = codigo;
    }
}