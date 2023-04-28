// An array is a data structure that stores a collection of elements of the same type,
// with each element identified by an index or a position within the array.
// Arrays are declared using square brackets ([]) after the element type,
// and the length of the array is fixed at the time of declaration.

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            Console.WriteLine("Array elements:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();
        }
    }
}
