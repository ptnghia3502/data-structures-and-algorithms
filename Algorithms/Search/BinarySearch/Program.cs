public class BinarySearchExample
{
    public static void Main()
    {
        int[] arr = { 5, 10, 15, 20, 25, 30 }; // declare and initialize the sorted array
        int x = 20; // declare and initialize the value to search for
        int index = BinarySearch(arr, x); // search for the value in the array

        if (index == -1)
        {
            Console.WriteLine("Element not found"); // value not found in the array
        }
        else
        {
            Console.WriteLine("Element found at index " + index); // value found at index
        }
    }

    public static int BinarySearch(int[] arr, int x)
    {
        int left = 0; // set the leftmost index to 0
        int right = arr.Length - 1; // set the rightmost index to the last element of the array

        while (left <= right)
        { // while the left index is less than or equal to the right index
            int mid = (left + right) / 2; // find the middle index

            if (arr[mid] == x)
            {
                return mid; // value found at index mid
            }
            else if (arr[mid] < x)
            {
                left = mid + 1; // search the right half of the array
            }
            else
            {
                right = mid - 1; // search the left half of the array
            }
        }
        return -1; // value not found in the array
    }
}
