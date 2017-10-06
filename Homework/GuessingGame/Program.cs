using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessingGame game = new GuessingGame();
            Console.WriteLine("I am thinking of a number between " + GuessingGame.LowerBoundary + " and " + GuessingGame.UpperBoundary);
            bool gameOver = false;
            do
            {
                Console.WriteLine("Enter a number");
                int guessedNumber = int.Parse(Console.ReadLine());
                try
                {
                    if (game.Guess(guessedNumber))
                    {
                        Console.WriteLine("You Win! The hidden number was " + guessedNumber);
                        gameOver = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Guess! You failed to guess the hidden number.");
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Invalid Guess! "+ ex.Message);
                }
                Console.WriteLine("Number of tries remaining: " + game.Tries + "\n");
                if (game.Tries <= 0)
                    break;

            } while (!gameOver);
            if (!gameOver)
            {
                Console.WriteLine("Out of tries! Game over!");
            }
        }
    }
}
