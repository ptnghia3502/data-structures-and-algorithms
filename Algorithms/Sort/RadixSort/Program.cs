using System;

public class RadixSortExample
{
    public static void Main()
    {
        int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 }; // declare and initialize the original unsorted array
        Console.WriteLine("Original Array:");
        PrintArray(arr); // print the original unsorted array

        RadixSort(arr); // sort the array using Radix Sort

        Console.WriteLine("\nSorted Array:");
        PrintArray(arr); // print the sorted array
    }

    public static void RadixSort(int[] arr)
    {
        int maxVal = GetMaxValue(arr); // find the maximum value in the array

        for (int exp = 1; maxVal / exp > 0; exp *= 10)
        {
            CountSort(arr, exp); // sort the array at each exponent position
        }
    }

    public static void CountSort(int[] arr, int exp)
    {
        int[] output = new int[arr.Length]; // create an output array to store the sorted elements
        int[] count = new int[10]; // create a count array to store the frequency of each digit

        for (int i = 0; i < arr.Length; i++)
        {
            int digit = (arr[i] / exp) % 10; // find the digit at the current exponent position
            count[digit]++; // increment the frequency of the digit
        }

        for (int i = 1; i < 10; i++)
        {
            count[i] += count[i - 1]; // calculate the cumulative frequency of each digit
        }

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            int digit = (arr[i] / exp) % 10; // find the digit at the current exponent position
            output[count[digit] - 1] = arr[i]; // place the element in the output array at the correct position
            count[digit]--; // decrement the frequency of the digit
        }

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = output[i]; // copy the sorted output array back to the original array
        }
    }

    public static void PrintArray(int[] arr)
    {
        foreach (int elem in arr)
        {
            Console.Write(elem + " "); // print each element of the array to the console
        }
        Console.WriteLine();
    }

    public static int GetMaxValue(int[] arr)
    {
        int maxVal = arr[0]; // assume the first element is the maximum value
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > maxVal)
            {
                maxVal = arr[i]; // update the maximum value if a larger value is found
            }
        }
        return maxVal;
    }
}
