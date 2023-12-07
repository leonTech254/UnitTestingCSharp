public class Palindrome
{
    public Palindrome()
    {
        
    }
    public bool PalindromeMethod(string word)
    {
        var lettersArray = word.ToCharArray();
        Array.Reverse(lettersArray);

        string reversedWord = new string(lettersArray);

        return word.Equals(reversedWord, StringComparison.OrdinalIgnoreCase);
    }
}
