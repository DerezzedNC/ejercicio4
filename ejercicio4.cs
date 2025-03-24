using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[5];

        // Pedir al usuario que ingrese 5 números
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Ingresa el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Mostrar el arreglo original
        Console.WriteLine("\nArreglo original:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }

        // Mostrar el arreglo invertido
        Console.WriteLine("\n\nArreglo invertido:");
        for (int i = numeros.Length - 1; i >= 0; i--)
        {
            Console.Write(numeros[i] + " ");
        }

        Console.WriteLine(); // Salto de línea final
    }
}
