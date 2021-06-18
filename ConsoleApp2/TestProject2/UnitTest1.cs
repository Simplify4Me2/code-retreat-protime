using FluentAssertions;
using System;
using ConsoleApp2;
using Xunit;
using Moq;
using System.Linq;

namespace TestProject2
{
    public class UnitTest1
    {

        public UnitTest1()
        {
        }

        [Fact]
        public void ThreeSameCharactersInARow_WinsTheGame()
        {
            // Arrange
            char playerXCharacter = 'X';
            char[] row = new char[3] { playerXCharacter, playerXCharacter, playerXCharacter };
            bool gameIsWon = false;

            // Act
            gameIsWon = RowHasWinningCondition(row, gameIsWon);

            // Assert
            gameIsWon.Should().BeTrue();
        }

        [Fact]
        public void ThreeDifferentCharactersInARow_DoesNotWinTheGame()
        {
            // Arrange
            char playerXCharacter = 'X';
            char playerOCharacter = 'O';
            char[] row = new char[3] { playerXCharacter, playerOCharacter, playerXCharacter };
            bool gameIsWon = false;

            // Act
            gameIsWon = RowHasWinningCondition(row, gameIsWon);

            // Assert
            gameIsWon.Should().BeFalse();
        }

        [Fact]
        public void ThreeSameCharactersInAColumn_WinsTheGame()
        {
            // Arrange
            char playerXCharacter = 'X';
            char[] column = new char[3] { playerXCharacter, playerXCharacter, playerXCharacter };
            bool gameIsWon = false;

            // Act
            gameIsWon = ColumnHasWinningCondition(column, gameIsWon);

            // Assert
            gameIsWon.Should().BeTrue();
        }


        [Fact]
        public void ThreeDifferentCharactersInAColumn_DoesNotWinTheGame()
        {
            // Arrange
            char playerXCharacter = 'X';
            char playerOCharacter = 'O';
            char[] column = new char[3] { playerXCharacter, playerOCharacter, playerXCharacter };
            bool gameIsWon = false;

            // Act
            gameIsWon = ColumnHasWinningCondition(column, gameIsWon);

            // Assert
            gameIsWon.Should().BeFalse();
        }

        [Fact]
        public void ThreeSameCharactersDiagonally_WinsTheGame()
        {
            // Arrange
            char playerXCharacter = 'X';
            char[] diagonal = new char[3] { playerXCharacter, playerXCharacter, playerXCharacter };
            bool gameIsWon = false;

            // Act
            gameIsWon = DiagonalHasWinningCondition(diagonal, gameIsWon);

            // Assert
            gameIsWon.Should().BeTrue();
        }

        [Fact]
        public void ThreeDifferentCharactersDiagonally_DoesNotWinTheGame()
        {
            // Arrange
            char playerXCharacter = 'X';
            char playerOCharacter = 'O';
            char[] column = new char[3] { playerXCharacter, playerOCharacter, playerXCharacter };
            bool gameIsWon = false;

            // Act
            gameIsWon = DiagonalHasWinningCondition(column, gameIsWon);

            // Assert
            gameIsWon.Should().BeFalse();
        }

        [Fact]
        public void BoardIsFull_HasNoWinningCondition_GameIsOver()
        {

        }

        private static bool RowHasWinningCondition(char[] row, bool gameIsWon)
        => HasWinningCondition(row, gameIsWon);

        private static bool ColumnHasWinningCondition(char[] column, bool gameIsWon)
        => HasWinningCondition(column, gameIsWon);

        private static bool DiagonalHasWinningCondition(char[] diagonal, bool gameIsWon)
        => HasWinningCondition(diagonal, gameIsWon);

        private static bool HasWinningCondition(char[] characters, bool gameIsWon)
        {
            if (characters.Distinct().Count() == 1)
                gameIsWon = true;
            return gameIsWon;
        }
    }
}
