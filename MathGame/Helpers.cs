namespace MathGame
{
    internal class Helpers
    {
        static List<string> games;
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
        internal static void addToHistory(int gamePoints, string gameType)
        {
            games.Add($"{date} - {gameType} score: {gamePoints} points ");
        }
        internal static void getGameHistory()
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
    }
}
