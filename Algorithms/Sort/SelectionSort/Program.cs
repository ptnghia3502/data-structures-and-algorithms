namespace SelectionSort
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

        static void selectionSort(int[] a)
        {
            int indexMin;
            for (int i = 0; i < a.Length - 1; i++)
            {
                indexMin = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[indexMin] > a[j])
                    {
                        indexMin = j;
                    }
                }
                if (i != indexMin)
                {
                    int temp = a[i];
                    a[i] = a[indexMin];
                    a[indexMin] = temp;
                }
            }
        }

        //Unsorted List: 2, 5, -4, 11, 0, 18, 22, 67, 51, 6
        // -4 is smallest --> swap with first element --> -4, 2, 5, 11, 0, 18, 22, 67, 51, 6
        //Sorted List: -4

        //Unsorted List: 2, 5, 11, 0, 18, 22, 67, 51, 6
        // 0 is smallest --> swap with first element --> 0, 2, 5, 11, 18, 22, 67, 51, 6
        //Sorted List: -4, 0

        //Unsorted List: 2, 5, 11, 18, 22, 67, 51, 6
        // 2 is smallest 
        //Sorted List: -4, 0, 2

        //Unsorted List: 5, 11, 18, 22, 67, 51, 6
        // 5 is smallest 
        //Sorted List: -4, 0, 2, 5

        //.....

        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            Console.WriteLine("\nOriginal Array Elements :");
            printArray(numbers);
            Console.WriteLine("\nSorted Array Elements :");
            selectionSort(numbers);
            printArray(numbers);
            Console.WriteLine("\n");
        }
    }
}
