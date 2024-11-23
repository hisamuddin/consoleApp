public class TwoPointerExample2
{

    public int RemoveDuplicates(int[] arr)
    {
        if (arr.Length == 0) return 0;

        int i = 0; // Slow pointer

        for (int j = 1; j < arr.Length; j++) // Fast pointer
        {
            if (arr[j] != arr[i])
            {
                i++;
                arr[i] = arr[j];
            }
        }

        return i + 1; // Length of array with unique elements
    }
}