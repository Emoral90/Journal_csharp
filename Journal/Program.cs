using System;

public class Program{
    static void Main(){
        string myChoice;

        Journal journal = new Journal();
        myChoice = journal.menu();

        if (myChoice == "1"){
            
        }
    }

    // static void validate_user_input(string input){
    //     string input_str;
    //     bool valid = string.TryParse(input, out input_str);

    //     while (!valid){
    //         Console.WriteLine("Invalid input. ");
    //     }
    // }
}