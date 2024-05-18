using System.Diagnostics;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    
    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }
    public void Run()
    {
        DisplayStartingMessasge();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        // var watch = Stopwatch.StartNew();
        
        

        
        
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowTimer(5);

        Console.Clear();

        while (DateTime.Now < endTime)
        {
            if (_questions.Count() != 0)
            {
                DisplayQuestions();
                ShowSpinner(5);
                Console.WriteLine();
            }
            else
            {
                _questions.Add("Why was this experience meaningful to you?");
                _questions.Add("Have you ever done anything like this before?");
                _questions.Add("How did you get started?");
                _questions.Add("How did you feel when it was complete?");
                _questions.Add("What made this time different than other times when you were not as successful?");
                _questions.Add("What is your favorite thing about this experience?");
                _questions.Add("What could you learn from this experience that applies to other situations?");
                _questions.Add("What did you learn about yourself through this experience?");
                _questions.Add("How can you keep this experience in mind in the future?");
                
            }
            // DisplayQuestions();
            // ShowSpinner(5);
            // Console.WriteLine();
            // DisplayQuestions();
            // ShowSpinner(5);
            // Console.WriteLine();
            // DisplayQuestions();
            // ShowSpinner(5);
            // Console.WriteLine();
            // DisplayQuestions();
            // ShowSpinner(5);
            // Console.WriteLine();
            // DisplayQuestions();
            // ShowSpinner(5);
            // Console.WriteLine();
            // DisplayQuestions();
            // ShowSpinner(5);
            // Console.WriteLine();
            // DisplayQuestions();
            // ShowSpinner(5);
            // Console.WriteLine();

            
        }
        Console.WriteLine();
        DisplayEndMessage();
        ShowSpinner(5);
        
    }
    public string GetRandomPrompt()
    {
        
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        
        // if (_usedPrompts.Contains(_prompts[i]) == false)
        // {
        //     _usedPrompts.Add(GetRandomPrompt());
        // }
        // Console.WriteLine(_usedPrompts);
        // _prompts.Remove(_prompts[i]);
        string prompt = _prompts[i];
        // if (_prompts.Count != 0)
        // {
        //     _prompts.Remove(prompt);
        // }
        return prompt;
        
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int i = random.Next(_questions.Count);
        string question = _questions[i];
        _questions.Remove(question);
        return question;
        
        // if (_questions.Count != 0)
        // {
        //     string question = _questions[i];
        //     _questions.Remove(question);
        //     return question;
        // }
        
    }
    public void DisplayPrompt()
    {
        
            
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        // _prompts.Remove(GetRandomPrompt());
    
        
    }
    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()} ");
        // _questions.Remove(GetRandomQuestion());
        // foreach (string q in _questions)
        // {
        //     Console.WriteLine(q);
        // }
    }
}