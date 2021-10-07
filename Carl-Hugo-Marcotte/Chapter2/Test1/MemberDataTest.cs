using System;
using System.Collections.Generic;
using Xunit;

namespace Test1
{
    public class MemberDataTest
    {
        public static IEnumerable<object []> Data => new[]
        {
            new object[] {1, 2, false},
            new object[] {2, 2, false},
            new object[] {3, 3, false},
        };

        public static TheoryData<int, int, bool> TypedData =>
            new TheoryData<int, int, bool>
        {
            { 3, 2, false },
            { 2, 3, false },
            { 5, 5, true },
        };

        [Theory]
        [MemberData(nameof(Data))]
        [MemberData(nameof(TypedData))]
        [MemberData(nameof(ExternalData.GetData), 10, MemberType = typeof(ExternalData))]
        [MemberData(nameof(ExternalData.TypedData), MemberType = typeof(ExternalData))]
        public void Should_be_equal(int value1, int value2, bool shouldBeEqual)
        {
            if(shouldBeEqual)
            {
                Assert.Equal(value1, value2);

            }
            else
            {
                Assert.NotEqual(value1, value2);
            }
        }

        public class ExternalData
        {
            public static IEnumerable<object []> GetData(int start) 
            => new[]
            {
                new object[] {start, start, true},
                new object[] {start, start + 1, false},
                new object[] {start + 1, start, true},
            };

            public static TheoryData<int, int, bool> TypedData => 
                new TheoryData<int, int, bool>
                {
                    {20, 20, false},
                    {40, 40, false},
                    {50, 50, true},
                };
        }
    }
}