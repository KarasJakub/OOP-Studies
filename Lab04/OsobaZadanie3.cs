namespace LAB04
{
    internal class OsobaZadanie3: IOsobaZadanie3
    {
        public OsobaZadanie3()
        {
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void GetFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

        public OsobaZadanie3(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}