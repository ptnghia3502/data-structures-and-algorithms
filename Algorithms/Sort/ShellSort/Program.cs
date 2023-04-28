namespace ShellSort
{
    public class Program
    {
        static void printArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }

        static void shellSort(int[] a)
        {
            int interval, i, j, temp;
            for (interval = a.Length / 2; interval > 0; interval /= 2)
            {
                for (i = interval; i < a.Length; i++)
                {
                    temp = a[i];
                    for (j = i; j >= interval && a[j - interval] > temp; j -= interval)
                    {
                        a[j] = a[j - interval];
                    }
                    a[j] = temp;
                }
            }
        }

        ////Origin Array: 9, 1, 3, 7, 8, 2, 4, 6, 5
        //Interval = n/2 = 9/2 = 4
        //9, 8, 5        1, 4,     3, 2        7, 6
        //Sorted 1st: 5, 1, 2, 6, 8, 4, 3, 7, 9
        //Interval = n/4 = 9/4 = 2
        //5, 2, 8, 3, 9         1, 6, 4, 7
        //Sorted 1st: 2, 1, 3, 4, 5, 6, 8, 7, 9
        //Interval = n/2 = 9/8 = 1
        //Sorted 1st: 1, 2, 3, 4, 5, 6, 8, 7, 9

        static void Main(string[] args)
        {
            int[] numbers = new int[] { 9, 1, 3, 7, 8, 2, 4, 6, 5 };
            Console.WriteLine("\nOriginal Array Elements :");
            printArray(numbers);
            Console.WriteLine("\nSorted Array Elements :");
            shellSort(numbers);
            printArray(numbers);
            Console.WriteLine("\n");
        }
    }
}
