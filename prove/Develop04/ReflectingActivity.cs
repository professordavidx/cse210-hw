using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private string _prompt;
    private string _question;

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        // empty 
    }

    public string GetRandomPrompt()
    {
        List<string> promptlist = new List<string>();
        promptlist.Add("Think of a time when you stood for someone else.");
        promptlist.Add("Think of a time when you did something really difficult.");
        promptlist.Add("Think of a time when you helped someone in need");
        promptlist.Add("think of a time when you did something truly selfless");

        Random R = new Random();
        int index = R.Next(promptlist.Count);
        //set values to the prompt attribute
        _prompt = promptlist[index];

        return _prompt;
    }

    public string GetRandomQuestion()
    {
        List<string> questionlist = new List<string>();
        questionlist.Add("> Why was this experience meaning to you");
        questionlist.Add("> Have you ever done anything like this before");
        questionlist.Add("> How did you get started");
        questionlist.Add("> How did you feel when It was complete");
        questionlist.Add("> What made this time different than other times when you were not as successful");
        questionlist.Add("> What is your favorite thing about this experience");
        questionlist.Add("> What could you learn from this experience that applies to other situations");
        questionlist.Add("> What did you learn about yourself through this experience");
        questionlist.Add("> How can you keep this experience in mind in the future");

        Random R = new Random();
        int index = R.Next(questionlist.Count);
        _question = questionlist[index];

        return _question;
    }

    public void DisplayRandomPrompt()
    {
        string user = "";
        Console.WriteLine("Consider the following prompt: \n");
        Console.WriteLine($"---{GetRandomPrompt()}---\n");
        Console.WriteLine("When you have something in mind, press enter to continue");
        do
        {
            user = Console.ReadLine();
            if (user != "")
            {
                Console.WriteLine($"ops! you typed: '{user}', try again!");
            }
        }
        while (user != "");
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        BeginActivity();
        Console.Clear(); 
    }

    public void DisplayReflectingActivity()
    {
        DisplayStartingMessage();
        DisplayRandomPrompt();
        DateTime t = DurationInSeconds();

        while (DateTime.Now < t)
        {
            Console.Write($"{GetRandomQuestion}");
            ShowSpinner(7);
        }
        DisplayEndingMessage();

    }
}