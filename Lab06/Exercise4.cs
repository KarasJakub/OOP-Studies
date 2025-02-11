using System.Text.Json;

namespace LAB06
{
    class Exercise4
    {
        private static List<PopulationRecord> _populationData;

        public Exercise4()
        {
            LoadData("db.json");
        }

        private void LoadData(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Plik db.json nie istnieje.");
                return;
            }
            string json = File.ReadAllText(filePath);
            _populationData = JsonSerializer.Deserialize<List<PopulationRecord>>(json);
        }

        public static void Run()
        {
            Console.WriteLine("Podaj kraj (India, China, United States): ");
            string country = Console.ReadLine();
            Console.WriteLine("Podaj rok: ");
            string year = Console.ReadLine();
        
            var record = _populationData.FirstOrDefault(r => r.Country.Value == country && r.Date == year);
            if (record != null)
            {
                Console.WriteLine($"Populacja w roku {year} dla {country}: {record.Value}");
            }
            else
            {
                Console.WriteLine("Brak danych dla podanego roku i kraju.");
            }
        }
    }

    class PopulationRecord
    {
        public Indicator Indicator { get; set; }
        public Country Country { get; set; }
        public string Value { get; set; }
        public string Date { get; set; }
    }

    class Indicator
    {
        public string Id { get; set; }
        public string Value { get; set; }
    }

    class Country
    {
        public string Id { get; set; }
        public string Value { get; set; }
    }
}