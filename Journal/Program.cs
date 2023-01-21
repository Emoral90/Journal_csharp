using System;
using System.Collections.Generic;

public class Program{
    static void Main(){
        string myChoice;
        List<Tuple> journal_entries;

        Journal journal = new Journal();

        myChoice = journal.menu();

        if (myChoice == "1"){
            Console.WriteLine(journal.prompt_entry());
            Console.
        }
        else if (myChoice == "2"){
            journal.display_entries();
        }
        else if (myChoice == "3"){
            journal.load_journal();
        }
        else if (myChoice == "4"){
            journal.save_journal();
        }
    }
}