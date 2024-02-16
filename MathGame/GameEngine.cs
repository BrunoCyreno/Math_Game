using MathGame.Models;
namespace MathGame
{
    internal class GameEngine
    {
        internal void additionGame()
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
            Helpers.addToHistory(points, GameType.Addition);
        }
        internal void subtractionGame()
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
            Helpers.addToHistory(points, GameType.Subtraction);
        }
        internal void multiplicationGame()
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
            Helpers.addToHistory(points, GameType.Multiplication);
        }
        internal void divisionGame()
        {
            int lives = 3;
            int points = 0;

            while (lives > 0)
            {
                var divisionNumbers = Helpers.getDivisionNumbers();

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
            Helpers.addToHistory(points, GameType.Division);
        }

    }
}
