using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        
        int inputNumber = -1;
        int max = 0;

        while (inputNumber != 0)
        {
            
            Console.Write("Enter Number: ");
            inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber != 0)
            {
                
                numbers.Add(inputNumber);
            }
            else
            {
                Console.WriteLine($"The Sum is: {numbers.Sum()}");
                double average = numbers.Average();
                Console.WriteLine($"The average is: {average}");
                foreach (int number in numbers)
                {
                    if (number > max)
                    {
                        max = number;
                    }
                }
                Console.WriteLine($"The largest number is {max}");
            }
        }
    }
}