namespace LAB02
{
    internal class Exercise2
    {
        public static void Run()
        {
             BankAccount bankAccount = new BankAccount("Jan Nowak", 4000);
             bankAccount.View();
             bankAccount.Wplata(200);
             bankAccount.View();
             bankAccount.Wyplata(100);

             Console.WriteLine("Podaj środki do wypłaty:");
             int value = int.Parse(Console.ReadLine());
             bankAccount.Wyplata(value);
        }
    }
}