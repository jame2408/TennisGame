using System;
using System.Collections.Generic;

namespace TennisGame
{
    public class TennisGameScore
    {
        private readonly string _firstPlayerName;
        private readonly string _secondPlayerName;
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
            if (IsScoreDifferent())
            {
                if (_firstPlayerScore > 3 || _secondPlayerScore > 3)
                {
                    if (Math.Abs(_firstPlayerScore - _secondPlayerScore) == 1)
                    {
                        if (_firstPlayerScore > _secondPlayerScore)
                        {
                            return _firstPlayerName + " Adv";
                        }

                        return _secondPlayerName + " Adv";
                    }

                    if (Math.Abs(_firstPlayerScore - _secondPlayerScore) >= 2)
                    {
                        if (_firstPlayerScore > _secondPlayerScore)
                        {
                            return _firstPlayerName + " Win";
                        }
                        return _secondPlayerName + " Win";
                    }
                }
                return NormalScore();
            }

            if (IsDeuce())
            {
                return Deuce();
            }

            return SameScore();
        }

        public TennisGameScore(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
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

        private bool IsScoreDifferent()
        {
            return _firstPlayerScore != _secondPlayerScore;
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