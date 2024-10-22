using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01;

internal class Exercise7
{
    public void Run()
    {
        Console.Write("Ile liczb chcesz wprowadzić? ");
        int GivenN = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[GivenN];

        Console.WriteLine("Wprowadź liczby:");
        for (int i = 0; i < GivenN; i++)
        {
            Console.Write($"Liczba {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nWybierz metodę sortowania:");
        Console.WriteLine("1 - Sortowanie bąbelkowe");
        Console.WriteLine("2 - Sortowanie przez wstawianie");
        Console.Write("Twój wybór: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            BubbleSort(numbers);
        }
        else if (choice == 2)
        {
            InsertionSort(numbers);
        }
        else
        {
            Console.WriteLine("Nieprawidłowy wybór!");
            return;
        }

        Console.WriteLine("\nPosortowane liczby:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    static void InsertionSort(int[] array)
    {
        int n = array.Length;
        for (int i = 1; i < n; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
    }
}
