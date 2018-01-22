using System.Collections.Generic;

namespace TennisGame
{
    public class TennisGameScore
    {
        private readonly string _firstPlayer;
        private readonly string _secondPlayer;
        private int _firstPlayerScore;

        private int _secondPlayerScore;

        private readonly Dictionary<int, string> scoreLookup = new Dictionary<int, string>()
        {
            { 0, "Love" },
            { 1, "Fifteen" },
            { 2, "Thirty" },
            { 3, "Forty" }
        };

        public TennisGameScore(string firstPlayer, string secondPlayer)
        {
            _firstPlayer = firstPlayer;
            _secondPlayer = secondPlayer;
        }

        public string Score()
        {
            if (IsTheSameScore())
            {
                if (IsDeuce())
                {
                    return Deuce();
                }

                return SameScore();
            }

            return NormalScore();
        }

        private string NormalScore()
        {
            return scoreLookup[_firstPlayerScore] + " " + scoreLookup[_secondPlayerScore];
        }

        private string SameScore()
        {
            return scoreLookup[_firstPlayerScore] + " All";
        }

        private static string Deuce()
        {
            return "Deuce";
        }

        private bool IsDeuce()
        {
            return _firstPlayerScore >= 3 && _secondPlayerScore >= 3;
        }

        private bool IsTheSameScore()
        {
            return _firstPlayerScore == _secondPlayerScore;
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;}

        public void SecondPlayerScore()
        {
            _secondPlayerScore++;
        }
    }
}