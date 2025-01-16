namespace LAB03
{
    public class Samochod
    {
        private string Marka { get; set; }
        private string Model { get; set; }
        private string Nadwozie { get; set; }
        private string Kolor { get; set; }
        private int RokProdukcji { get; set; }
        private int przebieg;

        public int Przebieg
        {
            get { return przebieg; }
            set { przebieg = value >= 0 ? value : throw new ArgumentException("Przebieg nie może być ujemny."); }
        }

        public Samochod()
        {
            Console.Write("Podaj markę: ");
            Marka = Console.ReadLine();
            Console.Write("Podaj model: ");
            Model = Console.ReadLine();
            Console.Write("Podaj nadwozie: ");
            Nadwozie = Console.ReadLine();
            Console.Write("Podaj kolor: ");
            Kolor = Console.ReadLine();
            Console.Write("Podaj rok produkcji: ");
            RokProdukcji = int.Parse(Console.ReadLine());
            Console.Write("Podaj przebieg: ");
            Przebieg = int.Parse(Console.ReadLine());
        }

        public Samochod(string marka, string model, string nadwozie, string kolor, int rokProdukcji, int przebieg)
        {
            this.Marka = marka;
            this.Model = model;
            this.Nadwozie = nadwozie;
            this.Kolor = kolor;
            this.RokProdukcji = rokProdukcji;
            this.Przebieg = przebieg;
        }

        public virtual void WyswietlInformacje()
        {
            Console.WriteLine($"Marka: {Marka}, Model: {Model}, Nadwozie: {Nadwozie}, Kolor: {Kolor}, Rok produkcji: {RokProdukcji}, Przebieg: {Przebieg}");
        }
    }
}