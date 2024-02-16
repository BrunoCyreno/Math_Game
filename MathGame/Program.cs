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

