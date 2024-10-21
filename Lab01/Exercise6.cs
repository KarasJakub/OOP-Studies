using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01;

internal class Exercise6
{
    public void Run()
    {
        while (true)
        {
            Console.WriteLine("Podaj liczbę");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            if (number == 0)
            {
                break;
            }
        }
    }

}
