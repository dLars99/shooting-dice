using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player that prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public void GetDieSize()
        {
            // Prompt the user for a number
            bool convertSuccess = false;
            int userDieSides = -1;
            while (!convertSuccess)
            {
                Console.WriteLine($"What size die have you, human {Name}?");
                string userDie = Console.ReadLine();

                convertSuccess = int.TryParse(userDie, out userDieSides);
                if (!convertSuccess)
                {
                    Console.WriteLine("Do not make things up. Try again.");
                }

            }
            DiceSize = userDieSides;
        }
    }
}