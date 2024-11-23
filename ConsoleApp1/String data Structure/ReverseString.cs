class ReverseSTring
{
    public static string ReverseString(string input)
    {
        char[] reversed = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            reversed[i] = input[input.Length - i - 1];
        }

        return new string(reversed);
    }
}