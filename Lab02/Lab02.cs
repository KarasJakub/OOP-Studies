namespace LAB02
{
    public class Lab02
    {
        public static void Run()
        {
            Console.WriteLine("Wybierz zadanie z LAB2 (1-5): ");
            int exerciseChoice = Convert.ToInt32(Console.ReadLine());

            switch (exerciseChoice)
            {
                case 1: Exercise1.Run(); break;
                case 2: Exercise2.Run(); break;
                case 3: Exercise3.Run(); break;
                case 4: Exercise4.Run(); break;
                case 5: Exercise5.Run(); break;
                default:
                    Console.WriteLine("Błędny wybór zadania w LAB2.");
                    break;
            }
        }
    }
}