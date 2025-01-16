namespace LAB02
{
    internal class Exercise1
    {
        public static void Run()
        {

            Console.WriteLine("Podaj imię:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Podaj Nazwisko:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Podaj wiek:");
            int age = int.Parse(Console.ReadLine());

            //tworzenie klasy osoba
            Osoba osoba = new Osoba(firstName,lastName,age);
            osoba.View();


        }
    }
}