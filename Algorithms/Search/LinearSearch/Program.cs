public class LinearSearchExample
{
    public static void Main()
    {
        int[] arr = { 5, 10, 15, 20, 25, 30 }; // declare and initialize the array
        int x = 20; // declare and initialize the value to search for
        int index = LinearSearch(arr, x); // search for the value in the array

        if (index == -1)
        {
            Console.WriteLine("Element not found"); // value not found in the array
        }
        else
        {
            Console.WriteLine("Element found at index " + index); // value found at index
        }
    }

    public static int LinearSearch(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                return i; // value found at index i
            }
        }
        return -1; // value not found in the array
    }
}
