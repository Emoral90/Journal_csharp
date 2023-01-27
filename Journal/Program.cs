using System;
using System.Collections.Generic;

public class Program{
    static void Main(){
        // GLOBAL VARIABLES
        string myChoice = "";
        // Tuple<string, string> myEntry;
        string myEntry = "";
        string specDate = "";

        // Constructors
        Journal journal = new Journal();
        Interactor interactor = new Interactor();

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
                journal.display_prompt();
                myEntry = interactor.get_prompt_answer();
                specDate = interactor.get_date();
            }

            else if (myChoice == "2"){
                interactor.display_entry();
            }
            
            // else if (myChoice == "3"){
            //     journal.load_journal("Entries.txt");
            // }

            // else if (myChoice == "4"){
            //     journal.save_journal(myEntry, specDate);
            // }

        }

    }
}