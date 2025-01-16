using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01;

internal class Exercise4
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
        //Total
        double total = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            total += numbers[i];
        }
        Console.WriteLine($"Suma elementów: {total}");

        //Product
        double product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        Console.WriteLine($"Iloczyn elementów: {product}");

        //Average
        double avergae = total / numbers.Length;
        Console.WriteLine($"Średnia wartość: {avergae}");

        //Minimum
        double min = numbers.Min();
        Console.WriteLine($"Minimalna wartość: {min}");

        //Maximum
        double max = numbers.Max();
        Console.WriteLine($"Maksymalna wartość: {max}");
    }
}
