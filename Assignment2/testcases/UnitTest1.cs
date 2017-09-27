using System;
using Xunit;
using dotnet_assignment2;

namespace testcases
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            
            //Arrange
            Fibonacci fib = new Fibonacci();

            //Act
            var summation = fib.Printseries(5);          

            //Assert
            Assert.IsType<int>(summation);
            Assert.Equal(7,summation);
            
           

        }

        

          [Fact]
          public void Test2(){

            //Arrange
            Arrayser arr = new Arrayser();

            //Act
            var ivalue = arr.PrintNumbers(20);          

            //Assert
            Assert.IsType<int>(ivalue);
            Assert.Equal(20,ivalue);

           

        }
    
}}
