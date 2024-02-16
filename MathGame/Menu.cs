using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Menu
    {
        internal void ShowMenu(string name, DateTime date)
        {

            //This repeats the game.
            bool isGameOn = true;

            do
            {
                Console.Clear();
                //Game main menu. Prompt to select game mode.
                Console.WriteLine("*****************************************************");
                Console.WriteLine($"Hello {name.ToUpper()}. Hope you're having a good {date.DayOfWeek}. This is a simple math game.\n");

                Console.WriteLine(@$"Select your game mode:
         A - Addition
         S - Subtraction
         M - Multiplication
         D - Division
         Q - Quit Game
         V - View Games History");
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
                        Console.WriteLine("*****************************************************");
                        Console.WriteLine("Are you sure that you want to quit the game? [Y/N]");
                        var quitOption = Console.ReadLine();
                        Console.WriteLine("*****************************************************");
                        if (quitOption.Trim().ToUpper() == "Y")
                        {
                            isGameOn = false;
                            Console.WriteLine("Goodbye!");
                            Environment.Exit(0);
                        }
                        break;

                    case "V":
                        getGameHistory();
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        Environment.Exit(0);
                        break;
                }

            } while (isGameOn);

        }
    }
}
