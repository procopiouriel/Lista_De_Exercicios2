public class Conversao
{
    public int Conversao1(int horas)
    {
        return horas * 60;
    }
    public int Conversao2(int minutos)
    {
        return  minutos * 60;
    }
    public int Conversao3(int segundos)
    {
        int resultado = segundos / 60;
        return resultado / 60;
    }
}