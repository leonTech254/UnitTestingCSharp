namespace AssessmentQuestions.Question4
{
	public class Palindrome
	{
		public bool PalindromeMethod(string word)
		{
			var lettersArray = word.ToCharArray();
			Array.Reverse(lettersArray);

			string reversedWord = new string(lettersArray);

			return word.Equals(reversedWord, StringComparison.OrdinalIgnoreCase);
		}
	}
}