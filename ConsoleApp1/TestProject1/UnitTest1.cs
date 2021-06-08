using System;
using Xunit;
using FluentAssertions;
using ConsoleApp1;

namespace TestProject1
{
    public class BoardTest
    {
        [Fact]
        public void Board_Should_Have_9_Cells()
        {
            var board = new Board();
            board.Cells.Length.Should().Be(9);
        }

    }

    public class GameTest
    {
        [Fact]
        public void Game_Should_Have_PlayerOne()
        {
            var game = new Game();
            game.PlayerOne.Should().NotBeNull();
        }

        [Fact]
        public void Game_Should_Have_PlayerTwo()
        {
            var game = new Game();
            game.PlayerTwo.Should().NotBeNull();
        }

        [Fact]
        public void PlayerOne_Should_Have_Character_X()
        {
            var game = new Game();
            game.PlayerOne.Character.Should().Be('X');
        }

        [Fact]
        public void PlayerTwo_Should_Have_Character_O()
        {
            var game = new Game();
            game.PlayerTwo.Character.Should().Be('O');
        }
    }

    public class PlayerTest
    {
        [Fact]
        public void Player_Should_Have_A_Character()
        {
            var player = new Player('D');
            player.Character.Should().NotBeNull();
        }
    }

    public class CellTest
    {
        [Fact]
        public void Cell_Should_Have_Coordinate_X()
        {
            var cell = new Cell();
            cell.Coordinates.X.Should().Be();
        }
    }
}
