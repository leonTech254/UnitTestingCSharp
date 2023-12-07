using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssesMentAssignMent.Question7
{
	public class MostApprearingCharacter
	{
		public static char GetMostFrequentChar(string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException("Value cannot be null or empty.", nameof(value));
			}

			var charCount = new Dictionary<char, int>();

			foreach (var c in value)
			{
				if (charCount.ContainsKey(c))
				{
					charCount[c]++;
				}
				else
				{
					charCount[c] = 1;
				}
			}

			var mostFrequentChar = charCount.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

			return mostFrequentChar;
		}

	}
}
