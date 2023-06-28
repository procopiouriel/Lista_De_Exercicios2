public class Aluno
{
    public string nome;
    public string email;
    public double nota1;
    public double nota2;

    public double Calculo()
    {
        double resultado = nota1 + nota2;
        return resultado / 2;
    }
}