// A hash table is a data structure that stores key-value pairs,
// where each key is hashed into a unique index of an array,
// and the corresponding value is stored at that index.
// Hash tables are implemented using the System.Collections.Generic.Dictionary<TKey, TValue> class,
// which provides methods for adding, removing, and accessing key-value pairs.

namespace HashTableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> table = new Dictionary<string, int>();

            table.Add("apple", 3);
            table.Add("banana", 2);
            table.Add("orange", 5);

            Console.WriteLine("Table elements:");
            foreach (KeyValuePair<string, int> pair in table)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }

            Console.ReadLine();
        }
    }
}

