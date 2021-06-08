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
        public void Test1()
        {
            bool isMyTurn = true;
            isMyTurn.Should().BeTrue();
        }
    }
}
