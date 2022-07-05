namespace cse210_04.Game.Casting
{

        /// <summary>
        /// <para>An item of cultural or historical interest.</para>
        /// <para>
        /// The responsibility of an Artifact is to provide a message about itself.
        /// </para>
        /// </summary>
    public class Artifact : Actor
    {

        private int score = 0;

        /// <summary>
        /// Constructs a new instance of Artifact.
        /// </summary>
        public Artifact()
        {

        }

        public int GetScore()
        {
            return score;
        }

        public void SetScore(int score)
        {
            this.score = score;
        }
    }
}