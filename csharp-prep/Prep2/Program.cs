using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "";

            if (grade >= 90)
            {
                letter = "A";

            }
            else if (grade >= 80)
            {
                 letter = "B";
            }
            else if (grade >= 70)
            {
                 letter = "C";
            }
            else if (grade >= 60)
            {
                 letter = "D";
            }
            else
            {
                 letter = "F";
            }

                if (letter == "A" || letter == "B" || letter == "C")
                {
                    Console.WriteLine($"Your letter grade is {letter}.");
                    Console.WriteLine("Congratulations! You passed the course!");
                }
                else
                {
                    Console.WriteLine($"Your letter grade is {letter}.");
                    Console.WriteLine("I know you can do better next time!");
                }
    }
}