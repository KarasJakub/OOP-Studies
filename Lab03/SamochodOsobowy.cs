namespace LAB03
{
    public class SamochodOsobowy : Samochod
    {
        private double waga;
        private double pojemnoscSilnika;
        public int IloscOsob { get; set; }

        public double Waga
        {
            get { return waga; }
            set { waga = (value >= 2 && value <= 4.5) ? value : throw new ArgumentException("Waga powinna być z przedziału 2-4,5 t."); }
        }

        public double PojemnoscSilnika
        {
            get { return pojemnoscSilnika; }
            set { pojemnoscSilnika = (value >= 0.8 && value <= 3.0) ? value : throw new ArgumentException("Pojemność silnika powinna być z przedziału 0,8-3,0."); }
        }

        public SamochodOsobowy() : base()
        {
            Console.Write("Podaj wagę: ");
            Waga = double.Parse(Console.ReadLine());
            Console.Write("Podaj pojemność silnika: ");
            PojemnoscSilnika = double.Parse(Console.ReadLine());
            Console.Write("Podaj ilość osób: ");
            IloscOsob = int.Parse(Console.ReadLine());
        }

        public override void WyswietlInformacje()
        {
            base.WyswietlInformacje();
            Console.WriteLine($"Waga: {Waga} t, Pojemność silnika: {PojemnoscSilnika} l, Ilość osób: {IloscOsob}");
        }
    }
}