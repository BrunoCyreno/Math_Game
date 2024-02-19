using MathGame.Models;

namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>();
        internal static int[] getDivisionNumbers()
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
        internal static void addToHistory(int gamePoints, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gamePoints,
                Type = gameType
            });
        }
        internal static void getGameHistory()
        {
            Console.Clear();

            Console.WriteLine("Previus Scores:");
            Console.WriteLine("*****************************************************");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} points");
            }
            Console.WriteLine("*****************************************************");

            Console.WriteLine("Press any key to return");
            Console.ReadLine();

        }
        internal static string validateResult(string answer) 
        {
            while (string.IsNullOrEmpty(answer) || !Int32.TryParse(answer, out _))
            {
                Console.WriteLine("ERROR: Your answer needs to be an integer. Try again.");
                answer = Console.ReadLine();
            }
            return answer;
        }
        internal static string getName()
        {
            Console.WriteLine("Player Name: ");
            var name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("ERROR: Name can't be empty!");
                name = Console.ReadLine();
            }
            return name;
        }
    }
}
