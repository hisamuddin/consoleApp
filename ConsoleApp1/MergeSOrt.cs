class MergeSort
{
    public void Merge(int[] array, int left, int mid, int right)
    {
        int leftArrayLength = mid - left + 1;
        int rightArrayLength = right - mid;

        int[] leftArray = new int[leftArrayLength];
        int[] rightArray = new int[rightArrayLength];

        Array.Copy(array, left, leftArray, 0, leftArrayLength);
        Array.Copy(array, mid + 1, rightArray, 0, rightArrayLength);

        int i = 0, j = 0, k = left;

        while (i < leftArrayLength && j < rightArrayLength)
        {
            if (leftArray[i] <= rightArray[j])
            {
                array[k] = leftArray[i];
                i++;
            }
            else
            {
                array[k] = rightArray[j];
                j++;
            }
            k++;
        }

        while (i < leftArrayLength)
        {
            array[k] = leftArray[i];
            i++;
            k++;
        }

        while (j < rightArrayLength)
        {
            array[k] = rightArray[j];
            j++;
            k++;
        }
    }

    public static void MergeSortRecursive(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            MergeSortRecursive(array, left, mid);
            MergeSortRecursive(array, mid + 1, right);

            Merge(array, left, mid, right);
        }
    }



}