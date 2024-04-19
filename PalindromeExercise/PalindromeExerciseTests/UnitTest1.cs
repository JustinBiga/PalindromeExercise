using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    { [Theory]
        [InlineData("civic", true)]
        [InlineData("deified", true)]
        [InlineData("noon", true)]
        [InlineData("repaper", true)]
        [InlineData("check", false)]
        [InlineData("madam", true)]

        public void IsPalindromeTest(string word, bool expected)
        {
            var palindrome = new WordSmith();

            var actual = palindrome.IsPalindrome(word);

            Assert.Equal(expected, actual);
        }
      
       
    }
}
