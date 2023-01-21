using System;
using System.Collections.Generic;

public class Journal{
    // Attributes
    string user_input;
    string journal_entry;
    string date;
    string[] prompts = {
        "How did I save money today?", 
        "Where did I find happiness?", 
        "Did I talk with a cute girl?", 
        "How did I wake up today?", 
        "What was the best part of my day?"
        };
    

    // Constructor
    public Journal(){}

    // Methods
    public Tuple<string, string> prompt_entry(){
        // Instantiate the Random class
        Random rand = new Random();
        int random_number = rand.Next(4);

        // Provide randomly chosen prompt and save entry
        Console.WriteLine("Prompt:");
        Console.WriteLine(prompts[random_number]);
        journal_entry = Console.ReadLine();

        // Prompt user for date and save to variable
        Console.WriteLine("Enter date: MM/DD/YYYY");
        date = Console.ReadLine();

        return new Tuple<string, string>(journal_entry, date);
    }

    public void display_entries(){}

    public string load_journal(){}

    public void save_journal(){}

    public string menu(){
        while (user_input != "5"){
            Console.WriteLine();
            Console.WriteLine(" - - - - - - - Main Menu - - - - - - - -");
            Console.WriteLine("========================================");
            Console.WriteLine("1) Write a new entry");
            Console.WriteLine("2) Display Journal");
            Console.WriteLine("3) Load Journal from file");
            Console.WriteLine("4) Save Journal to file");
            Console.WriteLine("5) Quit");
            Console.WriteLine();
            
            user_input = Console.ReadLine();
            // break;
        }
        return user_input;
    }
}