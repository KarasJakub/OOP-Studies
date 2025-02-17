﻿using System;
using System.Collections.Specialized;

namespace LAB01
{
    internal class Exercise1
    {
        public static double DoubleInput(string message = "Podaj liczbę")
        {
            Console.WriteLine(message);
            double input = Convert.ToDouble(Console.ReadLine());
            return input;
        }
        public static void Run()
        {
            double a = DoubleInput();
            double b = DoubleInput();
            double c = DoubleInput();
            double delta, x1, x2;

            if (a != 0)
            {
                delta = Math.Pow(b, 2) - (4 * a * c);
                if (delta < 0)
                {
                    Console.WriteLine("Brak rozwiązań z zbiorcze liczb rzeczywistych");
                }
                else if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine("Jedno roziązanie x1:" + x1);
                }
                else
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Dwa rozwiazania: \tx1 = " + x1 + "\t x2 = " + x2);
                }
            }
            else
            {
                Console.WriteLine("To nie jest równanie kwardatowe");
            }
        }
    }
}