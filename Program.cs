namespace SnakeandLader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Snake and Ladder game");
            int position = 0;
            Random rand = new Random();

            while (position < 100)
            {
                Console.WriteLine("Current position: " + position);
                Console.Write("Enter dice roll: ");

                int roll = rand.Next(1, 7);
                Console.WriteLine("You rolled a " + roll);

                int option = rand.Next(0, 3);
                switch (option)
                {
                    case 0:
                        Console.WriteLine("No play! You stay at position " + position);
                        break;
                    case 1:
                        int ladderPosition = position + roll;
                        if (ladderPosition <= 100)
                        {
                            Console.WriteLine("You found a ladder! Climb up to position " + ladderPosition);
                            position = ladderPosition;
                        }
                        else
                        {
                            Console.WriteLine("Oops! You overshot the finish line. Try again.");
                        }
                        break;
                    case 2:
                        int snakePosition = position - roll;
                        if (snakePosition >= 0)
                        {
                            Console.WriteLine("You got bitten by a snake! Go back to position " + snakePosition);
                            position = snakePosition;
                        }
                        else
                        {
                            Console.WriteLine("Oops! You can't go behind the starting position. Try again.");
                        }
                        break;
                }

                if (position == 100)
                {
                    Console.WriteLine("Congratulations! You reached the finish line!");
                    break;
                }
            }

        }
    }
}