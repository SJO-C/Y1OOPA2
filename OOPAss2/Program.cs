
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
            NewGame.GameMain();

            Console.WriteLine("to play again enter 1, enter 2 to quit");
            ConsoleKeyInfo usrChoice = Console.ReadKey();
            if (usrChoice.Key == ConsoleKey.D1)
            {
                NewGame.GameMain();
            }
            else
            {
                Console.WriteLine("BYE");
                System.Environment.Exit(0);
            }
        }
    }

    /// <summary>
    /// The game.
    /// </summary>
    class Game
    {
        public void GameMain()
        {
            int winScore = 50;
            Console.Write("Do you wish to play against a [local] player or the Computer?\nC for Computer, L for Local Player:\t");
            ConsoleKeyInfo usrChoice = Console.ReadKey();

            HumanPlayer P1 = new HumanPlayer();
            HumanPlayer P2 = new HumanPlayer();
            ComputerPlayer C1 = new ComputerPlayer();
            ComputerPlayer c2 = new ComputerPlayer();

            List<int> roll1 =  P1.ROLLS(6);
            P1.ScoreCalc(roll1);
            if (usrChoice.Key == ConsoleKey.C)
            {
                ;
            }
            else if (usrChoice.Key == ConsoleKey.L)
            {
                ;
            }

            while ((P1.Score < winScore) || (P2.Score < winScore))
            {

            }
        }


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
        public int[] Roll
        {
            get { return roll; }
            set { roll = value; }
        }
        public int ScoreCalc(List<int> rnd_ints)
        {
            int score = 0;

            var ranks =
                rnd_ints.GroupBy(s => s)
                .Where(g => g.count() > 1)
                .select(k);
                

            public List<int> countScores(ranks)
            {

            }
            return score;

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
            return roll;
        }
    }
}