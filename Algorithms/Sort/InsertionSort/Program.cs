namespace InsertionSort
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
        static void insertionSort(int[] a)
        {
            int index, value;
            for (int i = 1; i < a.Length; i++)
            {
                index = i;
                value = a[i];
                while (index > 0 && a[index - 1] > value)
                {
                    a[index] = a[index - 1];
                    index--;
                }
                a[index] = value;
            }
        }

        //Original Array Elements: 2, 5, -4, 11, 0, 18, 22, 67, 51, 6
        //Sub Array: 2

        //Step 1:
        //Origrin array: 2, 5, -4, 11, 0, 18, 22, 67, 51, 6
        //Sub Array: 2, 5

        //Step 2:
        //Origrin array: -4, 2, 5, 11, 0, 18, 22, 67, 51, 6
        //Sub Array: -4, 2, 5

        //Step 3:
        //Origrin array: -4, 2, 5, 11, 0, 18, 22, 67, 51, 6
        //Sub Array: -4, 2, 5, 11

        //Step 4:
        //Origrin array: -4, 0, 2, 5, 11, 18, 22, 67, 51, 6
        //Sub Array: -4, 0, 2, 5

        //........
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            Console.WriteLine("\nOriginal Array Elements :");
            printArray(numbers);
            Console.WriteLine("\nSorted Array Elements :");
            insertionSort(numbers);
            printArray(numbers);
            Console.WriteLine("\n");
        }
    }
}
