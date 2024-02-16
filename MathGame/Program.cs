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