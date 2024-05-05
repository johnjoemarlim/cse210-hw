using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        string response = "";
        string fileName = "";

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Journal theJournal = new Journal();

        Boolean displayLoad = false;

        while (response !="5")
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            response = Console.ReadLine();
            

            if (response == "1")
            {
                PromptGenerator randPrompts = new PromptGenerator();
                randPrompts._prompts.Add("Who was the most interesting person I interacted with today?");
                randPrompts._prompts.Add("What was the best part of my day?");
                randPrompts._prompts.Add("How did I see the hand of the Lord in my life today?");
                randPrompts._prompts.Add("What was the strongest emotion I felt today?");
                randPrompts._prompts.Add("If I had one thing I could do over today, what would it be?");
                randPrompts._prompts.Add("Who have I helped today?");
                randPrompts._prompts.Add("What have I learned today?");
                randPrompts._prompts.Add("What was the most interesting place that I've been to today?");

                
                Entry anEntry = new Entry();
                anEntry._date = dateText;

                anEntry._promptText = randPrompts.GetRandomPrompt();

                anEntry._entryText = Console.ReadLine();
 
                theJournal.AddEntry(anEntry);
               
                displayLoad = false;
                  
            }

            if (response == "2")
            {

                if (displayLoad == false)
                {
                    theJournal.DisplayAll();
                }
                else
                {
                    theJournal.LoadDisplayAll();
                }

            }

            if (response == "3")
            {
                Console.Write("What is the filename? ");
                fileName = Console.ReadLine();
                theJournal.LoadFromFile(fileName);
                displayLoad = true;


            }

            if (response == "4")
            {
                Console.Write("What is the filename? ");
                fileName = Console.ReadLine();
                theJournal.SaveToFile(fileName);
            }

        }
        
    }
}