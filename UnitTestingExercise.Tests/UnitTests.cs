using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(3, -6, -3, -6)]
        [InlineData(14, 16, 30, 60)]
        [InlineData(-16, -20, 6, -30)]

        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var cal = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                var actual = cal.Add(num1, num2, num3);  //whille store answer in actual


            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8,3,5)]//Add test data <-------
        [InlineData(3, -6, 9)]
        [InlineData(14, 16, -2)]
        [InlineData(-16, 20, -36)]

        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var cal = new Calculator();

            //Act
           var actual =  cal.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(3,4,12)]//Add test data <-------
        [InlineData(3, -6, -18)]
        [InlineData(14, 6, 84)]
        [InlineData(-16, 2, -32)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var cal = new Calculator();

            //Act
            var actual = cal.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(20,4,5)]//Add test data <-------
        [InlineData(-6, 3, -2)]
        [InlineData(16, 4, 4)]
        [InlineData(-20, 4, -5)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange 
            var cal = new Calculator();

            //Act
            var actual = cal.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
