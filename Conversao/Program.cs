using System;

class ExercicioConversao
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Conversao conexao = new Conversao();
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1- Converter horas em minutos");
            Console.WriteLine("2- Converter minutos em segundos");
            Console.WriteLine("3- Converter segundos em horas");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite quantas horas deseja converter: ");
                    int hora = Convert.ToInt32(Console.ReadLine());
                    conexao.Conversao1(hora);
                    Console.WriteLine(conexao.Conversao1(hora) + " minutos.");
                    break;

                case 2:
                    Console.WriteLine("Digite quantos minutos deseja converter: ");
                    int minuto = Convert.ToInt32(Console.ReadLine());
                    conexao.Conversao2(minuto);
                    Console.WriteLine(conexao.Conversao2(minuto) + " segundos.");
                    break;

                case 3:
                    Console.WriteLine("Digite quantos segundos deseja converter: ");
                    int segundo = Convert.ToInt32(Console.ReadLine());
                    conexao.Conversao3(segundo);
                    Console.WriteLine(conexao.Conversao3(segundo) + " hora.");
                    break;
            }
        } 
    }
}