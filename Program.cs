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

Zadanie3();

void Zadanie3()
{
    Student2 student2 = new Student2("Jan", "Nowak");
    student2.AddGrades(4);
    student2.AddGrades(3);
    student2.AddGrades(3);
    student2.AddGrades(5);
}