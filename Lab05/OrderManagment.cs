using System;
using System.Collections.Generic;

namespace LAB05
{
    public enum StatusZamowienia
    {
        Oczekujace,
        Przyjete,
        Zrealizowane,
        Anulowane
    }

    public static class Exercise2
    {
        private static Dictionary<int, (StatusZamowienia Status, List<string> Produkty)> zamowienia = new();

        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Dodaj zamówienie");
                Console.WriteLine("2. Zmień status zamówienia");
                Console.WriteLine("3. Wyświetl zamówienia");
                Console.WriteLine("4. Wyjście");

                Console.Write("Wybierz opcję: ");
                string wybor = Console.ReadLine();

                switch (wybor)
                {
                    case "1":
                        DodajZamowienie();
                        break;

                    case "2":
                        ZmienStatusZamowienia();
                        break;

                    case "3":
                        WyswietlZamowienia();
                        break;

                    case "4":
                        Console.WriteLine("Koniec programu.");
                        return;

                    default:
                        Console.WriteLine("Nieprawidłowy wybór.");
                        break;
                }
            }
        }

        private static void DodajZamowienie()
        {
            Console.Write("Podaj numer zamówienia: ");
            if (int.TryParse(Console.ReadLine(), out int numer))
            {
                Console.Write("Podaj produkty (oddzielone przecinkami): ");
                var produkty = Console.ReadLine()?.Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (produkty != null && produkty.Length > 0)
                {
                    if (zamowienia.ContainsKey(numer))
                    {
                        Console.WriteLine($"Zamówienie o numerze {numer} już istnieje.");
                        return;
                    }

                    zamowienia[numer] = (StatusZamowienia.Oczekujace, new List<string>(produkty));
                    Console.WriteLine($"Dodano zamówienie o numerze {numer}.");
                }
                else
                {
                    Console.WriteLine("Nie podano żadnych produktów.");
                }
            }
            else
            {
                Console.WriteLine("Nieprawidłowy numer zamówienia.");
            }
        }

        private static void ZmienStatusZamowienia()
        {
            Console.Write("Podaj numer zamówienia: ");
            if (int.TryParse(Console.ReadLine(), out int numerDoZmiany))
            {
                Console.WriteLine("Dostępne statusy: Oczekujace, Przyjete, Zrealizowane, Anulowane");
                Console.Write("Podaj nowy status: ");

                if (Enum.TryParse(Console.ReadLine(), true, out StatusZamowienia nowyStatus))
                {
                    try
                    {
                        if (!zamowienia.ContainsKey(numerDoZmiany))
                        {
                            throw new KeyNotFoundException($"Nie znaleziono zamówienia o numerze {numerDoZmiany}.");
                        }

                        var obecnyStatus = zamowienia[numerDoZmiany].Status;

                        if (obecnyStatus == nowyStatus)
                        {
                            throw new ArgumentException($"Zamówienie {numerDoZmiany} już ma status {nowyStatus}.");
                        }

                        zamowienia[numerDoZmiany] = (nowyStatus, zamowienia[numerDoZmiany].Produkty);
                        Console.WriteLine($"Zmieniono status zamówienia {numerDoZmiany} na {nowyStatus}.");
                    }
                    catch (KeyNotFoundException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy status zamówienia.");
                }
            }
            else
            {
                Console.WriteLine("Nieprawidłowy numer zamówienia.");
            }
        }

        private static void WyswietlZamowienia()
        {
            if (zamowienia.Count == 0)
            {
                Console.WriteLine("Brak zamówień.");
                return;
            }

            Console.WriteLine("Lista zamówień:");
            foreach (var zamowienie in zamowienia)
            {
                Console.WriteLine($"Numer: {zamowienie.Key}, Status: {zamowienie.Value.Status}, Produkty: {string.Join(", ", zamowienie.Value.Produkty)}");
            }
        }
    }
}
