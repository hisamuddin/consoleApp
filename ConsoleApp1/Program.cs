
int[] numbers = { 5, 3, 8, 4, 2 };
Console.WriteLine("Original array: " + string.Join(", ", numbers));
BubbleSort bubble = new BubbleSort();
bubble.BubbleSortMethod(numbers);
Console.WriteLine("Sorted array: " + string.Join(", ", bubble.BubbleSortMethod(numbers)));

