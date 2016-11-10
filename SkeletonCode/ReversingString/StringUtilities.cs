using System;
using System.Text;

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

			StringBuilder sb = new StringBuilder();

			for(int i = input.Length - 1; i >= 0; i--)
			{
				sb.Append(input[i]);
			}

			return sb.ToString();
		}
	}
}
