public class Interactor{
    string prompt_answer;
    string date;
    public string get_prompt_answer(){
        Console.WriteLine("Enter prompt response below:");
        prompt_answer = Console.ReadLine();
        return prompt_answer;
    }

    public string get_date(){
        Console.WriteLine("Enter the date as: MM/DD/YYYY");
s        date = Console.ReadLine();
        return date;
    }
}