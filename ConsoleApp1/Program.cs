
using System.Drawing;
using System.Net.Http.Headers;

Console.WriteLine("======================== BubbleSort =======================================");
Console.WriteLine(Environment.NewLine);
int[] numbers = { 5, 3, 8, 4, 2 };
Console.WriteLine("Original array: " + string.Join(", ", numbers));
BubbleSort bubble = new BubbleSort();
Console.WriteLine("Sorted array: " + string.Join(", ", bubble.BubbleSortMethod(numbers)));

Console.WriteLine("========================= InsertionSort ======================================");
Console.WriteLine(Environment.NewLine);

InsertionSort insertion = new InsertionSort();
int[] array2 = { 64, 34, 25, 12, 22, 11, 90 };
var data = insertion.InsertionSortMethod(array2);
Console.WriteLine("Sorted array: " + string.Join(", ", data));


Console.WriteLine("======================== SelectionSort =======================================");
Console.WriteLine(Environment.NewLine);

SelectionSort selectionSort = new SelectionSort();
int[] array3 = { 64, 34, 25, 12, 22, 11, 90 };
var data2 = selectionSort.SelectionSortMethod(array3);
Console.WriteLine("Sorted array: " + string.Join(", ", data2));


Console.WriteLine("========================== QuickSort =====================================");
Console.WriteLine(Environment.NewLine);


QuickSort quicksort = new QuickSort();
int[] array = { 64, 34, 25, 12, 22, 11, 90 };
var quickSortData = quicksort.QuickSortMethod(array, 0, array.Length - 1);
Console.WriteLine("Sorted array: " + string.Join(", ", quickSortData));


Console.WriteLine("========================== MergeSort =====================================");
Console.WriteLine(Environment.NewLine);


MergeSort merge = new MergeSort();
int[] array4 = { 64, 34, 25, 12, 22, 11, 90 };
int mid = (0 + array.Length - 1) / 2;
merge.Merge(array4, 0, mid, array.Length - 1);



Console.WriteLine("========================== HeapSort =====================================");
Console.WriteLine(Environment.NewLine);


HeapSort heapSort = new HeapSort();
int[] arr = { 12, 11, 13, 5, 6, 7 };
Console.WriteLine("Original array: [" + string.Join(", ", arr) + "]");
heapSort.HeapSortMethod(arr);
Console.WriteLine("Sorted array: [" + string.Join(", ", arr) + "]");