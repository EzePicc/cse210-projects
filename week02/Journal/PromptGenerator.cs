public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "If today was a movie, what would its title be?",
        "What song best describes my day?",
        "If I could relive one moment today, which would it be?",
        "What fictional character would understand my day?",
        "What color describes my mood today?"
    };
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();

        int index = randomGenerator.Next(_prompts.Count);

        return _prompts[index];
    }

}