using BossMonsterII;

internal class Program
{
    private static void Main(string[] args)
    {
        bool isPlaying = true;

        Console.WriteLine("Welcome to Boss Monster II!");
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();

        // * create new player with name *
        while (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Not a valid response. Try again.");
            name = Console.ReadLine();
        }

        var player = new Player(name);

        // * output player's name * 
        Console.WriteLine($"Welcome, {player.Name}!");
        Console.WriteLine("Clear the dungeon of monsters!");

        while (isPlaying)
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // * create a new monster * 
            var monster = new Monster();

            // * output monster's name *
            Console.WriteLine($"A {monster.Name} appeared!");

            while (true)
            {
                // * output player stats *
                player.PrintStats();

                Console.Write("\n\nYou may Attack, Heal, or Quit:  ");
                string? input = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(input)) 
                {
                   Console.Write("\n\nYou may Attack, Heal, or Quit:  ");
                   input = Console.ReadLine();
                }

                // * process player input *
                switch (input.ToLower())
                {
                    case "attack":
                        player.Attack(monster);
                        break;
                    case "heal":
                        player.Heal();
                        break;
                    case "quit":
                        Console.WriteLine("Thanks for playing.");
                        isPlaying = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }

                if (isPlaying == false)
                {
                    break;
                }

                // * complete game loop * 

                // if monster health is 0
                if (monster.Health <= 0)
                {
                    // player has defeated the monster
                    Console.WriteLine($"You have defeated the {monster.Name}!");

                    // decrease the number of monsters
                    Monster.Count--;

                    // if the number of monsters is 0
                    if (Monster.Count == 0)
                    {
                        // the player has won the game
                        Console.WriteLine("You have cleared the dungeon!");
                        isPlaying = false;
                    }
                    // if the number of monsters is not 0
                    else
                    {
                        // restore players health and mana
                        Console.WriteLine($"There are {Monster.Count} monsters left!");
                        player.RestoreHealth();
                        player.RestoreMana();
                    }  

                    break;
                }
                // if monster health is not 0
                else 
                {
                    // the monster attacks the player
                    monster.Attack(player);
                    // if the player health is 0
                    if (player.Health <= 0)
                    {
                        // the player has lost
                        Console.WriteLine("You have been defeated.");
                        isPlaying = false;
                        break;
                    }
                }
            }

            if (isPlaying == false)
            {
                Console.WriteLine("Would you like to play again? (Y)");
                string? playAgain = Console.ReadLine();
                if (!string.IsNullOrEmpty(playAgain) && playAgain.ToLower() == "y")
                {
                    isPlaying = true;
                    // * set the number of monsters to 10 *
                    Monster.Count = 10;

                    // * reset the player stats *
                    player.Reset();
                }
                else
                {
                    Console.WriteLine("Thanks for playing.");
                    Console.ReadLine();
                    isPlaying = false;
                }
            }
        }
    }
}