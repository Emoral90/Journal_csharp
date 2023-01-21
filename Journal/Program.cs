using System;
using System.Collections.Generic;

public class Program{
    static void Main(){
        // GLOBAL VARIABLES
        string myChoice = "";
        // Tuple<string, string> myEntry;
        string myEntry;

        // Constructor
        Journal journal = new Journal();

        // Main logic loop
        while (myChoice != "5"){
            Console.WriteLine();
            Console.WriteLine(" - - - - - - - Main Menu - - - - - - - -");
            Console.WriteLine("========================================");
            Console.WriteLine("1) Write a new entry");
            Console.WriteLine("2) Display Journal");
            Console.WriteLine("3) Load Journal from file");
            Console.WriteLine("4) Save Journal to file");
            Console.WriteLine("5) Quit");
            Console.WriteLine();
            
            myChoice = Console.ReadLine();

            if (myChoice == "1"){
            // Console.WriteLine(journal.prompt_entry());
            myEntry = journal.prompt_entry();
            }
            else if (myChoice == "2"){
                journal.display_entries(myEntry);
            }
            // else if (myChoice == "3"){
            //     journal.load_journal();
            // }
            // else if (myChoice == "4"){
            //     journal.save_journal();
            // }


        }

    }
}