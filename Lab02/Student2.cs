using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Student2
    {
        private string firstName;
        private string lastName;
        double[]? grades = new double[10];
        private int countGrades;

        public Student2(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public double SredniaOcen
        {
            get
            {
                if (grades == null || countGrades == 0) return 0;
                double suma = 0;
                for (int i = 0; i < countGrades; i++)
                {
                    suma += grades[i];
                }
                return suma / countGrades; //srednia
            }
        }
        public void AddGrades(double ocena)
        {
            if (ocena < 2 || ocena > 5) {
                Console.WriteLine("Ocena musi być z przedziału od 2 do 5");
                return;
            }
            if (grades == null)
            {
                Console.WriteLine("Tablica nie może być pusta");
                return;
            }
            if (countGrades >= grades.Length)
            {
                Console.WriteLine("Nie można dodać oceny, tablica pełan");
                return;
            }
            grades[countGrades] = ocena;
            countGrades++;
            Console.WriteLine($"Dodano ocenę: {ocena}. Aktualna średnia: {SredniaOcen:F2}");
        }
    }
}


//F2 - float - 2 spaces after the dot