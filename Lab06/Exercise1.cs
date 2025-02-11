namespace LAB06
{
    internal class Exercise1
    {
        public static void Run()
        {
            Console.Write("Podaj numer albumu: ");
            string albumNumber = Console.ReadLine();
            Console.Write("Podaj nazwę pliku (z rozszerzeniem, np. dane.txt): ");
            string fileName = Console.ReadLine();
            File.WriteAllText(fileName, albumNumber);
            Console.WriteLine($"Numer albumu został zapisany w pliku: {fileName}");
        }
    }
}