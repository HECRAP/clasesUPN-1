using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer6_cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Azar = new Random();
            int[] frecuencias = new int[6];

            Console.WriteLine("Lanzamientos del dado: ");

            for (int i = 0; i < 50; i++)
            {
                int resultado = Azar.Next(1, 7);
                frecuencias[resultado - 1]++;
            }

            Console.WriteLine("\nFrecuencia de cada resultado: ");
            for(int i = 0; i < 6; i++ )
            {
                   Console.WriteLine($"Cara {i + 1}: {frecuencias[i]} veces");
            }
        }
    }
}
