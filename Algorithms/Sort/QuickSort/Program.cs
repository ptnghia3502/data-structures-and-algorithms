namespace QuickSort
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
        static void quickSort(int[] a, int l, int r)
        {
            int p = a[(l + r) / 2];
            int i = l, j = r;
            while (i < j)
            {
                while (a[i] < p)
                {
                    i++;
                }
                while (a[j] > p)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < r)
            {
                quickSort(a, i, r);
            }
            if (l < j)
            {
                quickSort(a, l, j);
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 9, 1, 3, 7, 8, 2, 4, 6, 5 };
            Console.WriteLine("\nOriginal Array Elements :");
            printArray(numbers);
            Console.WriteLine("\nSorted Array Elements :");
            quickSort(numbers, 0, numbers.Length - 1);
            printArray(numbers);
            Console.WriteLine("\n");
        }
    }
}
