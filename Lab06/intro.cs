// string path = "plik.txt";

// tworzenie i zapis do pliku
// FILE StreamWriter & StreamRider
// using (StreamWriter writer = new StreamWriter(path))
// {
//     writer.WriteLine("Witaj, dziś jest niedziela 19.01.2025r");
//     writer.WriteLine("To jest przykładowy tekst");
// }
//
// Console.WriteLine("PLik został zapisany");
//
// //dodanie tekstu
// using (StreamWriter writer = new StreamWriter(path, true))
// {
//     writer.WriteLine("test");
// }
//
//
//
// //odczyt
// Console.WriteLine("Zawartośc pliku: ");
// using (StreamReader reader = new StreamReader(path))
// {
//     string linia;
//     while (linia = reader.ReadLine() != null)
//     {
//         Console.WriteLine(linia);
//     }
// }
//
//
// if (File.Exists(path))
// {
//     Console.WriteLine("Plik istnieje");
// } else Console.WriteLine("PLik nie istnieje");

//File.Delete(path);

// string zawartosc = File.ReadAllText(path);
// Console.WriteLine(zawartosc);
//
// string[] lineArr = File.ReadAllLines(path);
// foreach (var line in lineArr)
//     Console.WriteLine(line);
//     
// Directory.CreateDirectory("GL02");
// Console.WriteLine("Katalog został utworzony");
// string[] pliki = Directory.GetFiles(".");
// foreach (string file in pliki)
//     Console.WriteLine(file);
    
    
//bin
//serializacja - konwersja obiektów do postaci bitowej


// using System.Text.Json;
//
// Osoba osoba = new Osoba("Jan", 25);
//
// string path = "osoba.json";
//
// string json = JsonSerializer.Serialize(osoba);
// File.WriteAllText(path, json);
//
// Console.WriteLine("Obiekt został zapisny do JSON");
//
// //deserializacja danych
// string jsonDeseralized = File.ReadAllText(path);
// Osoba inputOsoba = JsonSerializer.Deserialize<Osoba>(jsonDeseralized);
// Console.WriteLine(inputOsoba.Imie, inputOsoba.Wiek);
//     
// public class Osoba
// {
//     public string Imie { get; set; }
//     public int Wiek { get; set; }
//
//     public Osoba(string imie, int wiek)
//     {
//         Imie = imie;
//         Wiek = wiek;
//     }
// }