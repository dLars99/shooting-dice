using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> Taunt { get; } = new List<string>()
        {
            "My dice love me more than I love winnin'!",
            "Hope you have Uber for when I take those shoes!",
            "You should probably get a head start on counting out my cash!",
            "Bam!",
            "You're easier to beat than week-old eggs!"
        };
        public override int Roll()
        {
            // Smack talk before rolling
            int insult = new Random().Next(0, Taunt.Count);
            Console.WriteLine($"{Name} shouts, \"{Taunt[insult]}\"");

            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }

    }
}