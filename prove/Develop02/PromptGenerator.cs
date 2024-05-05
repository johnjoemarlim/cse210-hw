public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
        return (_prompts[index]);
        
    }
}