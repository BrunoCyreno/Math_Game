Console.WriteLine("Player Name: ");

var name = Console.ReadLine();
var date = DateTime.UtcNow;

//Game main menu. Prompt to select game mode.
Console.WriteLine("*****************************************************");
Console.WriteLine($"Hello {name.ToUpper()}. Hope you're having a good {date.DayOfWeek}. This is a simple math game.\n");
Console.WriteLine(@$"Select your game mode:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit Game");
Console.WriteLine("*****************************************************");

//Save user input and start selected game mode
var gameSelected = Console.ReadLine().Trim().ToUpper();

switch (gameSelected)
{
    case "A":
        Console.WriteLine("Game Mode: Addition");
        break;

    case "S":
        Console.WriteLine("Game Mode: Subtraction");
        break;

    case "M":
        Console.WriteLine("Game Mode: Multiplication");
        break;

    case "D":
        Console.WriteLine("Game Mode: Division");
        break;

    case "Q":
        Console.WriteLine("Are you sure that you want to quit the game? [Y/N]");

        var quitOption = Console.ReadLine();

        if (quitOption.Trim().ToUpper() == "Y")
        {
            Environment.Exit(0);
        }
        break;

    default:
        Console.WriteLine("Invalid Input");
        Environment.Exit(0);
        break;
}