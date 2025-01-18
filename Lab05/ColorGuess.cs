namespace LAB05
{
    public enum Kolor
    {
        Czerwony,
        Niebieski,
        Zielony,
        Zolty,
        Fioletowy
    }

    public static class Exercise3
    {
        private static readonly List<Kolor> DostepneKolory = new()
        {
            Kolor.Czerwony,
            Kolor.Niebieski,
            Kolor.Zielony,
            Kolor.Zolty,
            Kolor.Fioletowy
        };

        public static void Run()
        {
            Random random = new Random();
            Kolor wylosowanyKolor = DostepneKolory[random.Next(DostepneKolory.Count)];

            Console.WriteLine("Zgadnij wylosowany kolor. Dostępne kolory: Czerwony, Niebieski, Zielony, Zolty, Fioletowy.");

            while (true)
            {
                try
                {
                    Console.Write("Podaj kolor: ");
                    string input = Console.ReadLine();

                    if (Enum.TryParse(input, true, out Kolor zgadywanyKolor))
                    {
                        if (!DostepneKolory.Contains(zgadywanyKolor))
                        {
                            throw new ArgumentException($"Kolor {zgadywanyKolor} nie znajduje się na liście dostępnych kolorów.");
                        }

                        if (zgadywanyKolor == wylosowanyKolor)
                        {
                            Console.WriteLine("Brawo! Odgadłeś prawidłowy kolor!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Nie zgadłeś. Spróbuj ponownie.");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Podany tekst nie jest poprawnym kolorem.");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Koniec gry.");
        }
    }
}
