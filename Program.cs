using Lab01;
using Lab02;

// Lab01

// var DeltaCount = new Exercise1();
// var Calculator = new Exercise2();
// var Array = new Exercise3();
// var ArrayMinMax = new Exercise4();
// var CountingDown = new Exercise5();
// var InfiiiteLoop = new Exercise6();
// var Sorting = new Exercise7();

//Calculator.Run();
//DeltaCount.Run();
//Array.Run();
//ArrayMinMax.Run();
//CountingDown.Run();
//InfiiiteLoop.Run();
// Sorting.Run();

// Lab02

// Console.WriteLine("Podaj imie");
// string firstName = Console.ReadLine();
// Console.WriteLine("Podaj nazwisko");
// string lastName = Console.ReadLine();
// Console.WriteLine("Podaj wiek");
// int age = int.Parse(Console.ReadLine());
//
// // creatng object of class Osoba
// Osoba osoba = new Osoba(firstName, lastName, age);
// osoba.View();

// static void RunBankAccount()
// {
//     BankAccount bankAccount = new BankAccount("Jan Nowak", 4000);
//
//     bankAccount.View();
//     bankAccount.Wplata(200);
//     bankAccount.View();
//     bankAccount.Wyplata(100);
//
// }
// RunBankAccount();

//Inheriting

// Dziedziczenie();
// void Dziedziczenie()
// {
//     Student student = new Student("Jan", "Kowalski", 22, "w23466");
//     student.View();
//     student.ViewStudent();
// }

// Zadanie3();
//
// void Zadanie3()
// {
//     Student2 student2 = new Student2("Jan", "Nowak");
//     student2.AddGrades(4);
//     student2.AddGrades(3);
//     student2.AddGrades(3);
//     student2.AddGrades(5);
// }


 // Zadanie 4
// static void Licz()
// {
//     Licz licz1 = new Licz(4);
//     licz1.Dodaj(5);
//     licz1.Odejmij(3);
//     licz1.GetValue();
//
//     Licz licz2 = new Licz(-6.5);
//     licz2.Dodaj(5);
//     licz2.Odejmij(0.33);
//     licz2.GetValue();
//
//     Licz licz3 = new Licz(0);
//     licz3.Dodaj(3);
//     licz3.Odejmij(3.01);
//     licz3.GetValue();
// }
// Licz();

// ZADANIE 5
 // static void CreateSumator()
 // {
 //  Sumator sumator = new Sumator([1,2,3,4,5,6]);
 //  Console.WriteLine($"Suma: {sumator.Suma()}");
 //  Console.WriteLine($"Suma podzielnych /2: {sumator.SumaPodziel2()}");
 //  Console.WriteLine($"Elementów: {sumator.IleElementow()}");
 //  sumator.PrintAll();
 //  sumator.PrintIndexRange(1,3);
 //  sumator.PrintIndexRange(-1, 22);
 // }
 // CreateSumator();