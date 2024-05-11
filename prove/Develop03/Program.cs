using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Reference r1 = new Reference("Moroni", 7, 33);
        Console.Write($"{r1.GetDisplayText()} ");

        Scripture s1 = new Scripture(r1, "33 And Christ hath said: If ye will have faith in me ye shall have power to do whatsoever thing is expedient in me.");
        Console.WriteLine(s1.GetDisplayText());
        string choice = "";
        

        while (choice != "quit")
        {
            
            s1.HideRandomWords(2);
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            choice = Console.ReadLine();
            Console.Clear();
            
            Console.Write($"{r1.GetDisplayText()} ");
            Console.WriteLine(s1.GetDisplayText());
            
            
            if (s1.IsCompletelyHidden() == true)
            {
                
                choice = "quit";
                Console.WriteLine("All words hidden.");
                
                
            }
           // else
           // {
              //  Console.Write($"{r1.GetDisplayText()} ");
              //  Console.WriteLine(s1.GetDisplayText());
                
          //  }
        }
    }
}