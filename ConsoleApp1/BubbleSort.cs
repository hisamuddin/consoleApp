class BubbleSort
{
    public int[] BubbleSortMethod(int[] arr)
    {
        Console.WriteLine("========== Starting Bubble Sort ==========");
        Console.WriteLine($"Original Array: [{string.Join(", ", arr)}]");
        Console.WriteLine("==========================================\n");

        int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            Console.WriteLine($"--- Pass {i + 1} ---");

            for (int j = 0; j < n - i - 1; j++)
            {
                Console.WriteLine($"Comparing index {j} (Element: {arr[j]}) and index {j + 1} (Element: {arr[j + 1]})");

                if (arr[j] > arr[j + 1])
                {
                    Console.WriteLine($"Swapping {arr[j]} and {arr[j + 1]}");
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }

                Console.WriteLine($"Array after comparison: [{string.Join(", ", arr)}]\n");
            }

            if (!swapped)
            {
                Console.WriteLine("No swaps in this pass, the array is sorted.");
                break;
            }
        }

        Console.WriteLine($"Sorted Array: [{string.Join(", ", arr)}]");
        Console.WriteLine("========== Bubble Sort Completed ==========\n");

        return arr;
    }
}
