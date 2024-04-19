using System;
using System.Linq;

namespace PalindromeExercise
{
	public class WordSmith
	{
		public bool IsPalindrome(string word)
		{
			return word.SequenceEqual(word.Reverse());
		}

    }
}

