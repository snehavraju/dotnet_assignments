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
            //Arrange
            PE1 p = new PE1();

            //Act
            var sum = p.palin(1234321);          

            //Assert
            Assert.IsType<long>(sum);
            Assert.Equal(8,sum);
            
        }

        public void Test2()
        {
            //Arrange
            PE2 q = new PE2();

            //Act
            var str = q.TomJerry(24);          

            //Assert
            Assert.IsType<string>(str);
            Assert.Equal("Jerry",str);
            
        }

         public void Test3()
        {
            //Arrange
            PE3 r = new PE3();

            //Act
            var str = r.word("i");          

            //Assert
            Assert.IsType<string>(str);
            Assert.Equal("vowel",str);
            
        }

        public void Test4()
        {
            //Arrange
            PE4 s = new PE4();

            //Act
            var sum = s.series(4);          

            //Assert
            Assert.IsType<int>(sum);
            Assert.Equal(1223334444,sum);
            
        }

        public void Test5()
        {
            //Arrange
            PE5 t = new PE5();

            //Act
            var sum = t.sorting("8868");          

            //Assert
            Assert.IsType<int>(sum);
            Assert.Equal(30,sum);
            
        }

        public void Test6()
        {
            //Arrange
            PE6 u = new PE6();

            //Act
            var sum = u.repeat("stack",2);          

            //Assert
            Assert.IsType<string>(sum);
            Assert.Equal("stackckck",sum);
            
        }
    }
}
