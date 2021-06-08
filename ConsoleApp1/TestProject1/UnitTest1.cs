using System;
using Xunit;
using FluentAssertions;

namespace TestProject1
{
    public class BoardTest
    {
        [Fact]
        public void Board_Should_Be_Empty_From_The_Start()
        {
            var board = new Board();
            board.Cells.Length.Should().Be(9);
        }
    }
}
