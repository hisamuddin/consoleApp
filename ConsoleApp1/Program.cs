
using System.Drawing;
using System.Net.Http.Headers;
using LinkedListExamples;

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

Console.WriteLine("========================== Redix =====================================");
Console.WriteLine(Environment.NewLine);


RadixSort radixSort = new RadixSort();
int[] arr6 = { 170, 45, 75, 90, 802, 24, 2, 66 };
Console.WriteLine("Original array: [" + string.Join(", ", arr6) + "]");
radixSort.RadixSortMethod(arr6);
Console.WriteLine("Sorted array: [" + string.Join(", ", arr6) + "]");


Console.WriteLine(Environment.NewLine);
Console.WriteLine("Printing recursively");

PrintRecursively.printnum(6);


Console.WriteLine(Environment.NewLine);
Console.WriteLine("Linked list");
// Singly Linked List Example
var singlyList = new SinglyLinkedList();
singlyList.InsertEnd(1);
singlyList.InsertEnd(2);
singlyList.InsertEnd(3);
singlyList.Traverse(); // Output: 1 -> 2 -> 3 -> null

// Doubly Linked List Example
var doublyList = new DoublyLinkedList();
doublyList.InsertEnd(1);
doublyList.InsertEnd(2);
doublyList.InsertEnd(3);
doublyList.Traverse(); // Output: 1 <-> 2 <-> 3 <-> null

// Circular Linked List Example
var circularList = new CircularLinkedList();
circularList.InsertEnd(1);
circularList.InsertEnd(2);
circularList.InsertEnd(3);
circularList.Traverse(); // Output: 1 -> 2 -> 3 -> Head

// Doubly Circular Linked List Example
var doublyCircularList = new DoublyCircularLinkedList();
doublyCircularList.InsertEnd(1);
doublyCircularList.InsertEnd(2);
doublyCircularList.InsertEnd(3);
doublyCircularList.Traverse(); // Output: 1 <-> 2 <-> 3 <-> Head


Console.WriteLine(Environment.NewLine);
Console.WriteLine("String Operations _ get duplicate");
StringDataStructure _stringDT = new StringDataStructure();
// Find the duplicate characters in the string
var duplicates = _stringDT.GetDuplicateCharacters("google");
Console.WriteLine("Duplicate characters in 'google' are: " + duplicates);

Console.WriteLine(Environment.NewLine);
Console.WriteLine("String Operations get unique characters");

StringDataStructure_GetUniqueCharacters uniqueCharacters = new StringDataStructure_GetUniqueCharacters();
// Find the duplicate characters in the string
var uniqueCh = uniqueCharacters.GetUniqueCharacters("google");
Console.WriteLine("Unique characters in 'google' are: " + uniqueCh);

Console.WriteLine(Environment.NewLine);
Console.WriteLine("String Operations get palindrome");

Palindrome palindrome = new Palindrome();
var isPalindrome = palindrome.CheckPalindrome("malayalam");
Console.WriteLine($"The provided string is {isPalindrome}");

Console.WriteLine(Environment.NewLine);
Console.WriteLine("String Operations get CheckMaxOccurrenceOfCharacter");
CheckMaxOccurrenceOfChar checkMaxOccurrenceOf = new CheckMaxOccurrenceOfChar();
var maxOcuurence = checkMaxOccurrenceOf.CheckMaxOccurrenceOfCharacter("Malayalam");
Console.WriteLine($"The maximum occurence of string  is {maxOcuurence}");

Console.WriteLine(Environment.NewLine);
Console.WriteLine("Two Pointer Operations");
int[] arr7 = { 170, 45, 75, 90, 802, 24, 2, 66 };

TwoPointerExample1 twoPointer = new TwoPointerExample1();
var twopointer = twoPointer.FindPairWithSum(arr7, 120);
Console.WriteLine($"Result for two pointer {twopointer}");

Console.WriteLine(Environment.NewLine);
Console.WriteLine("Two Pointer Operations -- 2");
TwoPointerExample2 twoPointer2 = new TwoPointerExample2();
int[] arr8 = { 170, 45, 75, 75, 90, 802, 24, 2, 66 };
var twopointer2 = twoPointer2.RemoveDuplicates(arr7);
Console.WriteLine($"Result for two pointer 2removeduplicate is -{twopointer2}");


Console.WriteLine("Reverse string Operations");
ReverseString.ReverseStringFucntion("Google");
Console.WriteLine($"Result for Reverse string Operations -{ReverseString.ReverseStringFucntion("Google")}");

