using MathGame;

var menu = new Menu();

var date = DateTime.UtcNow;

List<string> games = new();

string name = Helpers.getName();

menu.ShowMenu(name, date);