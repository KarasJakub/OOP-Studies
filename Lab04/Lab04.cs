namespace LAB04 
{
    public static class Lab04
    {
        public static void Run()
        {
            List<IOsobaZadanie3> osoby = new List<IOsobaZadanie3>([
                new OsobaZadanie3("Marian", "kapusta"),
                new OsobaZadanie3("Alicja", "Zawiślak"),
                new OsobaZadanie3("Jakub", "Nowak"),
            ]);
            osoby.WritePersons();

            List<IStudent> students = new List<IStudent>([
                new StudentWSIiZ("Jan", "Kowalski", "ABC", 2021, 6),
                new StudentWSIiZ("Marian", "Złoty", "IIZ", 2024, 1),
            ]);

            students.WritePersons();
        }
        public static void WritePersons(this List<IOsobaZadanie3> osoby)
        {
            foreach (var osoba in osoby)
            {
                osoba.GetFullName();
            }
        }
    
        public static void WritePersons(this List<IStudent> osoby)
        {
            foreach (var osoba in osoby)
            {
                Console.WriteLine(osoba.GetFullNameAndSchool());
            }
        }
    }
    

}