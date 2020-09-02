using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override void Play(Player other)
        {
            // Other player rolls first; this player rolls one higher
            int otherRoll = other.Roll();
            int myRoll = otherRoll + 1;

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            Console.WriteLine($"{Name} Wins Again!");
        }

    }
}