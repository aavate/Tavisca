using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingBall.Tests
{
    [TestClass]
    public class GameFixture
    {
        [TestMethod]
        public void Gutter_game_score_should_be_zero_test()
        {
            var game = new Game();
            Roll(game, 0, 20);
            Assert.AreEqual(0, game.GetScore());
        }

        private void Roll(Game game, int pins, int times)
        {
            for (int i = 0; i < times; i++)
            {
                game.Roll(pins);
            }
        }

        [TestMethod]
        public void RollGame()
        {
            var game = new Game();
            for (int i = 0; i < 20; i++)
            {
                game.Roll(0);
                Assert.AreEqual(0, game.GetScore());
            }
        }

        [TestMethod]
        public void GutterGameScoreWhenSpare()
        {
            var game = new Game();
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            Roll(game, 0, 17);
            Assert.AreEqual(16, game.GetScore());
        }

        [TestMethod]
        public void GutterGameScoreWhenStrike()
        {
            var game = new Game();
            game.Roll(10);
            game.Roll(3);
            game.Roll(4);
            Roll(game,0,16);
            Assert.AreEqual(24, game.GetScore());
        }

        [TestMethod]
        public void GutterGameScoreWhenFullScore()
        {
            var game = new Game();
            Roll(game, 10, 12);
            Assert.AreEqual(300, game.GetScore());
        }
    }
}
