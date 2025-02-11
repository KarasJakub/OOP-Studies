namespace LAB07
{
    public class Lab07
    {
        public static void Run()
        {
            ClientManager manager = new ClientManager();
        while (true)
        {
            Console.WriteLine("1. Dodaj klienta");
            Console.WriteLine("2. Wyświetl klientów");
            Console.WriteLine("3. Zaktualizuj klienta");
            Console.WriteLine("4. Usuń klienta");
            Console.WriteLine("5. Wyjście");
            Console.Write("Wybór: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Imię: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Nazwisko: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    if (!ValidationHelper.IsValidEmail(email))
                    {
                        Console.WriteLine("Nieprawidłowy email!");
                        break;
                    }
                    Console.Write("Telefon: ");
                    string phone = Console.ReadLine();
                    if (!ValidationHelper.IsValidPhone(phone))
                    {
                        Console.WriteLine("Nieprawidłowy numer telefonu!");
                        break;
                    }
                    manager.AddClient(new Client { FirstName = firstName, LastName = lastName, Email = email, Phone = phone });
                    break;
                case "2":
                    manager.DisplayClients();
                    break;
                case "3":
                    Console.Write("Podaj ID klienta: ");
                    if (int.TryParse(Console.ReadLine(), out int updateId))
                    {
                        Console.Write("Nowy numer telefonu: ");
                        string newPhone = Console.ReadLine();
                        if (ValidationHelper.IsValidPhone(newPhone))
                        {
                            manager.UpdateClient(updateId, newPhone);
                        }
                        else Console.WriteLine("Nieprawidłowy numer telefonu!");
                    }
                    break;
                case "4":
                    Console.Write("Podaj ID klienta do usunięcia: ");
                    if (int.TryParse(Console.ReadLine(), out int deleteId))
                    {
                        manager.DeleteClient(deleteId);
                    }
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Nieznana opcja.");
                    break;
            }
        }
        }
    }
}