using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("tacocat", true)]
        [InlineData("racecar", true)]
        [InlineData("toyota", false)]
        public void Test1(string word, bool expected)
		{
            //Arrange
            var wordCheck = new WordCheck();
            //Act
            var actual = wordCheck.IsPalindrome(word);
            //Assert
            Assert.Equal(expected, actual);
		}
    }
}
