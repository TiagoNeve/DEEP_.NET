using System;

class Desafio02
{
    public static void Main()
    {
        int Chico = 300;
        int Bento = 1500;
        int Bernardo = 600;
        int Marina = 1000;
        int Lara = 150;
        int Marlene = 225;
        int totalMandioca = 0;
        int[] convidado = new int[5];
        for (int i = 0; i < 5; i++)
        {
            convidado[i] = int.Parse(Console.ReadLine());
        }

        totalMandioca += convidado[0] * Chico;
        totalMandioca += convidado[1] * Bento;
        totalMandioca += convidado[2] * Bernardo;
        totalMandioca += convidado[3] * Marina;
        totalMandioca += convidado[4] * Lara;

        Console.WriteLine(totalMandioca + Marlene);

    }
}