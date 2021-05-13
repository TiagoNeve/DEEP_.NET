using System;
using System.Collections.Generic;
class Desafio03
{
    static void Main()
    {
        int numeroDeListas = int.Parse(Console.ReadLine());
        for (int i = 0; i < numeroDeListas; i++)
        {
            string lista = Console.ReadLine();

            string[] itens = lista.Split(" ");
            List<string> novaLista = new List<string>();
            foreach (string item in itens)
            {
                if (!Array.Exists(novaLista, element => element == item))
                {
                    novaLista.Add(item);
                }
            }
            Console.WriteLine(novaLista[2]);
        }
    }
}