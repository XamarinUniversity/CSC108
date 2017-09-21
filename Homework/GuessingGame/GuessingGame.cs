using System;

namespace GuessingGame
{
    class GuessingGame
    {
        public const int LowerBoundary = 1;
        public const int UpperBoundary = 10;

        public int ActualNumber { get; private set; }
        public int Tries { get; private set; }

        public GuessingGame()
        {
            Tries = 3;
            generateRandomNumber();
        }

        public bool Guess(int number)
        {
            Tries--;

            if (number < LowerBoundary || number > UpperBoundary)
            {
                throw new ArgumentOutOfRangeException("number", "The number was outside the boundaries");
            }

            if (number == ActualNumber)
            {
                return true;
            }

            return false;
        }

        private void generateRandomNumber()
        {
            Random generator = new Random();
            ActualNumber = generator.Next(LowerBoundary, UpperBoundary + 1);
        }
    }
}
