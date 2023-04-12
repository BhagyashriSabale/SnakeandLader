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

                position += roll;

                if (position == 14)
                {
                    Console.WriteLine("You got bitten by a snake! Go back to position 4.");
                    position = 4;
                }
                else if (position == 23)
                {
                    Console.WriteLine("You got bitten by a snake! Go back to position 7.");
                    position = 7;
                }
                else if (position == 45)
                {
                    Console.WriteLine("You got bitten by a snake! Go back to position 33.");
                    position = 33;
                }
                else if (position == 67)
                {
                    Console.WriteLine("You got bitten by a snake! Go back to position 54.");
                    position = 54;
                }
                else if (position == 75)
                {
                    Console.WriteLine("You got bitten by a snake! Go back to position 42.");
                    position = 42;
                }
                else if (position == 99)
                {
                    Console.WriteLine("Congratulations! You reached the finish line!");
                    break;
                }
                else if (position > 100)
                {
                    Console.WriteLine("Oops! You overshot the finish line. Try again.");
                    position -= roll;
                }
                else if (position == 8)
                {
                    Console.WriteLine("You found a ladder! Climb up to position 26.");
                    position = 26;
                }
                else if (position == 21)
                {
                    Console.WriteLine("You found a ladder! Climb up to position 42.");
                    position = 42;
                }
                else if (position == 43)
                {
                    Console.WriteLine("You found a ladder! Climb up to position 63.");
                    position = 63;
                }
                else if (position == 50)
                {
                    Console.WriteLine("You found a ladder! Climb up to position 69.");
                    position = 69;
                }
                else if (position == 62)
                {
                    Console.WriteLine("You found a ladder! Climb up to position 81.");
                    position = 81;
                }
                else if (position == 66)
                {
                    Console.WriteLine("You found a ladder! Climb up to position 87.");
                    position = 87;
                }
                else if (position == 80)
                {
                    Console.WriteLine("You found a ladder! Climb up to position 98.");
                    position = 98;
                }
            }
        }

    }
}