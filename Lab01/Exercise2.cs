using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01;

internal class Exercise2
{
    public static void Run()
    {
    ViewMenu:
        Console.WriteLine("Kalkulator");
        Console.WriteLine("1. Suma\n2. 2.Różnica\n3. 3. Iloczyn\n4. 4. Iloraz\n5. 5.Potęgowanie\n6. 6. Pierwiastek\n7. 7. FUnkcje trygonometryczne\n8. Wyjście ");
        Console.WriteLine("Wybierz opcje");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1: Total(); break;
            case 2: Difference(); break;
            case 3: ProductNumber(); break;
            case 4: QuationNumber(); break;
            case 5: PotenttionNumber(); break;
            case 6: SquareNumber(); break;
            case 7: Trigonometry(); break; //zamiana wartosci (input * Math.PI) / 180
            case 8: Close(); break;
            default: Console.WriteLine("Błędny wybór, wybierz opcje jeszcze raz"); goto ViewMenu;
                //switch end
        }
    }
    static void Trigonometry()
    {
        double input = Exercise1.DoubleInput();
        double a = ((input * Math.PI) / 180);
        Console.WriteLine($"Wartości trygonometryczne dla kąta {input} = {Math.Sin(a)}");
        Console.WriteLine($"Wartości trygonometryczne dla kąta {input} = {Math.Cos(a)}");
        Console.WriteLine($"Wartości trygonometryczne dla kąta {input} = {Math.Tan(a)}");
        Console.WriteLine($"Wartości trygonometryczne dla kąta {input} = {(1 / Math.Tan(a))}");
    }

    static void SquareNumber()
    {
        double a = Exercise1.DoubleInput();
        Console.WriteLine($"Pierwiastek z {a} = {Math.Sqrt(a)}");
    }

    static void PotenttionNumber()
    {
        double a = Exercise1.DoubleInput();
        double b = Exercise1.DoubleInput();
        Console.WriteLine($"Potęga {a} ^ {b} = {Math.Pow(a, b)}");
    }

    static void QuationNumber()
    {
        double a = Exercise1.DoubleInput();
        double b = Exercise1.DoubleInput();
        Console.WriteLine($"Iloraz {a} / {b} = {a / b}");
    }

    static void ProductNumber()
    {
        double a = Exercise1.DoubleInput();
        double b = Exercise1.DoubleInput();
        Console.WriteLine($"Iloczyn {a} * {b} = {a * b}");
    }

    static void Difference()
    {
        double a = Exercise1.DoubleInput();
        double b = Exercise1.DoubleInput();
        Console.WriteLine($"Różnica {a} - {b} = {a - b}");

    }
    static void Total()
    {
        double a = Exercise1.DoubleInput();
        double b = Exercise1.DoubleInput();
        Console.WriteLine($"Suma {a} + {b} = {a + b}");
    }
    static void Close()
    {
        Console.WriteLine("Koniec programu");
        System.Environment.Exit(1); //wyjście z terminala
    }
}
