using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public override void Play(Player other)
        {
            // Set up number of tries for temper tantrums
            int tries = 2;
            int totalTries = 3;

            while (true)
            {
                try
                {

                    // Call roll for "this" object and for the "other" object
                    int myRoll = Roll();
                    int otherRoll = other.Roll();

                    Console.WriteLine($"{Name} rolls a {myRoll}");
                    Console.WriteLine($"{other.Name} rolls a {otherRoll}");
                    if (myRoll > otherRoll)
                    {
                        Console.WriteLine($"{Name} Wins!");
                        break;
                    }
                    else if (myRoll < otherRoll)
                    {
                        Console.WriteLine($"{other.Name} Wins!");
                        throw new Exception();
                    }
                    else
                    {
                        // if the rolls are equal it's a tie
                        Console.WriteLine("It's a tie");
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    if (tries > 5)
                    {
                        Console.WriteLine($"{Name} flips the table and stomps out of the room!");
                        break;
                    }
                    Console.WriteLine($"{Name} shouts \"Best {tries} out of {totalTries}!\"");
                    ++tries;
                    totalTries += 2;
                }
            }
        }

    }
}