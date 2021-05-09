using System;

class Desafio2
{
    static void Main()
    {
        // O programa lerá as duas notas do alunos e imprimirá a média

        bool continuarCalculo = true;
        bool mediaLiberada = false;

        do
        {
            double primeiraNota = -1.0;
            double segundaNota = 0.0;
            double media = 0.0;


            while (!mediaLiberada)
            {
                double nota = double.Parse(Console.ReadLine());
                if (0.0 <= nota && nota <= 10.0)
                {
                    if (primeiraNota != -1.0)
                    {
                        segundaNota = nota;

                        media = (primeiraNota + segundaNota) / 2;

                        Console.WriteLine($"media = {media.ToString("N2")}");
                        mediaLiberada = true;
                    }
                    else
                    {
                        primeiraNota = nota;
                    }
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }

            }

            Console.WriteLine("novo calculo (1-sim 2-nao)");
            string resposta = Console.ReadLine();
            if (resposta == "2")
            {
                break;
            }
            else if (resposta == "1")
            {
                mediaLiberada = false;
            }
            else
            {
                // Faz nada
            }

        } while (continuarCalculo);
    }
}