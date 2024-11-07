class PrintRecursively
{

    public static void printnum(int n)
    {

        if (n == 0) return;
        printnum(n - 1);
        Console.WriteLine(n);

    }

}