bool isPlaying = true;

Console.WriteLine("Welcome to Boss Monster II!");
Console.Write("Enter your name: ");
string? name = Console.ReadLine();

// * create new player with name *

// * output player's name * 
Console.WriteLine($"Welcome, [PLAYER NAME]!");
Console.WriteLine("Clear the dungeon of monsters!");

while (isPlaying)
{
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
    
    // * create a new monster * 
    
    // * output monster's name *
    Console.WriteLine($"A [MONSTER NAME] appeared!");

    while (true)
    {
        // * output player stats *
        
        Console.Write("\n\nYou may Attack, Heal, or Quit:  ");
        string? input = Console.ReadLine();

        // * process player input *


        // * complete game loop * 

        // if monster health is 0
            // player has defeated the monster
            // decrease the number of monsters

            // if the number of monsters is 0
                // the player has won the game
               
            // if the number of monsters is not 0
                // restore players health and mana
        // if monster health is not 0
            // the monster attacks the player
            
            // if the player health is 0
                // the player has lost
        
        
        // * the following code is used to prevent inifitie loop *
        // * the code should be removed *
        isPlaying = false;
        break;
    }
    if (isPlaying == false)
    {
        Console.WriteLine("Would you like to play again? (Y)");
        string? playAgain = Console.ReadLine();
        if (!string.IsNullOrEmpty(playAgain) && playAgain.ToLower() == "y")
        {
            isPlaying = true;
            // * set the number of monsters to 10 *

            // * reset the player stats *
        }
        else
        {
            Console.WriteLine("Thanks for playing.");
            Console.ReadLine();
            isPlaying = false;
        }
    }

}