using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        string input = "0";

        void ShowMenu()
        {   
            Console.Clear();
            Console.WriteLine("Welcome to the Journal program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            input = Console.ReadLine();

        }

        Journal journal = new Journal();


        while(input != "5")
        {
            ShowMenu();

            switch (input) {
                case "1":
                    Console.Clear();
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string prompt = promptGenerator.SelectPrompt();
                    Console.WriteLine(prompt);
                    string answer = Console.ReadLine();
                    DateTime dateTime = DateTime.Now;
                    journal.AddEntry(dateTime,prompt,answer);
                    Console.WriteLine("Entry created successfully");
                    Console.WriteLine("Press any key to Continue");
                    Console.ReadKey();
                    break;
                
                case "2":
                    Console.Clear();
                    journal.DisplayAllEntries();
                    Console.WriteLine("Press any key to Continue");
                    Console.ReadKey();
                    break;
                
                case "3":
                    Console.Clear();
                    Console.WriteLine("What is the File name?");
                    string fileName = Console.ReadLine();
                    journal.SaveJournal(fileName);
                    Console.WriteLine("Saved");
                    Console.WriteLine("Press any key to Continue");
                    Console.ReadKey();
                    break;
                
                case "4":
                    Console.Clear();
                    Console.WriteLine("What is the File name?");
                    string loadFileName = Console.ReadLine();
                    journal.LoadJournal(loadFileName);
                    Console.WriteLine("Journal Loaded");
                    Console.WriteLine("Press any key to Continue");
                    Console.ReadKey();
                    break;
                
                default:
                break;
            }
        }
        
       
        
    


    }

    
}

