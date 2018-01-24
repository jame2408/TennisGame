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
            return IsScoreDifferent()
                ? (IsReadyForWin() ? AdvStateScore() : NormalScore())
                : (IsDeuce() ? Deuce() : SameScore());
        }

        private string AdvStateScore()
        {
            return ReadyForWinName() + (IsAdv() ? " Adv" : " Win");
        }

        private string ReadyForWinName()
        {
            return _firstPlayerScore > _secondPlayerScore ? _firstPlayerName : _secondPlayerName;
        }

        private bool IsAdv()
        {
            return Math.Abs(_firstPlayerScore - _secondPlayerScore) == 1;
        }

        private bool IsReadyForWin()
        {
            return _firstPlayerScore > 3 || _secondPlayerScore > 3;
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