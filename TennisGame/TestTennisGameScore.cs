﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGame
{
    [TestClass]
    public class TestTennisGameScore
    {
        TennisGameScore tennisGameScore = new TennisGameScore();

        [TestMethod]
        public void When_Game_Set_Start_Is_Love_All()
        {
            ScoreShouldBe("Love All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            GivenFirstPlayerScoreTimes(1);
            ScoreShouldBe("Fifteen Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            GivenFirstPlayerScoreTimes(2);
            ScoreShouldBe("Thirty Love");
        }

        private void GivenFirstPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                tennisGameScore.FirstPlayerScore();
            }
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, tennisGameScore.Score());
        }
    }
}
