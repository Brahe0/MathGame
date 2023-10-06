Console.WriteLine("Please type your name");

var name = Console.ReadLine();
var date = DateTime.Now;

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
    if (gameSelected.Trim().ToLower() == "a")
    {
        Console.WriteLine("Addition game selected");
    }
    else if (gameSelected == "s")
    {
        Console.WriteLine("Subtraction game selected");
    }
    else if (gameSelected == "m")
    {
        Console.WriteLine("Multiplication game selected");
    }
    else if (gameSelected == "d")
    {
        Console.WriteLine("Division game selected");
    }
    else if (gameSelected == "q")
    {
        Console.WriteLine("Goodbye");
    }
    else
    {
        Console.WriteLine("Invalid Input");
    }


