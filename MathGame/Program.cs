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

    //This repeats the game.
    bool isGameOn = true;

    do
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
                    isGameOn = false;
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                }
                break;

            default:
                Console.WriteLine("Invalid Input");
                Environment.Exit(0);
                break;
        }

    } while (isGameOn);

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

        Console.WriteLine("*****************************************************");
        Console.WriteLine($"{firstNumber} + {secondNumber}?");
        var answer = Console.ReadLine();
        Console.WriteLine("*****************************************************");

        if (int.Parse(answer) == firstNumber + secondNumber)
        {
            Console.WriteLine("Correct!");
            points++;
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Wrong!");
            lives--;
            Console.WriteLine($"Lives left: {lives}/3");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
        Console.Clear();
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

        Console.WriteLine("*****************************************************");
        Console.WriteLine($"{firstNumber} - {secondNumber}?");
        var answer = Console.ReadLine();
        Console.WriteLine("*****************************************************");

        if (int.Parse(answer) == firstNumber - secondNumber)
        {
            Console.WriteLine("correct!");
            points++;
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Wrong!");
            lives--;
            Console.WriteLine($"Lives left: {lives}/3");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
        Console.Clear();
    }
    Console.WriteLine($"Game finished. Total points: {points}");
}
void multiplicationGame()
{
    int lives = 3;
    int points = 0;
    var random = new Random();
    while (lives > 0)
    {
        int firstNumber = random.Next(1, 11);
        int secondNumber = random.Next(1, 11);

        Console.WriteLine("*****************************************************");
        Console.WriteLine($"{firstNumber} * {secondNumber}?");
        var answer = Console.ReadLine();
        Console.WriteLine("*****************************************************");

        if (int.Parse(answer) == firstNumber * secondNumber)
        {
            Console.WriteLine("Correct!");
            points++;
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Wrong!");
            lives--;
            Console.WriteLine($"Lives left: {lives}/3");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
        Console.Clear();

    }
    Console.WriteLine($"Game finished. Total points: {points}");
}
void divisionGame()
{
    int lives = 3;
    int points = 0;

    while (lives > 0)
    {
        var divisionNumbers = getDivisionNumbers();

        int firstNumber = divisionNumbers[0];
        int secondNumber = divisionNumbers[1];

        Console.WriteLine("*****************************************************");
        Console.WriteLine($"{firstNumber} / {secondNumber}?");
        var answer = Console.ReadLine();
        Console.WriteLine("*****************************************************");

        if (int.Parse(answer) == firstNumber / secondNumber)
        {
            Console.WriteLine("Correct!");
            points++;
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Wrong!");
            lives--;
            Console.WriteLine($"Lives left: {lives}/3");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
        Console.Clear();
    }
    Console.WriteLine($"Game finished. Total points: {points}");
}
int[] getDivisionNumbers()
{
    var random = new Random();
    int firstNumber = random.Next(1, 99);
    int secondNumber = random.Next(1, 99);

    var result = new int[2];

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;

}