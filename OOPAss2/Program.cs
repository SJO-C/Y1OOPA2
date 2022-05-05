
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
            Player p1 = new Player();
            Player p2 = new Player();
            while (p1.Score < winScore | p2.Score < winScore)
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