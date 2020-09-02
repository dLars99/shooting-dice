using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        public override int Roll()
        {
            // Return a random number in the upper half of the DiceSize
            return new Random().Next(DiceSize / 2, DiceSize) + 1;
        }
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
                    if (tries > 3)
                    {
                        Console.WriteLine($"{Name} screams loud profanities at {other.Name} as he bolts out!");
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