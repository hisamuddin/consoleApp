<details>

```c#
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
    
public int[] InsertionSortMethod()
{
    Console.WriteLine("Starting Insertion Sort...");
    int[] array = { 3, 5, 4, 2, 7, 12 };
    Console.WriteLine("Original array: " + string.Join(", ", array));

    int n = array.Length;

    for (int i = 1; i < n; i++)
    {
        Console.WriteLine($"Pass {i + 1}:");
        int key = array[i];  // Element to be inserted
        int j = i - 1;

        // Shift elements of array[0..i-1] that are greater than key
        // to one position ahead of their current position
        Console.WriteLine($"    Comparing {array[j]} and {key}");
        while (j >= 0 && array[j] > key)
        {
            Console.ForegroundColor = ConsoleColor.Red; // Change to red or any color you prefer
            Console.WriteLine($"    Shifting {array[j]} to the right");
            Console.ResetColor(); // Reset to default color

            array[j + 1] = array[j];
            j = j - 1;
        }
        
        Console.WriteLine($"    Current array state before inserting key element: {string.Join(", ", array)}");
        Console.WriteLine($"    Inserting key {key} at position {j + 1}");
        
        // Insert the key at the correct position
        array[j + 1] = key;
        Console.WriteLine($"    Current array state after insertion: {string.Join(", ", array)}");
    }

    Console.ResetColor();
    return array;
}

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

 public void Heapify(int[] arr, int n, int i)
    {
        int largest = i;  // Initialize largest as root
        int left = 2 * i + 1;  // left child index
        int right = 2 * i + 2;  // right child index

        // Check if left child exists and is greater than root
        if (left < n && arr[left] > arr[largest])
            largest = left;

        // Check if right child exists and is greater than largest so far
        if (right < n && arr[right] > arr[largest])
            largest = right;

        // If largest is not root, swap with root and continue heapifying
        if (largest != i)
        {
            Swap(ref arr[i], ref arr[largest]);
            Heapify(arr, n, largest);
        }
    }

    public void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    public void HeapSortMethod(int[] arr)
    {
        int n = arr.Length;

        // Build a maxheap
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(arr, n, i);

        // One by one extract elements from heap
        for (int i = n - 1; i > 0; i--)
        {
            Swap(ref arr[0], ref arr[i]);
            Heapify(arr, i, 0);
        }
    }

```

</details>
