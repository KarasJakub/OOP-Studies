using LAB01;
using LAB02;
using LAB03;
using LAB04;
using LAB05;
using LAB06;


namespace AllExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Wybierz laboratorium (1, 2, 3): /0 - Wyjście");
                while (true)
                {
                    Console.Write("Wybierz laboratorium: ");
                    int labChoice = Convert.ToInt32(Console.ReadLine());

                    switch (labChoice)
                    {
                        case 1:
                            Lab01.Run(); 
                            break;
                        case 2:
                            Lab02.Run();
                            break;
                        // case 3:
                        //     Lab03.Run();
                        //     break;
                        case 4:
                            Lab04.Run();
                            break;
                        case 5:
                            Lab05.Run();
                            break;
                        case 6:
                            Lab06.Run();
                            break;
                        case 0:
                            Close();
                            break;
                        default:
                            Console.WriteLine("Błędny wybór, wybierz ponownie.");
                            break;
                    }
                }

                static void Close()
                {
                    Console.WriteLine("Koniec programu");
                    System.Environment.Exit(1);
                }
            }
        }
    }
}




