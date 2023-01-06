using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your grade percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);
        string letter = "";
        int remainder = 0;
        string sign = "";

        if (percentage >= 90)
        {
            letter = ("A");
        }
        else if (percentage >= 80)
        {
            letter = ("B");
        }
        else if (percentage >= 70)
        {
            letter = ("C");
        }
        else if (percentage >= 60)
        {
            letter = ("D");
        }
        else
        {
            letter = ("F");
        }

        
        remainder = percentage % 10;

        
        
        if (remainder >= 7)
        {
            sign = "+";
        }
        else
        {
            sign = "-";
        }
        

        if (letter == "A" || letter == "F" )
        {
            Console.WriteLine($"Your grade is {letter}");
        }
        else
        {
            Console.WriteLine($"Your grade is {letter}{sign}");
        }
        if (percentage >= 60)
        {
            Console.Write("You passed!!");
        }
        else
        {
            Console.Write("Sorry, try again the next time.");
        }

    }
}