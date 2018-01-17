using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGame
{
    [TestClass]
    public class TestTennisGameScore
    {
        [TestMethod]
        public void When_Game_Set_Start_Is_Love_All()
        {
            TennisGameScore tennisGameScore = new TennisGameScore();
            Assert.AreEqual("Love All", tennisGameScore.Score());
        }
    }
}
