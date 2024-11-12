//Implement Heap Sort 
class HeapSort
{


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
            if (largest != i)
            {
                int temp = arr[i]; // Swap
                arr[i] = arr[largest];
                arr[largest] = temp;

                // Recursively heapify the affected sub-tree
                Heapify(arr, n, largest);
            }
        }
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
            // Move current root to end
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;

            Heapify(arr, i, 0);
        }
    }

}