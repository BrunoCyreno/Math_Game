using MathGame;

var menu = new Menu();

var date = DateTime.UtcNow;

List<string> games = new();

string name = getName();

menu.ShowMenu(name, date);

string getName()
{
    Console.WriteLine("Player Name: ");
    var name = Console.ReadLine();
    return name;
}

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
    addToHistory(points, "Addition");
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
            points ++;
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
    addToHistory(points, "Subtraction");
}
void multiplicationGame() 
{
    int lives = 3;
    int points = 0;
    var random = new Random();
    while(lives > 0) 
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
            points ++;
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
    addToHistory(points, "Multiplication");  
}
void divisionGame() 
{
    int lives = 3;
    int points = 0;

    while(lives > 0) 
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
    addToHistory(points, "Division"); 
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
void addToHistory(int gamePoints, string gameType)
{
    games.Add($"{date} - {gameType} score: {gamePoints} points ");
}
void getGameHistory()
{
    Console.Clear();

    Console.WriteLine("Previus Scores:");
    Console.WriteLine("*****************************************************");
    foreach (string game in games)
    {
        Console.WriteLine(game);
    }
    Console.WriteLine("*****************************************************");

    Console.WriteLine("Press any key to return");
    Console.ReadLine();

}