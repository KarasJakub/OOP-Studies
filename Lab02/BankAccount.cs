namespace LAB02
{
    internal class BankAccount
    {
        //set prywatny get publiczny

        public decimal Saldo { get; private set;  }
        public string Wlasciciel { get; set; }

        public BankAccount(string wlasciciel, decimal saldo)
        {
            Saldo = saldo;
            Wlasciciel = wlasciciel;
        }

        public void Wplata(decimal kwota)
        {
            if (kwota <= 0) { Console.WriteLine("Kwota wpłaty nie może być ujemna lub równa 0"); return; }
            else {
                Saldo += kwota;
                Console.WriteLine($"Wpłacono: {kwota:C}. Aktualny stan konta: {Saldo:C}");
            }
        }

        public void Wyplata (decimal kwota)
        {
            if (kwota <= 0) { Console.WriteLine("Kwota wpłaty nie może być ujemna lub równa 0"); return; }
            if (kwota > Saldo)
            {
                Console.WriteLine("Niewysarzjaco srodkow na koncie");
                return;
            }
            else
            {
                Saldo -= kwota;
                Console.WriteLine($"Wypłacono: {kwota:C}. Aktualny stan konta: {Saldo:C}");
            }
        }

        public void View()
        {
            Console.WriteLine($"Właściciel: {Wlasciciel}. Saldo: {Saldo}");
        }
    }
}