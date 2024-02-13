var date = DateTime.UtcNow;

string name = getName();

Menu(name);

string getName()
{
    Console.WriteLine("Player Name: ");
    var name = Console.ReadLine();
    return name;
}
void Menu(string name)
{
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
            additionGame();
            break;

        case "S":
            Console.WriteLine("Game Mode: Subtraction");
            subtractionGame();
            break;

        case "M":
            Console.WriteLine("Game Mode: Multiplication");
            multiplicationGame();
            break;

        case "D":
            Console.WriteLine("Game Mode: Division");
            divisionGame();
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
}
//Create methods for each game modes.
void additionGame()
{
    int lives = 3;
    int points = 0;
    var random = new Random();
    while (lives > 0)
    {
        int firstNumber = random.Next(1, 11);
        int secondNumber = random.Next(1, 11);

        Console.WriteLine($"{firstNumber} + {secondNumber}?");

        var answer = Console.ReadLine();

        if (int.Parse(answer) == firstNumber + secondNumber)
        {
            Console.WriteLine("Correct!");
            points++;
        }
        else
        {
            Console.WriteLine("Wrong!");
            lives--;
        }
    }
    Console.WriteLine($"Game finished. Total points: {points}");
}
void subtractionGame()
{
    int lives = 3;
    int points = 0;
    var random = new Random();
    while (lives > 0)
    {
        int firstNumber = random.Next(1, 11);
        int secondNumber = random.Next(1, 11);

        Console.WriteLine($"{firstNumber} - {secondNumber}?");
        var answer = Console.ReadLine();

        if (int.Parse(answer) == firstNumber - secondNumber)
        {
            Console.WriteLine("correct!");
            points++;
        }
        else
        {
            Console.WriteLine("Wrong!");
            lives--;
        }
    }
    Console.WriteLine($"Game finished. Total points: {points}");
}
void multiplicationGame() { }
void divisionGame() { }
