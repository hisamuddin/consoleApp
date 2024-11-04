class QuickSort
{
    public int[] QuickSortMethod(int[] arr, int leftindex, int rightindex)
    {
        var i = leftindex;
        var j = rightindex;
        var pivot = arr[leftindex];

        Console.WriteLine("========== Starting QuickSort Method ==========");
        Console.WriteLine($"Original Array: [{string.Join(", ", arr)}]");
        Console.WriteLine($"Pivot Element: {pivot} (at index {leftindex})");
        Console.WriteLine($"Left Index: {leftindex}, Right Index: {rightindex}");
        Console.WriteLine("===============================================\n");

        while (i <= j)
        {
            Console.WriteLine($"--- Checking element at index {i} ---");
            Console.WriteLine($"Current Element: {arr[i]}, Pivot: {pivot}");

            // Increment index i while arr[i] is less than pivot
            while (arr[i] < pivot)
            {
                Console.WriteLine($"Element {arr[i]} is less than pivot {pivot}, incrementing index i...");
                i++;
            }
            Console.WriteLine($"Stopped incrementing i. Current index i: {i} (Element: {arr[i]})\n");

            // Decrement index j while arr[j] is greater than pivot
            Console.WriteLine($"--- Checking element at index {j} ---");
            Console.WriteLine($"Current Element: {arr[j]}, Pivot: {pivot}");
            while (arr[j] > pivot)
            {
                Console.WriteLine($"Element {arr[j]} is greater than pivot {pivot}, decrementing index j...");
                j--;
            }
            Console.WriteLine($"Stopped decrementing j. Current index j: {j} (Element: {arr[j]})\n");

            // Swap elements at i and j if i <= j
            if (i <= j)
            {
                Console.WriteLine($"Swapping elements at index {i} and {j}...");
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;

                Console.WriteLine($"Array after swap: [{string.Join(", ", arr)}]");
                Console.WriteLine($"Incrementing i and decrementing j after swap.\n");

                i++;
                j--;
            }
        }

        Console.WriteLine($"New i value: {i}, New j value: {j}");
        Console.WriteLine($"Left Index: {leftindex}, Right Index: {rightindex}\n");

        // Recursively sort left and right sub-arrays
        if (leftindex < j)
        {
            Console.WriteLine($"Recursively sorting left part: indices {leftindex} to {j}\n");
            QuickSortMethod(arr, leftindex, j);
        }
        if (i < rightindex)
        {
            Console.WriteLine($"Recursively sorting right part: indices {i} to {rightindex}\n");
            QuickSortMethod(arr, i, rightindex);
        }

        Console.WriteLine($"Returning sorted array: [{string.Join(", ", arr)}]\n");
        Console.WriteLine("========== QuickSort Method Completed ==========\n");

        return arr;
    }
}
