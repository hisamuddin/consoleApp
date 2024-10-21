void InsertionSort(int[] array)
{
    int n = array.Length;
    for (int i = 1; i < n; i++)
    {
        int key = array[i];  // element to be inserted
        int j = i - 1;
        
        while (j >= 0 && array[j] > key)
        {
            array[j + 1] = array[j];  // Shift larger elements right
            j--;
        }
        
        array[j + 1] = key;  // Insert key in its correct place
    }
}

DRY RUN -----

Initial Array: [7, 4, 5, 2]
Pass 1:
i = 1, key = 4, j = 0
Compare key with array[j] (4 < 7), so shift 7 to the right.
Array becomes: [7, 7, 5, 2]
j becomes -1 (exit loop).
Insert key (4) at array[j + 1] → array[0] = 4
Array after Pass 1: [4, 7, 5, 2]
Pass 2:
i = 2, key = 5, j = 1
Compare key with array[j] (5 < 7), so shift 7 to the right.
Array becomes: [4, 7, 7, 2]
j becomes 0.
Compare key with array[j] (5 >= 4), so stop shifting.
Insert key (5) at array[j + 1] → array[1] = 5
Array after Pass 2: [4, 5, 7, 2]
Pass 3:
i = 3, key = 2, j = 2
Compare key with array[j] (2 < 7), so shift 7 to the right.
Array becomes: [4, 5, 7, 7]
j becomes 1.
Compare key with array[j] (2 < 5), so shift 5 to the right.
Array becomes: [4, 5, 5, 7]
j becomes 0.
Compare key with array[j] (2 < 4), so shift 4 to the right.
Array becomes: [4, 4, 5, 7]
j becomes -1 (exit loop).
Insert key (2) at array[j + 1] → array[0] = 2
Array after Pass 3: [2, 4, 5, 7]
Final Sorted Array: [2, 4, 5, 7]
