using System.Text;

public class StringDataStructure
{
    // Find the duplicate characters
    public StringBuilder GetDuplicateCharacters(string input)
    {
        StringBuilder result = new StringBuilder();
        HashSet<char> seenChars = new HashSet<char>();

        foreach (char item in input)
        {
            if (!seenChars.Contains(char.ToLower(item)))
            {
                seenChars.Add(char.ToLower(item));
            }
            else if (result.ToString().IndexOf(char.ToLower(item)) == -1)
            {
                result.Append(item);
            }
        }
        return result;
    }
}

