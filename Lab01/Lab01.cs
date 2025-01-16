namespace LAB01
{
    public class Lab01
    {
        public static void Run()
        {
            Console.WriteLine("Wybierz zadanie z LAB1 (1-7): ");
            int exerciseChoice = Convert.ToInt32(Console.ReadLine());

            switch (exerciseChoice)
            {
                case 1: Exercise1.Run(); break;
                case 2: Exercise2.Run(); break;
                case 3: Exercise3.Run(); break;
                case 4: Exercise4.Run(); break;
                case 5: Exercise5.Run(); break;
                case 6: Exercise6.Run(); break;
                case 7: Exercise7.Run(); break;
                default:
                    Console.WriteLine("Błędny wybór zadania w LAB1.");
                    break;
            }
        }
    }
}