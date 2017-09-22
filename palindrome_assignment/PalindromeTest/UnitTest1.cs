using System;
using palindrome;
using Xunit;

namespace PalindromeTest
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {

            //Arrange
            Palind objPalindrom = new Palind();

            //Act
            bool result = objPalindrom.IsPalindrom("redivider");          

            //Assert
            Assert.IsType<bool>(result);
            Assert.True(result);

            bool resultNegative = objPalindrom.IsPalindrom("Test");
            Assert.False(resultNegative);


        }
    }
}
