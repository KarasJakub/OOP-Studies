using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01;

internal class Exercise6
{
    public static void Run()
    {
        while (true)
        {
            Console.WriteLine("Podaj liczbę");
            double input = Convert.ToDouble(Console.ReadLine());
            if (input == 0)
            {
                break;
            }
        }
    }

}
