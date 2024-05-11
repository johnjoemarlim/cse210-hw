using System.Runtime.Intrinsics.Arm;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");
        // Console.WriteLine(sentence[0]);
        // Console.WriteLine(sentence[6]);
        
        foreach (string word in words)
        {
            Word w = new Word(word);
            // Console.WriteLine(a);
            // string dis = w.GetDisplayText();
            // Console.WriteLine(dis);
            _words.Add(w);
            // Console.Write($"{w1.GetDisplayText()} ");
            // _words.Add(w.GetDisplayText());
            // Console.WriteLine(w.GetDisplayText());
        }

        // foreach (Word word in _words)
        // {
        //     Console.WriteLine($"{word.GetDisplayText()} ");
        // }
        // {
        //     w.GetDisplayText();
        // }
        
        
    }
    public void HideRandomWords(int numberToHide)
    {
        //words index not yet hidden
        List<int> randWordsIndex = new List<int>();
        //words index to hide
        List<int> randWordsToIndexHide = new List<int>();
        
        int num = 0;
        foreach (Word word in _words)
        {
            if (word.GetDisplayText() != "_____")
            {
                randWordsIndex.Add(num);
            }             
            //if (word.GetDisplayText() != "_____")
            //{
               // randWordsIndex.Add(num);
           // }
            int val = num + 1;
            num = val;     
                 
            // Console.WriteLine($"{word.GetDisplayText()} ");
        }
        // foreach (int ind in randWordsIndex)
        // {
        //     Console.WriteLine($"randWordsIndex: {ind}");
        // }
        // Console.WriteLine($"total: {randWordsIndex.Count}");
        for (int d=1; d<=numberToHide; d++)
        {
            Random random = new Random();
            int index = random.Next(randWordsIndex.Count);


            if (randWordsIndex.Count != 0)
            {
                randWordsToIndexHide.Add(randWordsIndex[index]);
            // Console.WriteLine(randWordsToIndexHide);
            // Console.WriteLine(randWordsIndex[index]);
                randWordsIndex.Remove(randWordsIndex[index]);
            }          
            
        }
        // foreach (int ind in randWordsToIndexHide)
        // {   
        //     Console.WriteLine($"randWordsToIndexHide1: {ind}");
        // }
       
        // for (int i = 0; i < randWordsToIndexHide.Count; i++)
        randWordsToIndexHide.Sort();
        foreach (int number in randWordsToIndexHide)
        {
            _words[number].Hide();
            // Console.WriteLine(number);
        }

        // for (int i = 0; i < _words.Count; i++)
        // {
        //     if (i == randWordsToIndexHide[i])
        //     {
        //         _words[i].Hide();
        //     }
        // }



        
        // for (d=1; d<=numberToHide; d++)
        // {

        //     if (_words[index] == _words[numberToHide])
        //     {
        //         _words[index].Hide();
        //     }
        // }
        // numberToHide = index;
        
        
        // Console.WriteLine(_words[index]);
        
    }
    public string GetDisplayText()
    {
        string full_text = "";
        foreach (Word word in _words)
        {
        full_text += word.GetDisplayText() + " ";
        }
        
        return full_text;
    }
    public bool IsCompletelyHidden()
    {
        string word_full = GetDisplayText();
       
        word_full = word_full.Replace(" ","");
        if(word_full.Distinct().Count() == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
    // public void LoadFromFile(string file)
    // {
    //     string fileName = file;
    //     string[] lines = System.IO.File.ReadAllLines(fileName);

    //     // int b = 0;

    //     foreach (string line in lines)
    //     {
    //         string[] parts = line.Split("~~");

    //         if (int.TryParse(parts[3], out int value))
    //         {
    //             Reference r1 = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
    //         // b = int.Parse(parts[0]);
    //         // anEntry._book = parts[0];
    //         // anEntry._entryText = parts[1];
    //         // anEntry._promptText = parts[2];
    //         }
            
    //         else
    //         {
    //            Reference r1 = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
    //            Scripture s1 = new Scripture(r1, parts[3]);
    //         }
    //     }
    
    // }
}