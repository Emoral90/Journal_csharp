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
    public string prompt_entry(){
        // Instantiate the Random class
        Random rand = new Random();
        int random_number = rand.Next(4);

        // Provide randomly chosen prompt and save entry
        Console.WriteLine("Provide in the following format:");
        Console.WriteLine("prompt answer,MM.DD.YYYY");
        Console.WriteLine(prompts[random_number]);
        journal_entry = Console.ReadLine();

        // // Prompt user for date and save to variable
        // Console.WriteLine("Enter date: MM/DD/YYYY");
        // date = Console.ReadLine();

        // return new Tuple<string, string>(journal_entry, date);
        return journal_entry;
    }

    public void display_entries(Tuple<string, string> theStuff){
        Console.WriteLine(theStuff);
    }

    public void load_journal(string file){
        file = "Entries.txt";
        string[] lines = System.IO.ReadAllLines(file);

        foreach (string line in lines){
            string[] parts = line.Split(",");
            string answer = parts[0];
            string date = parts[1];
        }

        
    }

    // public void save_journal(){}
}