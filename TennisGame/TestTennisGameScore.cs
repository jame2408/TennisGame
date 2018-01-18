using System;
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
            tennisGameScore.FirstPlayerScore();
            ScoreShouldBe("Fifteen Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            tennisGameScore.FirstPlayerScore();
            tennisGameScore.FirstPlayerScore();
            ScoreShouldBe("Thirty Love");
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, tennisGameScore.Score());
        }
    }
}
