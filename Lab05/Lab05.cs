namespace LAB05
{
    public class Lab05
    {
        public static void Run()
        {
            Console.WriteLine("Wybierz zadanie z LAB2 (1-3): ");
            int exerciseChoice = Convert.ToInt32(Console.ReadLine());

            switch (exerciseChoice)
            {
                case 1: Exercise1.Run(); break;
                case 2: Exercise2.Run(); break;
                case 3: Exercise3.Run(); break;
                default:
                    Console.WriteLine("Błędny wybór zadania w LAB2.");
                    break;
            }
        }
    }
}