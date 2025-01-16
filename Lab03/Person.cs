namespace LAB03
{
    internal class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        
        public Person(string firstName, string lastName, int age)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._age = age;
        }
        
        public virtual void View()
        {
            Console.WriteLine($"Imie: {_firstName}, Nazwisko: {_lastName}, Wiek: {_age}");
        }
    }
}