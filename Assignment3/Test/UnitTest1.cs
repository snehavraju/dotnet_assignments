using System;
using Xunit;
using Code;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            math M= new math(10,10,10);
            var result = M.triangleperim();
            math N = new math(10,10);
            var result1 = N.rectangleperim();
            math P = new math(10);
            var result2 = P.squareperim();

            Assert.IsType<int>(result);
            Assert.Equal(30,result);


            Assert.IsType<int>(result1);
            Assert.Equal(40,result1);

            Assert.IsType<int>(result2);
            Assert.Equal(40,result2);


        }
    }
}
