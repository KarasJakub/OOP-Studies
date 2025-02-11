using System.Text.Json;

namespace LAB06
{
    class Exercise5
    {
        public static void Run()
        {
            FilePersonRepository repository = new FilePersonRepository();
            Console.WriteLine("Dodaj nową osobę: Podaj imię:");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj wiek:");
            int age = int.Parse(Console.ReadLine());
            repository.AddPerson(name, age);
            Console.WriteLine("Osoba dodana.");
        }
        
        interface IPersonRepository
        {
            void AddPerson(string name, int age);
            List<Person> GetAllPersons();
        }

        class FilePersonRepository : IPersonRepository
        {
            private const string FileName = "people.json";
    
            public void AddPerson(string name, int age)
            {
                List<Person> persons = GetAllPersons();
                persons.Add(new Person { Name = name, Age = age });
                File.WriteAllText(FileName, JsonSerializer.Serialize(persons));
            }
    
            public List<Person> GetAllPersons()
            {
                if (!File.Exists(FileName)) return new List<Person>();
                return JsonSerializer.Deserialize<List<Person>>(File.ReadAllText(FileName)) ?? new List<Person>();
            }
        }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

    }
}