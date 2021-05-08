using System;
class Desafio
{
    static void Main()
    {
        int limit = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < limit; i++)
        {
            string[] line = Console.ReadLine().Split(" ");
            if (line.Length == 0)
            {

            }
            else
            {
                double X = double.Parse(line[0]);
                double Y = double.Parse(line[1]);
                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double divisao = X / Y; // Digite aqui o calculo da divisao
                    Console.WriteLine(Math.Round(divisao).ToString("N1"));
                }
            }

        }
    }
}