class InsertionSort
{
    public int[] InsertionSortMethod(int[] arr)
    {
        Console.WriteLine("========== Starting Insertion Sort ==========");
        Console.WriteLine($"Original Array: [{string.Join(", ", arr)}]");
        Console.WriteLine("=============================================\n");

        int n = arr.Length;

        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            Console.WriteLine($"--- Pass {i} ---");
            Console.WriteLine($"Inserting element {key} into the sorted portion of the array.\n");

            while (j >= 0 && arr[j] > key)
            {
                Console.WriteLine($"Element {arr[j]} at index {j} is greater than {key}. Shifting it to the right.");
                arr[j + 1] = arr[j];
                j--;
                Console.WriteLine($"Array after shifting: [{string.Join(", ", arr)}]\n");
            }

            arr[j + 1] = key;
            Console.WriteLine($"Inserted element {key} at index {j + 1}");
            Console.WriteLine($"Array after Pass {i}: [{string.Join(", ", arr)}]\n");
        }

        Console.WriteLine($"Sorted Array: [{string.Join(", ", arr)}]");
        Console.WriteLine("========== Insertion Sort Completed ==========\n");

        return arr;
    }

}