namespace AssessmentQuestions.Question6
{
	public class VowelCounts
	{
		public int VowelCount(string statement)
		{
			if (statement == null)
			{
				return 0;
			}
			else if (statement.Replace(" ", "") == "")
			{
				return 0;
			}
			// removing the spaces in between the satement
			string noSpaceString = statement.Replace(" ", "");
			// converting th String to char array
			char[] noSpaceArray = noSpaceString.ToCharArray();
			string[] vowels = { "a", "e", "i", "o", "u" };
			int number = 0;
			foreach (char letter in noSpaceArray)
			{
				bool isletter = Array.Exists(vowels, v => v.Equals($"{letter}", StringComparison.OrdinalIgnoreCase));
				if (isletter)
				{
					number++;
				}
				else
				{
					continue;
				}

			}
			return number;
		}
	}

}