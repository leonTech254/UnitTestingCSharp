public class ReverseInt
{
public int ReverseInteger(int number)
{
    // converting Int to string
    String numberString=number.ToString();
    // to Char Array
    Char[] numberArray=numberString.ToCharArray();
    // reversing the string
    var reverseredArray=numberArray.Reverse();

    String finalNumber="";
    foreach(char num in reverseredArray)
    {
        finalNumber+=num.ToString();
    }

    return int.Parse(finalNumber);
}    
    
}