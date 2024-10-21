class InsertionSort
{

    public int[] InsertionSortMethod()
    {
        Console.WriteLine("Starting Insertion Sort...");
        int[] array = { 3, 5, 4, 2, 7, 12 };
        Console.WriteLine("Original array: " + string.Join(", ", array));

        int n = array.Length;
        int pass = 1;
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine($"Pass {pass++}:");
            int key = array[i];  // Element to be inserted
            int j = i - 1;

            // Shift elements of array[0..i-1] that are greater than key
            // to one position ahead of their current position
            Console.WriteLine($"    Comparing right elemets   {array[j]} with key {key}");
            while (j >= 0 && array[j] > key)
            {
                Console.WriteLine($"    Shifting {array[j]} to the right");

                array[j + 1] = array[j];
                j = j - 1;
            }

            Console.WriteLine($"    Current array state before inserting key element: {string.Join(", ", array)}");
            Console.WriteLine($"    Inserting key {key} at index {j + 1}");

            // Insert the key at the correct position
            array[j + 1] = key;
            Console.WriteLine($"    Current array state after insertion: {string.Join(", ", array)}");
        }

        Console.ResetColor();
        return array;
    }
}