class TwoPointerExample1
{
    public bool FindPairWithSum(int[] arr, int targetSum)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            int currentSum = arr[left] + arr[right];

            if (currentSum == targetSum)
            {
                Console.WriteLine($"Pair found: ({arr[left]}, {arr[right]})");
                return true;
            }
            else if (currentSum < targetSum)
            {
                left++;  // Increase the sum by moving the left pointer to the right
            }
            else
            {
                right--; // Decrease the sum by moving the right pointer to the left
            }
        }
        Console.WriteLine("No pair found with the given sum.");
        return false;
    }
}