using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Studies.Lab04
{
    public class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Pesel { get; set; }
        public void SetFirstName(string imie)
        {
            if (string.IsNullOrWhiteSpace(imie))
                throw new ArgumentException("Imię nie może być puste.");
            Imie = imie;
        }

        public void SetLastName(string nazwisko)
        {
            if (string.IsNullOrWhiteSpace(nazwisko))
                throw new ArgumentException("Nazwisko nie może być puste.");
            Nazwisko = nazwisko;
        }

        public void SetPesel(string pesel)
        {
            if (pesel.Length != 11 || !long.TryParse(pesel, out _))
                throw new ArgumentException("PESEL musi składać się z 11 cyfr.");
            Pesel = pesel;
        }
    }

}
