namespace SnakeandLader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Snake and Ladder game");
            int[] positions = { 0, 0 };
            int diceRollCount = 0;
            int currentPlayer = 0;
            bool isWin = false;
            Random rand = new Random();

            while (!isWin)
            {
                Console.WriteLine("Player " + (currentPlayer + 1) + " turn:");
                Console.WriteLine("Current position: " + positions[currentPlayer]);
                Console.Write("Enter dice roll: ");

                int roll = rand.Next(1, 7);
                Console.WriteLine("You rolled a " + roll);


                positions[currentPlayer] += roll;

                if (positions[currentPlayer] == 14 || positions[currentPlayer] == 23 || positions[currentPlayer] == 45 || positions[currentPlayer] == 67 || positions[currentPlayer] == 75)
                {
                    Console.WriteLine("Player " + (currentPlayer + 1) + " got bitten by a snake! Go back to the previous position.");
                    positions[currentPlayer] -= roll;
                }
                else if (positions[currentPlayer] == 99)
                {
                    Console.WriteLine("Congratulations! Player " + (currentPlayer + 1) + " reached the finish line!");
                    isWin = true;
                }
                else if (positions[currentPlayer] > 100)
                {
                    Console.WriteLine("Oops! Player " + (currentPlayer + 1) + " overshot the finish line. Try again.");
                    positions[currentPlayer] -= roll;
                }
                else if (positions[currentPlayer] == 8 || positions[currentPlayer] == 21 || positions[currentPlayer] == 43 || positions[currentPlayer] == 50 || positions[currentPlayer] == 62 || positions[currentPlayer] == 66 || positions[currentPlayer] == 80)
                {
                    Console.WriteLine("Player " + (currentPlayer + 1) + " found a ladder! Climb up to the next position.");
                    positions[currentPlayer] += roll;
                }

                Console.WriteLine("Player " + (currentPlayer + 1) + " current position: " + positions[currentPlayer]);

                if (!isWin)
                {
                    // switch to the other player
                    currentPlayer = (currentPlayer == 0) ? 1 : 0;
                }

                // count the dice rolls
                diceRollCount++;

            }
            Console.WriteLine("Player " + (currentPlayer + 1) + " won the game!");
            Console.WriteLine("Total number of dice rolls: " + diceRollCount);

        }
    }
}