using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What's your fist name? ");
        string first_name = Console.ReadLine();
        Console.Write("What's your last name? ");
        string last_name = Console.ReadLine();

        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}