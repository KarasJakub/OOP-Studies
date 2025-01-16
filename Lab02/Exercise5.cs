namespace LAB02
{
    internal class Exercise5
    {
        // Metoda główna bez argumentów
        public static void Run()
        {
          Sumator sumator = new Sumator([1,2,3,4,5,6]);
          Console.WriteLine($"Suma: {sumator.Suma()}");
          Console.WriteLine($"Suma podzielnych /2: {sumator.SumaPodziel2()}");
          Console.WriteLine($"Elementów: {sumator.IleElementow()}");
          sumator.PrintAll();
          sumator.PrintIndexRange(1,3);
          sumator.PrintIndexRange(-1, 22);
        }
    }
}