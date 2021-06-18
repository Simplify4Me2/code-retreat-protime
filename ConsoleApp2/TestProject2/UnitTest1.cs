using FluentAssertions;
using System;
using ConsoleApp2;
using Xunit;
using Moq;

namespace TestProject2
{
    public class UnitTest1
    {

        public UnitTest1()
        {

        }

        [Fact]
        public void PlayerMakesMove_MadeWinningMove_PlayerHasWon()
        {
            var player = new Player();
            
            var result = player.Move();

            result.Should().BeTrue();
        }
    }
}
