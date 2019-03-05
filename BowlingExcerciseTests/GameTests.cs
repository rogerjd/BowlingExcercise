using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingExcercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BowlingExcercise;

namespace BowlingExcercise.Tests
{
    [TestClass()]
    public class GameTests
    {
        [TestMethod()]
        public void StartTest()
        {
            Game game = new Game();
            game.Start();

            Assert.AreEqual(game.CurrentFrame, 1);

            Assert.AreEqual(game.ScoreByFrame.Length, 10);

            CollectionAssert.AreEqual(game.ScoreByFrame, new int[10]);
        }
    }
}