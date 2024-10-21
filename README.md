<details>

```c#
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
```

</details>
