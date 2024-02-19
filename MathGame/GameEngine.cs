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
                answer = Helpers.validateResult(answer);
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
                answer = Helpers.validateResult(answer);
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
                answer = Helpers.validateResult(answer);
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
                answer = Helpers.validateResult(answer);
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
        internal void randomGame()
        {
            var lives = 3;
            var random = new Random();
            int points = 0;

            while (lives > 0)
            {
                var gameMode = random.Next(1, 5);
                int firstNumber = random.Next(1, 11);
                int secondNumber = random.Next(1, 11);

                if (gameMode == 1)
                {
                    Console.WriteLine("*****************************************************");
                    Console.WriteLine($"{firstNumber} + {secondNumber}?");
                    var answer1 = Console.ReadLine();
                    answer1 = Helpers.validateResult(answer1);
                    Console.WriteLine("*****************************************************");

                    if (int.Parse(answer1) == firstNumber + secondNumber)
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

                else if (gameMode == 2)
                {
                    Console.WriteLine("*****************************************************");
                    Console.WriteLine($"{firstNumber} - {secondNumber}?");
                    var answer2 = Console.ReadLine();
                    answer2 = Helpers.validateResult(answer2);
                    Console.WriteLine("*****************************************************");

                    if (int.Parse(answer2) == firstNumber - secondNumber)
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

                else if (gameMode == 3)
                {
                    Console.WriteLine("*****************************************************");
                    Console.WriteLine($"{firstNumber} * {secondNumber}?");
                    var answer3 = Console.ReadLine();
                    answer3 = Helpers.validateResult(answer3);
                    Console.WriteLine("*****************************************************");

                    if (int.Parse(answer3) == firstNumber * secondNumber)
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

                else if (gameMode == 4)
                {
                    var divisionNumbers = Helpers.getDivisionNumbers();

                    int firstNumberD = divisionNumbers[0];
                    int secondNumberD = divisionNumbers[1];

                    Console.WriteLine("*****************************************************");
                    Console.WriteLine($"{firstNumberD} / {secondNumberD}?");
                    var answer4 = Console.ReadLine();
                    answer4 = Helpers.validateResult(answer4);
                    Console.WriteLine("*****************************************************");

                    if (int.Parse(answer4) == firstNumber / secondNumber)
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
                        
                        
            }
                Console.WriteLine($"Game finished. Total points: {points}");
                Helpers.addToHistory(points, GameType.Random);
        }
    }
}