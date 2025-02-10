namespace LAB06
{
    internal class Exercise1
    {
        public static void Run()
        {
            Console.Write("Podaj numer albumu: ");
            string albumNumber = Console.ReadLine();

            // Zapytanie o nazwę pliku
            Console.Write("Podaj nazwę pliku (z rozszerzeniem, np. dane.txt): ");
            string fileName = Console.ReadLine();

            // Zapis do pliku
            File.WriteAllText(fileName, albumNumber);

            Console.WriteLine($"Numer albumu został zapisany w pliku: {fileName}");
        }
    }
}