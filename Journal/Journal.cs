using System;
using System.Collections.Generic;

public class Journal{
    // Attributes
    string user_input;

    // Constructor
    public Journal(){}

    // Methods
    public string prompt_entry(){}

    // public void display_entries(){}

    // public string load_journal(){}

    // public void save_journal(){}

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
        }
        return user_input;
    }
}