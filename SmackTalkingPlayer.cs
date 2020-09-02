using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; } = "One Note Nick shouts, \"You're gonna lose!\"";
        public override int Roll()
        {
            // Smack talk before rolling
            Console.WriteLine(Taunt);

            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }
    }
}