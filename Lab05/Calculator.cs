namespace LAB05
{
    public enum Operation
    {
        Add,
        Substract,
        Multiply,
        Divide
    }

    public static class Exercise1
    {
        private static List<double> resultHistory = new List<double>();

        public static void Run()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("\nPodaj pierwszą liczbę:");
                    double number1 = GetNumber();

                    Console.WriteLine("Podaj drugą liczbę:");
                    double number2 = GetNumber();

                    Console.WriteLine("Wybierz operację (Dodawanie, Odejmowanie, Mnozenie, Dzielenie):");
                    Operation operation = GetOperation();

                    double result = PerformOperation(number1, number2, operation);

                    Console.WriteLine($"Wynik: {result}");
                    resultHistory.Add(result);

                    Console.WriteLine("Czy chcesz kontynuować? (tak/nie):");
                    string decision = Console.ReadLine()?.ToLower();
                    if (decision != "tak") break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nieprawidłowy format danych. Spróbuj ponownie.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Nie można dzielić przez zero. Spróbuj ponownie.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Wystąpił nieoczekiwany błąd: {ex.Message}");
                }
            }
            Console.WriteLine("\nHistoria wyników:");
            DisplayHistory();
        }

        private static double GetNumber()
        {
            Console.Write("Wprowadź liczbę: ");
            return double.TryParse(Console.ReadLine(), out double number) 
                ? number 
                : throw new FormatException("Podana wartość nie jest liczbą.");
        }

        private static Operation GetOperation()
        {
            Console.Write("Wprowadź operację: ");
            return Enum.TryParse(Console.ReadLine(), true, out Operation operation) 
                ? operation 
                : throw new FormatException("Podano nieprawidłową operację.");
        }

        private static double PerformOperation(double number1, double number2, Operation operation)
        {
            return operation switch
            {
                Operation.Add => number1 + number2,
                Operation.Substract => number1 - number2,
                Operation.Multiply => number1 * number2,
                Operation.Divide when number2 != 0 => number1 / number2,
                Operation.Divide => throw new DivideByZeroException(),
                _ => throw new InvalidOperationException("Nieznana operacja.")
            };
        }

        private static void DisplayHistory()
        {
            Console.WriteLine("\nHistoria wyników:");
            foreach (double result in resultHistory)
            {
                Console.WriteLine(result);
            }
        }

        // public static void Main()
        // {
        //     var calculator = new Calculator();
        //     calculator.Run();
        // }
    }
}
