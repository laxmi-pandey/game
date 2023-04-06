using System;
using Bowling;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingTests
{
    [TestClass]
    public class GameTests
    {
        private BowlingGame game;

        [TestInitialize]
        public void Initialize()
        {
            game = new BowlingGame();
        }

        [TestMethod]
        public void CanRollGame()
        {
            RollMany(0,20);
            Assert.AreEqual(0, game.Score);
        }
      
        [TestMethod]
        public void CanRollAllOnes()
        {
            RollMany(1, 20);
            Assert.AreEqual(20, game.Score);
        }

        [TestMethod]
        public void CanRollSpare()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            RollMany(0, 17);    
            Assert.AreEqual(16, game.Score);

        }


        [TestMethod]
        public void CanRollStrike()
        {
            game.Roll(10);
            game.Roll(3);
            game.Roll(4);
            RollMany(0, 16);
            Assert.AreEqual(24, game.Score);

        }


        [TestMethod]
        public void CanRollPerfect()
        {
            RollMany(10, 12);
            Assert.AreEqual(300, game.Score);

        }
        private void RollMany(int pins, int rolls)
        {
            for (int i = 0; i < rolls; i++)
                game.Roll(pins);
        }

    }
}
