using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_en_C__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una nota (0-20): ");
            int nota = Convert.ToInt32(Console.ReadLine());

            if (nota < 0 || nota > 20)
            {
                Console.WriteLine("Error: nota fuera de rango.");
                return;
            }

            switch (nota)
            {
                case int n when (n >= 0 && n <= 10):
                    Console.WriteLine("Desaprobado");
                    break;
                case int n when (n >= 11 && n <= 13):
                    Console.WriteLine("Regular");
                    break;
                case int n when (n >= 14 && n <= 17):
                    Console.WriteLine("Bueno");
                    break;
                case int n when (n >= 18 && n <= 20):
                    Console.WriteLine("Excelente");
                    break;
            }

            if (nota >= 14 && nota % 2 == 0)
                Console.WriteLine("Buen desempeño con nota par");

            if (nota < 11 || nota % 2 != 0)
                Console.WriteLine("Necesita reforzar");

            Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(nota):F1}");
            Console.WriteLine($"Potencia al cubo: {Math.Pow(nota, 3)}");
        }
    }
}
