using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello Prep3 World!");

        // Console.Write("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int number = int.Parse(magicNumber);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        
        int guess = -1;

        
        
            
        while (guess != number)
        {    
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);
            if (guess > number)
            {
                Console.WriteLine("Lower");
            }

            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }


    }
}