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
                         int ladder = rand.Next(1, 7);
                       
                            Console.WriteLine("You found a ladder! Climb up to position " + position);
                        position += ladder;
                        break;
                       
                    case 2:
                        int snake = rand.Next(1, 7);
                        Console.WriteLine("You got bitten by a snake! Go back by " + snake + " positions.");
                        position -= snake;
                        break;
                }

                if (position < 0)
                {
                    Console.WriteLine("Oops! You moved below position 0. Starting again from position 0.");
                    position = 0;
                }
                else if (position == 100)
                {
                    Console.WriteLine("Congratulations! You reached the finish line!");
                    break;
                }
            }

        }
    }
}