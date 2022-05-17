
namespace CMP1903MA2
{
    /// <summary>
    /// The program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        static void Main()
        {
            Game NewGame = new Game();
            NewGame.GameMain();

            Console.WriteLine("Play Again? (y/N)");
            ConsoleKeyInfo usrChoice = Console.ReadKey();
            if (usrChoice.Key == ConsoleKey.Y)
            { Main(); }
            else if (usrChoice.Key == ConsoleKey.N)
            {
                Console.WriteLine("Exiting Program Now...");
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid Key.");
                Console.WriteLine("Will Rerun as if Y was pressed...");
                Main();
            }
        }
    }

    /// <summary>
    /// The game.
    /// </summary>
    class Game
    {
        /// <summary>
        /// Games the main.
        /// </summary>
        public void GameMain()
        {
            
            Console.Write("Do you wish to play against a [local] player, press L for Local Player:\t");
            ConsoleKeyInfo usrChoice = Console.ReadKey();

            HumanPlayer P1 = new HumanPlayer();
            HumanPlayer P2 = new HumanPlayer();   
            
            {
                while ((P1.Score < Globals.winScore) || (P2.Score < Globals.winScore))
                {
                    Console.WriteLine("\nPlayer 1 rolls");
                    List<int> roll1 = P1.ROLLS(Globals.diceSize); ;
                    P1.Score = P1.ScoreCalc(roll1, P1.Score);
                    Console.Write($" Score is {P1.Score}");
                    Console.WriteLine("\n");

                    Console.WriteLine("Player 2 rolls");
                    List<int> roll2 = P2.ROLLS(Globals.diceSize); ;
                    P2.Score = P2.ScoreCalc(roll2, P2.Score);
                    Console.Write($" Score is {P2.Score}");
                }

                if (P1.Score >= Globals.winScore)
                { Console.WriteLine("\nPlayer 1 Wins."); }
                else if (P2.Score >= Globals.winScore)
                { Console.WriteLine("\nPlayer 2 Wins."); }
            }
        }


    }

    /// <summary>
    /// The globals.
    /// </summary>
    static class Globals
    {
        public static int diceSize = 6;
        public static int winScore = 50;
    }

    /// <summary>
    /// The player.
    /// </summary>
    class Player : Die
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
        /// <summary>
        /// Gets or Sets the roll.
        /// </summary>
        public int[] Roll
        {
            get { return roll; }
            set { roll = value; }
        }
        /// <summary>
        /// Scores the calc.
        /// </summary>
        /// <param name="rnd_ints">The rnd_ints.</param>
        /// <returns>An int.</returns>
        public int ScoreCalc(List<int> rnd_ints, int player_score)
        {
            Dictionary<int, int> SocreR = new Dictionary<int, int>();
            for (int k = 0; k <= Globals.diceSize; k++)
                foreach (int i in rnd_ints)
                {
                    if (rnd_ints[i] == k)
                    {
                        if (!SocreR.ContainsKey(k)) { SocreR[k] = 1; }
                        else { SocreR[k]++; }
                    }

                }
            if (SocreR.Values.Any(b => b == 5))
            {
                player_score += 12;
            }
            else if(SocreR.Values.Any(b => b == 4))
            {
                player_score += 6;
            }
            else if (SocreR.Values.Any(b => b == 3))
            {
                player_score += 3;
            }
            return player_score;

        }
    }
    /// <summary>
    /// The human player.
    /// </summary>
    class HumanPlayer : Player
    {
        
    }


    /// <summary>
    /// The die.
    /// </summary>
    /// 
    
    class Die
    {
        /// <summary>
        /// Rolls the w.
        /// </summary>
        /// <param name="sides">The sides.</param>
        public List<int> ROLLS(int sides)
        {
            List<int> roll = new List <int>();
            Random dieRoll = new Random();
            for (int i = 0; i <= 5; i++)
            {
                roll.Add(dieRoll.Next(1,sides));
            }
            foreach (int j in roll)
            {
                Console.Write($" {j}  ");
            }
            return roll;
        }
    }
}