public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private string _rank;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        int response = 0;

        

        do
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine($" 1. Create New Goal");
            Console.WriteLine($" 2. List Goals");
            Console.WriteLine($" 3. Save Goals");
            Console.WriteLine($" 4. Load Goals");
            Console.WriteLine($" 5. Record Event");
            Console.WriteLine($" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            response = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (response == 1)
            {
                CreateGoal();
                Console.WriteLine();
            }

            if (response == 2)
            {
                ListGoalDetails();
                Console.WriteLine();
            }
            
            if (response == 3)
            {
                SaveGoals();
                Console.WriteLine();
            }

            if (response == 4)
            {
                LoadGoals();
                Console.WriteLine();
            }

            if (response == 5)
            {
                RecordEvent();
                Console.WriteLine();
            }

            // if (response != 1 || response != 2 || response != 3 || response != 4 || response != 5 || response != 6 ||)
            // {
            //     Console.WriteLine("Please choose from the menu.");
            //     Console.WriteLine();
            // }
        }while (response != 6);
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine($"Your rank is: {Ranker()}");
        Console.WriteLine();
    }
    public void ListGoalNames()
    {
        int number = 1;
        Console.WriteLine("The goals are:");
        List<string> lines = new List<string>();
        // List<string> namesList = new List<string>();
        foreach (Goal goal in _goals)
        {
            
            lines.Add(goal.GetStringRepresentation());
            
        }
        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");
            string goalName = parts[1];
            Console.Write($"{number}. ");
            Console.WriteLine($"{goalName}");
            number += 1;
            // Console.WriteLine(goalName);
            
        }
        // foreach (string name in namesList)
        // {
        //     Console.Write($"{number}. ");
        //     Console.WriteLine(name);
        //     number += 1;
        // }
        // Console.Write("Which goal did you accomplish? ");
        // int answer = int.Parse(Console.ReadLine());

        // for (int i = 0; i < _goals.Count;)
        // {
        //     Console.WriteLine()
        // }
    }
    public void ListGoalDetails()
    {
        int number = 1;
        Console.WriteLine("Your goals are:");
        foreach (Goal goal in _goals)
        {
            Console.Write($"{number}. ");
            Console.WriteLine(goal.GetDetailString());
            number += 1;
        }
    }
    public void CreateGoal()
    {
        int choice;

        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal whoul you like to create? ");
        choice = int.Parse(Console.ReadLine());

        

        if (choice == 1)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            SimpleGoal sG = new SimpleGoal(name, description, points);
            _goals.Add(sG);
        }
        if (choice == 2)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            EternalGoal eG = new EternalGoal(name, description, points);
            _goals.Add(eG);
        }
        if (choice == 3)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            int amountCompleted = 0;
            ChecklistGoal cG = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
            _goals.Add(cG);
        }

        
    }
    public void RecordEvent()
    {
        string goalType = "";
        int bonus = 500;
        List<string> lines = new List<string>();
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int answer = int.Parse(Console.ReadLine());
        int index = answer - 1;
        foreach (Goal goal in _goals)
        {
            lines.Add(goal.GetStringRepresentation());
        }
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");
            goalType = parts[0];

            if (goalType == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool IsComplete = bool.Parse(parts[4]);
                
                SimpleGoal sG = new SimpleGoal(name, description, points);
                if (lines[index] == sG.GetStringRepresentation())
                {
                    sG.RecordEvent();
                    
                    _goals[index] = sG;
                    string prevRank = Ranker();
                    _score = _score + points;
                    string newRank = Ranker();
                    Console.WriteLine($"Congratulations! You have earned {points} points!");
                    Console.WriteLine($"You now have {_score} points");
                    if (prevRank != newRank)
                    {
                        Console.WriteLine($"Congratulations! Your rank is now {_rank}");
                    }
                }
            }

            if (goalType == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                
                EternalGoal eG = new EternalGoal(name, description, points);
                if (lines[index] == eG.GetStringRepresentation())
                {
                    eG.RecordEvent();
                    _goals[index] = eG;
                    string prevRank = Ranker();
                    _score = _score + points;
                    string newRank = Ranker();
                    Console.WriteLine($"Congratulations! You have earned {points} points!");
                    Console.WriteLine($"You now have {_score} points");
                    if (prevRank != newRank)
                    {
                        Console.WriteLine($"Congratulations! Your rank is now {_rank}");
                    }
                }
            }
            if (goalType == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[6]);
                ChecklistGoal cG = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                if (lines[index] == cG.GetStringRepresentation())
                {
                    cG.RecordEvent();
                    _goals[index] = cG;
                    if (cG.GetTarget() == cG.GetAmountCompleted())
                    {
                        string prevRank = Ranker();
                        _score = _score + bonus + points;
                        string newRank = Ranker();
                        Console.WriteLine($"Congratulations! You have earned {points + bonus} points!");
                        Console.WriteLine($"You now have {_score} points");
                        if (prevRank != newRank)
                        {
                            Console.WriteLine($"Congratulations! Your rank is now {_rank}");
                        }
                    }
                    else
                    {
                        string prevRank = Ranker();
                        _score += points;
                        string newRank = Ranker();
                        Console.WriteLine($"Congratulations! You have earned {points} points!");
                        Console.WriteLine($"You now have {_score} points");
                        if (prevRank != newRank)
                        {
                            Console.WriteLine($"Congratulations! Your rank is now {_rank}");
                        }
                    }   
                    
                }
            }
        }
        
        


        

    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                
                outputFile.WriteLine(goal.GetStringRepresentation());
                
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        
        int score = int.Parse(File.ReadAllLines(fileName).First());
        string[] lines = File.ReadAllLines(fileName).Skip(1).ToArray();

        _score = score;
        int bonus = 0;
        int target = 0;
        int amountCompleted = 0;
        string goalType = "";
        string name = "";
        string description = "";
        int points = 0;

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");
            
            goalType = parts[0];
                
            if (goalType == "SimpleGoal")
            {
                name = parts[1];
                description = parts[2];
                points = int.Parse(parts[3]);
                if (int.TryParse(parts[4], out int result) == true)
                {
                    bonus = int.Parse(parts[4]);
                }
                else
                {
                    bool IsComplete = bool.Parse(parts[4]);
                }
                SimpleGoal sG = new SimpleGoal(name, description, points);
                _goals.Add(sG);
            }
            if (goalType == "EternalGoal")
            {
                name = parts[1];
                description = parts[2];
                points = int.Parse(parts[3]);
                
                EternalGoal eG = new EternalGoal(name, description, points);
                _goals.Add(eG);
            }
            if (goalType == "ChecklistGoal")
            {
                name = parts[1];
                description = parts[2];
                points = int.Parse(parts[3]);
                
                bonus = int.Parse(parts[4]);
                
                
                target = int.Parse(parts[5]);
                amountCompleted = int.Parse(parts[6]);
                ChecklistGoal cG = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                _goals.Add(cG);
            }
            
        
                
            
            

                // if (goalType == "SimpleGoal")
                // {
                //     SimpleGoal sG = new SimpleGoal(name, description, points);
                //     _goals.Add(sG);
                // }
                // if (goalType == "EternalGoal")
                // {
                //     EternalGoal eG = new EternalGoal(name, description, points);
                //     _goals.Add(eG);
                // }
                // if (goalType == "ChecklistGoal")
                // {
                //     ChecklistGoal cG = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                //     _goals.Add(cG);
                // }
            
        }
    }
    // public void DisplayGoals()
    // {
    //     foreach (Goal goal in _goals)
    //     {
    //         Console.WriteLine(goal.GetDetailString());
    //     }
    // }
    public string Ranker()
    {
        if (_score < 1000)
        {
            _rank = "Unranked";
            
        }
        if (_score >= 1000 && _score < 1500)
        {
            _rank = "Bronze I";
        }
        if (_score >= 1500 && _score < 2000)
        {
            _rank = "Bronze II";
        }
        if (_score >= 2000 && _score < 2500)
        {
            _rank = "Bronze III";
        }
        if (_score >= 2500 && _score < 3000)
        {
            _rank = "Silver I";
        }
        if (_score >= 3000 && _score < 3500)
        {
            _rank = "Silver II";
        }
        if (_score >= 3500 && _score < 4000)
        {
            _rank = "Silver III";
        }
        if (_score >= 4000 && _score < 4500)
        {
            _rank = "Gold I";
        }
        if (_score >= 4500 && _score < 5000)
        {
            _rank = "Gold II";
        }
        if (_score >= 5000 && _score < 5500)
        {
            _rank = "Gold III";
        }
        if (_score >= 5500 && _score < 6000)
        {
            _rank = "Disciple I";
        }
        if (_score >= 6000 && _score < 6500)
        {
            _rank = "Disciple II";
        }
        if (_score >= 6500 && _score < 7000)
        {
            _rank = "Disciple III";
        }
        if (_score >= 7000 && _score < 7500)
        {
            _rank = "Apostle I";
        }
        if (_score >= 7500 && _score < 8000)
        {
            _rank = "Apostle II";
        }
        if (_score >= 8000 && _score < 8500)
        {
            _rank = "Apostle III";
        }
        if (_score >= 8500)
        {
            _rank = "Prophet";
        }
        return _rank;
    }
    public void Error()
    {
        throw new Exception();
    }
}