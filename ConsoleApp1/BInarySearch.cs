class BinarySearch
{
    public static object BinarySearchIterative(int[] inputArray, int key)
    {
        int min = 0;
        int max = inputArray.Length - 1;
        while (min <= max)
        {
            int mid = (min + max) / 2;
            if (key == inputArray[mid])
            {
                return ++mid;
            }
            else if (key < inputArray[mid])
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }
        return "Nil";
    }

    public static object BinarySearchRecursive(int[] inputArray, int key, int min, int max)
    {
        if (min > max)
        {
            return "Nil";
        }
        else
        {
            int mid = (min + max) / 2;
            if (key == inputArray[mid])
            {
                return ++mid;
            }
            else if (key < inputArray[mid])
            {
                return BinarySearchRecursive(inputArray, key, min, mid - 1);
            }
            else
            {
                return BinarySearchRecursive(inputArray, key, mid + 1, max);
            }
        }
    }
    public static int BinarySearchGPT(List<int> list, int target)
    {
        int left = 0;
        int right = list.Count - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2; // Avoids overflow

            if (list[mid] == target)
            {
                return mid; // Target found at mid
            }
            else if (list[mid] < target)
            {
                left = mid + 1; // Target is in the right half
            }
            else
            {
                right = mid - 1; // Target is in the left half
            }
        }
        return -1; // Target not found
    }
}
