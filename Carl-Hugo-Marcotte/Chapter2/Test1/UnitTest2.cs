using System;
using Xunit;

namespace Test1
{
    public class UnitTest2
    {
        [Fact]
        public void Should_be_equal()
        {
            var num1 = 3;
            var num2 = 3;
            Assert.Equal(num1, num2);
           
        }
    }
}
