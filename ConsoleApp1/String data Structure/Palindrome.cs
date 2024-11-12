public class Palindrome
{
    // Check if the string is a palindrome
    public bool CheckPalindrome(string input)
    {
        if (string.IsNullOrEmpty(input))
            return false;

        input = input.ToLower().Trim();
        int min = 0;
        int max = input.Length - 1;

        while (max >= min)
        {
            if (input[min] == input[max])
            {
                min++;
                max--;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}