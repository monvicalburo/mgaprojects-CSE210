using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string UserName = PromptUserName();
        int UserNumber = PromptUserNumber();

        int NumberSquared = SquareNumber(UserNumber);

        DisplayResult(UserName, NumberSquared);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string response = Console.ReadLine();
        int number = int.Parse(response);
        return number;
    }
    static int SquareNumber(int UserNumber)
    {
        int squared = UserNumber * UserNumber;
        return squared;
    }
    static void DisplayResult(string UserName, int NumberSquared)
    {
        Console.WriteLine($"{UserName}, the square of your number is {NumberSquared}");
    }
}