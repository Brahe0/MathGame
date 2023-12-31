﻿Console.WriteLine("Please type your name");

var name = Console.ReadLine();
var date = DateTime.Now;

Menu(name, date);

void Menu(string? name, DateTime date)
{
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine($"Hello {name}. It's {date}. This is your Math Game.");
    Console.WriteLine(@$"What game would you like to play today? Choose from the options below:
A- Addition
S- Subtraction
M- Multiplication 
D- Division
Q- Quit the game");
    Console.WriteLine("----------------------------------------------------");

    var gameSelected = Console.ReadLine();

    if (gameSelected != null)
        switch (gameSelected.Trim().ToLower())
        {
            case "a":
                {
                    AdditionGame("Addition game selected");
                    break;
                }
            case "s":
                {
                    SubtractionGame("Subtraction game selected");
                    break;
                }
            case "m":
                {
                    MultiplicationGame("Multiplication game selected");
                    break;
                }
            case "d":
                {
                    DivisionGame("Division game selected");
                    break;
                }
            case "q":
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
            default:
                {
                    Console.WriteLine("Invalid Input");
                    break;
                }
        }
    else
    {
        Console.WriteLine("Invalid Input");
    }
}

void AdditionGame(string message)
{
    Console.WriteLine(message);
}
void SubtractionGame(string message)
{
    Console.WriteLine(message);
}
void MultiplicationGame(string message)
{
    Console.WriteLine(message);
}
void DivisionGame(string message)
{
    Console.WriteLine(message);
}


