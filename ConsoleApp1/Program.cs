
using System.Net.Http.Headers;

int[] numbers = { 5, 3, 8, 4, 2 };
Console.WriteLine("Original array: " + string.Join(", ", numbers));
BubbleSort bubble = new BubbleSort();
;

Console.WriteLine("Sorted array: " + string.Join(", ", bubble.BubbleSortMethod(numbers)));

Console.WriteLine("===============================================================");



InsertionSort insertion = new InsertionSort();
var data = insertion.InsertionSortMethod();
Console.WriteLine("Sorted array: " + string.Join(", ", data));