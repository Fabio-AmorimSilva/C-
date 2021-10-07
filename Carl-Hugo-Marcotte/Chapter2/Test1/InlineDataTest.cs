using System;
using Xunit;

namespace Test1
{
    public class InlineDataTest
    {
        [Theory]
        [InlineData(1,1)]
        [InlineData(2,2)]
        [InlineData(5,5)]
        public void Should_be_equal(int value1, int value2)
        {
            Assert.Equal(value1, value2);
        }
    }
}