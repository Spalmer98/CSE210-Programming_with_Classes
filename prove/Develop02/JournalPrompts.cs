using System;

public class JournalPrompts
{
    static List<string> _prompts = new List<string>{"Did I learn anything new today?", 
                                                    "What was the hardest thing I did today?", 
                                                    "Did I do any acts of service today, and if so what was it?", 
                                                    "What's a goal I can make to be better tomorrow?", 
                                                    "What was different about today?"};
    public static string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(0, 4);
        return _prompts[randomNumber];
    }
}