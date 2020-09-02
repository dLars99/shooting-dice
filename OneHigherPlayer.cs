using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override int Roll(int otherRoll)
        {
            // Return a random number between 1 and DiceSize
            return otherRoll + 1;
        }

        public override void Play(Player other)
        {
            // Other player rolls first; this player rolls one higher
            int otherRoll = other.Roll(0);
            int myRoll = Roll(otherRoll);

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }

    }
}