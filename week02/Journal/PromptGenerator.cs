class PromptGenerator
{
    public List<String> _prompts;
    public static PromptGenerator _me;

    private PromptGenerator()
    {
        _prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    public static String GetPrompt()
    {
        if (_me == null)
        {
            _me = new PromptGenerator();
        }

        return _me._prompts[new Random().Next(_me._prompts.Count)];

    }
}