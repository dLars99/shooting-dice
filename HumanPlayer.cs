using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player that prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            // Prompt the user for a number
            bool convertSuccess = false;
            int num = -1;
            while (!convertSuccess)
            {
                Console.WriteLine($"What did you roll, human {Name}?");
                string userDie = Console.ReadLine();

                convertSuccess = int.TryParse(userDie, out num);
                if (!convertSuccess || num < 1 || num > 6)
                {
                    Console.WriteLine("That is not what your dice say. Try again.");
                    // Switch back to false when conversion is successful, but out of range
                    convertSuccess = false;
                }
            }

            return num;
        }

    }
}