// A queue is a data structure that follows the First-In-First-Out (FIFO) principle
// which means that the first item enqueued into the queue is the first item dequeued from the queue.

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("Queue elements:");
            while (queue.Count > 0)
            {
                int element = queue.Dequeue();
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }
    }
}