// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("git first");
Console.WriteLine("git seconds");
Bubblesort();




  static void Bubblesort()
  {
    int[] arrayToSort = { 64, 34, 25, 12, 22, 11, 90 };
   int n = arrayToSort.Length;
    bool swapped;

    do
    {
      swapped = false;

      for (int i = 0; i < n - 1; i++)
      {
        if (arrayToSort[i] > arrayToSort[i + 1])
        {
          // Swap elements if they are in the wrong order
          int temp = arrayToSort[i];
          arrayToSort[i] = arrayToSort[i + 1];
          arrayToSort[i + 1] = temp;

          swapped = true;
        }
      }
    } while (swapped);
    Console.WriteLine("Sorted array:");
    foreach (var element in arrayToSort)
    {
      Console.Write(element + " ");
    }
  }
