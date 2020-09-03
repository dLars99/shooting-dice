using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            player2.Play(player1);

            Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Wilma";

            player3.Play(player2);

            Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            player1.Play(large);

            Console.WriteLine("-------------------");

            SmackTalkingPlayer smacktalk = new SmackTalkingPlayer();
            smacktalk.Name = "One Note Nick";

            OneHigherPlayer cheater = new OneHigherPlayer();
            cheater.Name = "I Bring My Own Dice";

            HumanPlayer human = new HumanPlayer();
            human.Name = "John Doe";
            human.GetDieSize();

            CreativeSmackTalkingPlayer bigTalk = new CreativeSmackTalkingPlayer();
            bigTalk.Name = "Mickey Mouth";

            SoreLoserPlayer poorSport = new SoreLoserPlayer();
            poorSport.Name = "Peyton";

            UpperHalfPlayer lucky = new UpperHalfPlayer();
            lucky.Name = "Lucky";

            SoreLoserUpperHalfPlayer lousySport = new SoreLoserUpperHalfPlayer();
            lousySport.Name = "Cartman";

            Console.WriteLine("-------------------");

            List<Player> players = new List<Player>()
            {
                player1,
                player2,
                player3,
                large,
                smacktalk,
                cheater,
                human,
                bigTalk,
                poorSport,
                lucky,
                lousySport
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play one another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];

                // Set up number of tries for temper tantrums
                int tries = 2;
                int totalTries = 3;

                while (true)
                {
                    try
                    {
                        player1.Play(player2);
                        break;
                    }
                    catch (Exception ex)
                    {
                        if (tries > 4)
                        {
                            Console.WriteLine($"{player1.Name} flips the table and stomps out of the room!");
                            break;
                        }
                        Console.WriteLine($"{player1.Name} shouts \"Best {tries} out of {totalTries}!\"");
                        ++tries;
                        totalTries += 2;
                    }

                }
            }
        }
    }
}