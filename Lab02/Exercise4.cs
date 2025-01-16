namespace LAB02
{
    internal class Exercise4
    {
        public static void Run()
        {
            Licz licz1 = new Licz(4);
            licz1.Dodaj(5);
            licz1.Odejmij(3);
            licz1.GetValue();

            Licz licz2 = new Licz(-6.5);
            licz2.Dodaj(5);
            licz2.Odejmij(0.33);
            licz2.GetValue();

            Licz licz3 = new Licz(0);
            licz3.Dodaj(3);
            licz3.Odejmij(3.01);
            licz3.GetValue();
        }
    }
}