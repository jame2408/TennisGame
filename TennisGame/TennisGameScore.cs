namespace TennisGame
{
    public class TennisGameScore
    {
        private int _firstPlayerScore;

        public string Score()
        {
            return _firstPlayerScore == 2 ? "Thirty Love" : (_firstPlayerScore == 1 ? "Fifteen Love" : "Love All");
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }
    }
}