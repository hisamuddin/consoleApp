using System.Text;

public class StringDataStructure_GetUniqueCharacters
{
    // Find the unique characters
    public StringBuilder GetUniqueCharacters(string input)
    {
        StringBuilder result = new StringBuilder();
        HashSet<char> seenChars = new HashSet<char>();

        foreach (char item in input)
        {
            if (!seenChars.Contains(char.ToLower(item)))
            {
                seenChars.Add(char.ToLower(item));
                result.Append(item);
            }
        }
        return result;
    }
}