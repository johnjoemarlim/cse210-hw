using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture l1 = new Lecture("Object Oriented Programming", "Inheritance", "04/06/2024", "9:00am", "123 Elm Str", "New York City", "NY", "USA", "Bob the Builder", 150);
        Console.WriteLine(l1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(l1.LectureGetFullDetails());
        Console.WriteLine();
        Console.WriteLine(l1.LectureGetShortDescription());
        Console.WriteLine();

        Console.WriteLine("===================================");

        Reception r1 = new Reception("Graduation", "MSD 321 Graduation Party", "08/06/2024", "6:00pm", "234 Elm Str", "New York City", "NY", "USA", "vartuaste@gmail.com");
        Console.WriteLine(r1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(r1.ReceptionFullDetails());
        Console.WriteLine();
        Console.WriteLine(r1.ReceptionShortDescription());
        Console.WriteLine();

        Console.WriteLine("===================================");

        Outdoor o1 = new Outdoor("Bridge Tour", "Tour the London bridge", "01/08/2024", "10:00am", "246 Oak Circle", "London", "England", "UK", "Chance of rain and wind");
        Console.WriteLine(o1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(o1.OutdoorFullDetails());
        Console.WriteLine();
        Console.WriteLine(o1.OutdoorShortDescription());
        Console.WriteLine();

        Console.WriteLine("===================================");
    }
}