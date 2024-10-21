class BubbleSort
{
    // Bubble Sort Implementation
    public int[] BubbleSortMethod(int[] array)
    {
        {
            int n = array.Length;
            Console.WriteLine("Starting Bubble Sort...");

            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;
                Console.WriteLine($"Pass {i + 1}:");

                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.WriteLine($"    Comparing {array[j]} and {array[j + 1]}");

                    if (array[j] > array[j + 1])
                    {
                        // Change console color for swap
                        Console.ForegroundColor = ConsoleColor.Red; // Change to red or any color you prefer
                        Console.WriteLine($" Swapping {array[j]} and {array[j + 1]}");
                        Console.ResetColor(); // Reset to default color

                        // Swap array[j] and array[j + 1]
                        Console.WriteLine($"    Swapping {array[j]} and {array[j + 1]}");
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }

                    Console.WriteLine($"    Current array state: {string.Join(", ", array)}");
                }

                // If no two elements were swapped by inner loop, then break
                if (!swapped)
                {
                    Console.WriteLine("    No swaps made, array is sorted.");
                    break;
                }
            }

            Console.WriteLine("Bubble Sort completed.");
            return array;
        }
    }
}