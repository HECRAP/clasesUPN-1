using System;

class Ejer5
{
    static void Main()
    {
        double sumaTotal = 0;
        int numerador = 45;
        int denominador = 4;

        Console.WriteLine("Fracciones generadas:");

        for (int i = 0; i < 60; i++)
        {
            Console.WriteLine($"{numerador}/{denominador}");
            sumaTotal += (double)numerador / denominador;
            numerador -= 3;
            denominador += 3;
        }

        Console.WriteLine(new string('-', 20));
        Console.WriteLine($"La suma total de las 60 fracciones es: {sumaTotal:F4}");
    }
}