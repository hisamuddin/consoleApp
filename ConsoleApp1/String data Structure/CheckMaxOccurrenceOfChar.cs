public class CheckMaxOccurrenceOfChar
{
    // Check the character with the maximum occurrence in the string
    public char? CheckMaxOccurrenceOfCharacter(string input)
    {
        if (string.IsNullOrEmpty(input))
            return null;

        input = input.ToLower().Trim();
        char[] arr = input.ToCharArray();

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in arr)
        {
            if (c != ' ')
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount.Add(c, 1);
                }
            }
        }
        char? maxOccurrenceChar = null;
        int maxOccurrenceValue = 0;
        foreach (KeyValuePair<char, int> item in charCount)
        {
            if (item.Value > maxOccurrenceValue)
            {
                maxOccurrenceChar = item.Key;
                maxOccurrenceValue = item.Value;
            }
        }
        return maxOccurrenceChar;
    }
}