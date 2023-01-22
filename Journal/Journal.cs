using System;
using System.Collections.Generic;
using System.IO;

public class Journal{
    // Attributes
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
    public void display_prompt(){
        // Instantiate the Random class
        Random rand = new Random();
        int random_number = rand.Next(4);

        // Provide randomly chosen prompt and save entry
        Console.WriteLine("Today's prompt is");
        Console.WriteLine(prompts[random_number]);

    }

    public void display_entries(string prompt_answer, string date){
        Console.WriteLine($"Your entry: {prompt_answer}");
        Console.WriteLine($"Date enterd: {date}");
    }

    public void load_journal(File file){
        file = "Entries.txt";
        string[] lines = System.IO.ReadAllLines(file);

        foreach (string line in lines){
            string[] parts = line.Split(",");
            string answer = parts[0];
            string date = parts[1];
            Console.WriteLine(line);
        }
        
    }

    public void save_journal(string journal_entry, string date){
        using(StreamWriter out_file = new StreamWriter(journal_entry)){
            out_file.WriteLine(journal_entry);
            out_file.WriteLine(date);
        }
        Console.WriteLine(out_file);
    }
}