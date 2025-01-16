namespace LAB02
{
    internal class Osoba
    {
        //definiowanie pol
        private string firstName;
        private string lastName;
        private int age;

        //Właściwści (gettery i settery)
        public string FirstName{
            get { return firstName; }
            set { if (value.Length > 2) firstName = value;
                else Console.WriteLine("Imie musi posiadać minimum dwa znaki");
            }
        }
        public string LastName {
            get { return lastName; }
            set { if (value.Length > 2) lastName = value;
                else Console.WriteLine("Nazwisko musi posiadać minimum dwa znaki");
            }
        }

        public int Age {
            get { return age;  }
            set {
                if (value < 0) Console.WriteLine("Wiek nie może być ujemny");
                else age = value;
            }
        }

        public Osoba(string firstName, string lastName, int age)
        {
            //pola klasy = parametry metody (lewo - prawo)
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            
        }

        //konstruktor kopiujący (zawsze jeden argument)
        //public Osoba(Osoba user) { 
        //    firstName = user.firstName;
        //    lastName = user.lastName;
        //    age = user.age;
        //}

        public void View()
        {
            //Console.WriteLine($"Imie:\t{firstName}\tNazwisko:\t{lastName}\tWiek:\t{age}");
            Console.WriteLine("Imie: " + firstName + " Nazwisko: " + lastName + " Wiek: " + age);
        }

    }
}