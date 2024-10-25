class RadixSort
{
    // Function to get the largest element from an array
    public int GetMax(int[] arr)
    {
        int max = arr[0];
        foreach (int num in arr)
        {
            if (num > max)
                max = num;
        }
        return max;
    }

    // Function to perform counting sort based on the digit represented by exp
    public void CountingSort(int[] arr, int exp)
    {
        int n = arr.Length;
        int[] output = new int[n]; // output array
        int count = 10; // base 10 for decimal numbers
        int[] countArr = new int[count];

        // Initialize count array
        for (int i = 0; i < count; i++)
            countArr[i] = 0;

        // Store count of occurrences in countArr
        for (int i = 0; i < n; i++)
            countArr[(arr[i] / exp) % 10]++;

        // Change countArr so that it contains actual positions of digits in output
        for (int i = 1; i < count; i++)
            countArr[i] += countArr[i - 1];

        // Build the output array
        for (int i = n - 1; i >= 0; i--)
        {
            output[countArr[(arr[i] / exp) % 10] - 1] = arr[i];
            countArr[(arr[i] / exp) % 10]--;
        }

        // Copy the output array to arr, so that arr now contains sorted numbers
        for (int i = 0; i < n; i++)
            arr[i] = output[i];
    }

    // Main function to implement radix sort
    public void RadixSortMethod(int[] arr)
    {
        // Get the maximum number to know the number of digits
        int max = GetMax(arr);

        // Do counting sort for every digit. exp is 10^i where i is the current digit number
        for (int exp = 1; max / exp > 0; exp *= 10)
            CountingSort(arr, exp);
    }
}