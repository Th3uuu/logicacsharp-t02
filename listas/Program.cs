using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> nomes = new List<string>();

        // Adicionando elementos
        nomes.Add("Ana");
        nomes.Add("Bruno");
        nomes.Add("Carlos");

        Console.WriteLine(nomes[0]); // Ana
        Console.WriteLine(nomes[1]); // Bruno
        Console.WriteLine(nomes[2]); // Carlos

        Console.WriteLine("\nLista após adicionar elementos:");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }



        // Adiciona novo nome 
        nomes.Add("Daniel");

        Console.WriteLine("\nLista após adicionar 'Daniel':");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        // Removendo elementos
        nomes.Remove("Bruno"); // Remove pelo valor

        Console.WriteLine("\nLista após remover 'Bruno':");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        // Remove pelo índice
        nomes.RemoveAt(0); // remove o primeiro (Ana)

        Console.WriteLine("\nLista após remover o índice 0 (Ana)");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        // Limpando a lista
        nomes.Clear();

        Console.WriteLine("\nLista após Clear():");
        Console.WriteLine("Quantidade de elementos: " + nomes.Count);

    }

}
