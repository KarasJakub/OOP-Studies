using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01;

internal class Exercise3
{
    public static void Run()
    {
        double[] numbers = new double[10];

        Exercise1.DoubleInput("Wprowadź 10 liczb rzeczywistych:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Liczba {i + 1}: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        int choice;
        do
        {
            Console.WriteLine("\nWybierz opcję:");
            Console.WriteLine("1 - Wyświetl tablicę od pierwszego do ostatniego indeksu.");
            Console.WriteLine("2 - Wyświetl tablicę od ostatniego do pierwszego indeksu.");
            Console.WriteLine("3 - Wyświetl elementy o nieparzystych indeksach.");
            Console.WriteLine("4 - Wyświetl elementy o parzystych indeksach.");
            Console.WriteLine("5 - Zakończ program.");
            Console.Write("Wybór: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Tablica od pierwszego do ostatniego indeksu:");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine($"Index {i}: {numbers[i]}");
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Tablica od ostatniego do pierwszego indeksu:");
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine($"Index {i}: {numbers[i]}");
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("Elementy o nieparzystych indeksach:");
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine($"Index {i}: {numbers[i]}");
                    }
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("Elementy o parzystych indeksach:");
                for (int i = 0; i < numbers.Length; i += 2)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"Index {i}: {numbers[i]}");
                    }
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("Zakończono program.");
            }
            else
            {
                Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
            }

        } while (choice != 5);
    }
}
