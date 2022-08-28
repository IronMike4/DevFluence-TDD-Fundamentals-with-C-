using System;
using NUnit.Framework;

namespace RockPaperScissorsTests
{
    public class GameTests
    {
        [Test]
        public void METHOD()
        {
            // Arrange
            var sut = new Game();

            // Act 
            var play = sut.Play("Paper", "Rock");

            // Assert
            Assert.AreEqual("Player Wins", play);
        }
    }

    public class Game
    {
        public object Play(string playerMove, string opponentMove)
        {
            return null;
        }
    }
}
