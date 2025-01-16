namespace LAB04
{

    class Zwierze
    {
        public virtual void DajGlos()
        {
            Console.WriteLine("dzwiek pies");
        }
    }


    class Pies : Zwierze
    {
        public override void DajGlos()
        {
            Console.WriteLine("dzwiek pies 2");
        }
    }

    class Kot : Zwierze
    {
        public override void DajGlos()
        {
            Console.WriteLine("dzwiek kot");
        }
    }


    abstract class Figura
    {
        public abstract double ObliczPole();


        public void Info()
        {
            Console.WriteLine("figura geometryczna");
        }
    }

    class Kwadrat : Figura
    {
        private double bok;

        public Kwadrat(double bok)
        {

        }

        public override double ObliczPole()
        {
            return bok * bok;
        }
    }

}