class SelectionSort
{
    public int[] SelectionSortMethod(int[] arr)
    {
        Console.WriteLine("========== Starting Selection Sort ==========");
        Console.WriteLine($"Original Array: [{string.Join(", ", arr)}]");
        Console.WriteLine("=============================================\n");
        int[] arr1 = { 3, 5, 4, 2, 7, 12 };
        int n = arr1.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            Console.WriteLine($"--- Pass {i + 1} ---");
            Console.WriteLine($"Starting to find the minimum from index {i} onwards.\n");

            for (int j = i + 1; j < n; j++)
            {
                Console.WriteLine($"Comparing element at index {minIndex} (Element: {arr1[minIndex]}) with index {j} (Element: {arr1[j]})");

                if (arr1[j] < arr1[minIndex])
                {
                    Console.WriteLine($"New minimum found at index {j} (Element: {arr1[j]})");
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                Console.WriteLine($"Swapping element at index {i} (Element: {arr1[i]}) with new minimum at index {minIndex} (Element: {arr[minIndex]})");
                int temp = arr1[i];
                arr1[i] = arr1[minIndex];
                arr1[minIndex] = temp;
            }

            Console.WriteLine($"Array after Pass {i + 1}: [{string.Join(", ", arr1)}]\n");
        }

        Console.WriteLine($"Sorted Array: [{string.Join(", ", arr1)}]");
        Console.WriteLine("========== Selection Sort Completed ==========\n");

        return arr1;
    }
}
