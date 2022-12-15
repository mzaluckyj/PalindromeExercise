using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("truck", false)]
        [InlineData("level", true)]
        [InlineData("story", false)]
        [InlineData("pop", true)]
        [InlineData("soda", false)]
        public void Test1(string word, bool expected)
        {
            //arrange act assert
            var test = new WordSmith();

            var actual = test.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }

    }


}
