using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];





        Console.WriteLine("Ingrese numeros hasta el 10:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Numero {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        



        int[] ascendente = numeros.OrderBy(n => n).ToArray();
        Console.WriteLine("\nNumeros  ascendentes:");
        foreach (int n in ascendente)
        {
            Console.Write(n + " ");
        }




        int[] descendente = numeros.OrderByDescending(n => n).ToArray();
        Console.WriteLine("\n\nNumeros  descendentes:");
        foreach (int n in descendente)
        {
            Console.Write(n + " ");
        }

        Console.WriteLine();
    }
}