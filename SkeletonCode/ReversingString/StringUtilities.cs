using System;

namespace SkeletonCode.ReversingString
{
	public class StringUtilities
	{
		public string Reverse(string input)
		{

			if (input == null)
			{
				return String.Empty;
			}

			string output = string.Empty;

			for(int i = input.Length - 1; i >= 0; i--)
			{
				output += input[i];
			}

			return output;
		}
	}
}
