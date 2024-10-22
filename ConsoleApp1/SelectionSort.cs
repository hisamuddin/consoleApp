class SelectionSort
{
    public int[] SelectionSortMethod(int[] arr)
    {
        Console.WriteLine("========== Starting Selection Sort ==========");
        Console.WriteLine($"Original Array: [{string.Join(", ", arr)}]");
        Console.WriteLine("=============================================\n");

        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            Console.WriteLine($"--- Pass {i + 1} ---");
            Console.WriteLine($"Starting to find the minimum from index {i} onwards.\n");

            for (int j = i + 1; j < n; j++)
            {
                Console.WriteLine($"Comparing element at index {minIndex} (Element: {arr[minIndex]}) with index {j} (Element: {arr[j]})");

                if (arr[j] < arr[minIndex])
                {
                    Console.WriteLine($"New minimum found at index {j} (Element: {arr[j]})");
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                Console.WriteLine($"Swapping element at index {i} (Element: {arr[i]}) with new minimum at index {minIndex} (Element: {arr[minIndex]})");
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }

            Console.WriteLine($"Array after Pass {i + 1}: [{string.Join(", ", arr)}]\n");
        }

        Console.WriteLine($"Sorted Array: [{string.Join(", ", arr)}]");
        Console.WriteLine("========== Selection Sort Completed ==========\n");

        return arr;
    }
}
