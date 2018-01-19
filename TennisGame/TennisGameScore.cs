using System.Collections.Generic;

namespace TennisGame
{
    public class TennisGameScore
    {
        private int _firstPlayerScore;

        private int _secondPlayerScore;

        private readonly Dictionary<int, string> scoreLookup = new Dictionary<int, string>()
        {
            { 0, "Love" },
            { 1, "Fifteen" },
            { 2, "Thirty" },
            { 3, "Forty" }
        };

        public string Score()
        {
            return (_firstPlayerScore == _secondPlayerScore) 
                ? scoreLookup[_firstPlayerScore]+ " All" : 
                scoreLookup[_firstPlayerScore] + " " + scoreLookup[_secondPlayerScore];
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScore++;
        }
    }
}