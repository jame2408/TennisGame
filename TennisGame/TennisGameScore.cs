using System.Collections.Generic;

namespace TennisGame
{
    public class TennisGameScore
    {
        private int _firstPlayerScore;

        private readonly Dictionary<int, string> scoreLookup = new Dictionary<int, string>()
        {
            { 1, "Fifteen" },
            { 2, "Thirty" },
            { 3, "Forty" }
        };

        public string Score()
        {
            return _firstPlayerScore >= 1 ? scoreLookup[_firstPlayerScore] + " Love" : "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }
    }
}