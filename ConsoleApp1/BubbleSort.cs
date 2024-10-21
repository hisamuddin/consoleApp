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
                        // Console.ForegroundColor = ConsoleColor.White; // Change to red or any color you prefer
                        Console.WriteLine($" Swapping {array[j]} and {array[j + 1]} SWAPPING DONE");
                        // Console.ResetColor(); // Reset to default color

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


// Bubble Sort Explanation
// Bubble Sort is one of the simplest sorting algorithms. It repeatedly steps through a list, compares adjacent elements, 
// and swaps them if they are in the wrong order. This process is repeated until the list is sorted.

// How Bubble Sort Works:
// Compare Adjacent Elements: Start at the beginning of the list and compare each pair of adjacent elements.

// Swap If Necessary: If the current element is greater than the next element, swap them.
// Continue Comparisons: Move to the next pair of adjacent elements and repeat the comparison and swapping process.
// Repeat the Process: Once you reach the end of the list, go back to the start and repeat the process. The largest element will "bubble up" 
// to the end of the list after each pass.
// Stop When No Swaps Occur: The sorting is complete when no swaps are needed in a pass, meaning the list is in order.

// Example
// For an unsorted array like [5, 3, 8, 4, 2], Bubble Sort works like this:

// First Pass:

// Compare 5 and 3 → Swap → [3, 5, 8, 4, 2]
// Compare 5 and 8 → No Swap → [3, 5, 8, 4, 2]
// Compare 8 and 4 → Swap → [3, 5, 4, 8, 2]
// Compare 8 and 2 → Swap → [3, 5, 4, 2, 8]
// The largest number 8 is now in its correct place.

// Second Pass:

// Compare 3 and 5 → No Swap → [3, 5, 4, 2, 8]
// Compare 5 and 4 → Swap → [3, 4, 5, 2, 8]
// Compare 5 and 2 → Swap → [3, 4, 2, 5, 8]
// The second largest number 5 is now in its correct place.

// Third Pass:

// Compare 3 and 4 → No Swap → [3, 4, 2, 5, 8]
// Compare 4 and 2 → Swap → [3, 2, 4, 5, 8]
// The third largest number 4 is now in its correct place.

// Fourth Pass:

// Compare 3 and 2 → Swap → [2, 3, 4, 5, 8]
// Now, the list is fully sorted after this pass.


