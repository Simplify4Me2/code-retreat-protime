using FluentAssertions;
using System;
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
        public void Is_Players_Turn()
        {
            bool isMyTurn = true;
            isMyTurn.Should().BeTrue();
            
        }

        [Fact]
        public void Is_Not_Players_Turn()
        {
            bool isMyTurn = false;
            isMyTurn.Should().BeFalse();
        }
    }
}
