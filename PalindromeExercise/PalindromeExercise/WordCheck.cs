using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
	public class WordCheck
	{
		public WordCheck()
		{

		}
		public bool IsPalindrome(string input)
		{
			int length = input.Length;
			for (int i = 0; i < length / 2; i++)
			{
				if (input[i] != input[length - i - 1])
				{
					return false;
				}
			}
				return true;
		}
	}
}
