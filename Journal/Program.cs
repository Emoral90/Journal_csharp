using System;
using System.Collections.Generic;

public class Program{
    static void Main(){
        // string myChoice;

        Journal journal = new Journal();
        // myChoice = journal.menu();
        journal.prompt_entry();

        // if (myChoice == "1"){
        //     my_list = journal.prompt_entry();
            
        //     foreach (string prompt in my_list){
        //         Console.WriteLine(prompt);
        //     }
        // }
    }
}