namespace LAB06
{
    internal class Exercise2
    {
        public static void Run() {
            Console.Write("Podaj nazwę pliku do odczytu: ");
            string fileName = Console.ReadLine();
            if (File.Exists(fileName))
            {
                string content = File.ReadAllText(fileName);
                Console.WriteLine($"Zawartość pliku {fileName}:\n{content}");
            }
            else
            {
                Console.WriteLine("Podany plik nie istnieje.");
            }
        }
    }
}