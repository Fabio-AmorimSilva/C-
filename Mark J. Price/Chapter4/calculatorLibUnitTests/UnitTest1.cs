using System;
using calculatorLib;
using Xunit;

namespace calculatorLibUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1Add2And2()
        {
            // arrange
            double a = 2;
            double b = 2;
            double expected = 4;
            var calc = new calculator();
            
            // act
            double actual = calc.add(a,b);

            // assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test2Add3And5()
        {

        // arrange
        double a = 3;
        double b = 5;
        double expected = 8;
        var calc = new calculator();

        // act
        double actual = calc.add(a,b);

        // assert
        Assert.Equal(expected, actual);
        
        }
    }
}
