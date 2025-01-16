using LAB01;
using LAB02;
using LAB03;
using Lab04;


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
                        //     Lab3.Run();
                        //     break;
                        // case 4:
                        //     Lab4.Run();
                        //     break;
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


// Lab03


//class Zwierze {
//    public virtual void DajGlos() {
//        Console.WriteLine("dzwiek pies");    
//    }
//}


//class Pies: Zwierze
//{
//    public override void DajGlos()
//    {
//        Console.WriteLine("dzwiek pies 2");
//    }
//}

//class Kot : Zwierze
//{
//    public override void DajGlos()
//    {
//        Console.WriteLine("dzwiek kot");
//    }
//}


//abstract class Figura {
//    public abstract double ObliczPole();


//    public void Info()
//    {
//        Console.WriteLine("figura geometryczna");
//    }
//}

//class Kwadrat: Figura {
//    private double bok;

//    public Kwadrat(double bok) { 

//    }

//    public override double ObliczPole()
//    {
//        return bok * bok;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Figura figura = new Kwadrat(5);
//        figura.Info();
//        Console.WriteLine("Pole kwadratu:" + figura.ObliczPole());
//    }
//}//abstract class Figura {
//    public abstract double ObliczPole();


//    public void Info()
//    {
//        Console.WriteLine("figura geometryczna");
//    }
//}

//class Kwadrat: Figura {
//    private double bok;

//    public Kwadrat(double bok) { 

//    }

//    public override double ObliczPole()
//    {
//        return bok * bok;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Figura figura = new Kwadrat(5);
//        figura.Info();
//        Console.WriteLine("Pole kwadratu:" + figura.ObliczPole());
//    }
//}

//interface IZwierze
//{
//    void DajGlos();

//}

//class Pies: IZwierze
//{
//    public void DajGlos()
//    {
//        Console.WriteLine("Pies wydaje dzwiek");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        IZwierze zwierze = new Pies();
//        zwierze.DajGlos();
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
       
//    }
//}

//List<Shape> shapes =  new List<Shape>();

////
//shapes.Add(new Rectangle(10, 20, 30, 40));
//shapes.Add(new Triangle(10, 20, 30, 40));
////shapes.Add(new Circle(5, 10, 10);

//foreach (Shape shape in shapes)
//    shape.Draw();


//enum Kolor
//{
//    Zielony,
//    Niebieski,
//    Czerwony = 10,
//}

// class MojeWyjatki : Exception
// {
//     public MojeWyjatki(string message) : base(message)
//     {
//     }
// }





// class Program
// {
//     static void Main(string[] args)
//     {
//         try
//         {
//             SprawdzLiczbe(-23);
//         }
//         catch (MojeWyjatki ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//         {
//
//         }
//
//         static void SprawdzLiczbe(int liczba)
//         {
//             if (liczba <= 0)
//             {
//                 throw new MojeWyjatki("Liczba musi byc wieksza od zera");
//             }
//         }
//     }
// }

//TODO: lab 4 exercise 2


