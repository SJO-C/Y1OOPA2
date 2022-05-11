﻿
namespace CMP1903MA2
{
    /// <summary>
    /// The program.
    /// </summary>
    class Program
    {
        static void Main()
        {
            Game NewGame = new Game();

        }
    }

    /// <summary>
    /// The game.
    /// </summary>
    class Game
    {
        static void GameMain()
        {
            int winScore = 50;
            Console.Write("Do you wish to play against a [local] player or the Computer?\nC for Computer, L for Local Player:\t");
            ConsoleKeyInfo usrChoice = Console.ReadKey();
            if (usrChoice.Key == ConsoleKey.C)
            {
                HumanPlayer P1 = new HumanPlayer();
                ComputerPlayer P2 = new ComputerPlayer();
            }
            else if (usrChoice.Key == ConsoleKey.L)
            {
                HumanPlayer P1 = new HumanPlayer();
                HumanPlayer P2 = new HumanPlayer();
            }
            while (P1.Score < winScore | P2.Score < winScore)
            {

            }
        }


    }

    /// <summary>
    /// The player.
    /// </summary>
    class Player
    {
        private int score;

        /// <summary>
        /// Gets or Sets the score.
        /// </summary>
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        private int[] roll;
        public int[] Roll
        {
            get { return roll; }
            set { roll = value; }
        }
    }
    class HumanPlayer : Player
    {
        
    }

    class ComputerPlayer : Player
    {

    }

    /// <summary>
    /// The die.
    /// </summary>
    class Die
    {

        /// <summary>
        /// Rolls the w.
        /// </summary>
        /// <param name="sides">The sides.</param>
        /// <returns><![CDATA[Dictionary<int,int>]]></returns>
        public Dictionary<int, int> rolls(int sides)
        {
            Dictionary<int, int> roll = new Dictionary<int, int>();
            Random dieRoll = new Random();
            for (int i = 0; i <= 5; i++)
            {
                roll[i] = dieRoll.Next(1, sides);
            }
            return roll;
        }
    }
}