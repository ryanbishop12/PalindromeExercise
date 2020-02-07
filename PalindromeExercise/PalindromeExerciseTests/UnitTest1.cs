using PalindromeExercise;
using System;
using Xunit;


namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        public void IsPalindromeTest(string word, bool expected)
        {
            //Arrange

            //Act
            bool actual = Program.IsPalindrome(word);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
