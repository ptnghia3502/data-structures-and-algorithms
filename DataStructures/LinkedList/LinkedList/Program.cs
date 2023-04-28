// A linked list is a data structure that consists of a sequence of elements,
// each of which contains a reference to the next element in the sequence.
// Linked lists can be implemented using the System.Collections.Generic.LinkedList<T> class,
// which provides methods for adding, removing, and accessing elements in the list.

namespace LinkedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

            Console.WriteLine("List elements:");
            foreach (int element in list)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }
    }
}

