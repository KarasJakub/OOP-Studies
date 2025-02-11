namespace LAB06
{
    class Exercise3
    {
        public static void Run()
        {
            string fileName = "pesels.txt";
            if (!File.Exists(fileName))
            {
                Console.WriteLine("Plik pesels.txt nie istnieje. Generowanie przykładowego pliku...");
                GenerateSamplePeselFile(fileName);
            }
        
            List<string> pesels = File.ReadAllLines(fileName).ToList();
            int femaleCount = CountFemalePesels(pesels);
            Console.WriteLine($"Liczba kobiet w zbiorze: {femaleCount}");
        }
    
        private static int CountFemalePesels(List<string> pesels)
        {
            return pesels.Count(pesel => pesel.Length == 11 && (pesel[9] - '0') % 2 == 0);
        }
    
        private static void GenerateSamplePeselFile(string fileName)
        {
            string[] samplePesels = {
                "44051401359", "55030567824", "60010112347", "72043003416",
                "83021509862", "90112287632", "95073043281", "99010145678"
            };
            File.WriteAllLines(fileName, samplePesels);
            Console.WriteLine("Plik pesels.txt został wygenerowany.");
        }
    }
}