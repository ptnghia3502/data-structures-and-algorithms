namespace HeapExample
{
    class Program
    {
        public class MaxHeap
        {
            private List<int> heap;

            public MaxHeap()
            {
                heap = new List<int>();
            }

            public void Insert(int value)
            {
                heap.Add(value);
                int currentIndex = heap.Count - 1;
                while (currentIndex > 0 && heap[currentIndex] > heap[(currentIndex - 1) / 2])
                {
                    int parentIndex = (currentIndex - 1) / 2;
                    int temp = heap[currentIndex];
                    heap[currentIndex] = heap[parentIndex];
                    heap[parentIndex] = temp;
                    currentIndex = parentIndex;
                }
            }

            public int ExtractMax()
            {
                if (heap.Count == 0)
                {
                    throw new InvalidOperationException("Heap is empty");
                }

                int max = heap[0];
                heap[0] = heap[heap.Count - 1];
                heap.RemoveAt(heap.Count - 1);

                int currentIndex = 0;
                while (true)
                {
                    int leftChildIndex = 2 * currentIndex + 1;
                    int rightChildIndex = 2 * currentIndex + 2;

                    if (leftChildIndex >= heap.Count)
                    {
                        break;
                    }

                    int maxChildIndex = leftChildIndex;
                    if (rightChildIndex < heap.Count && heap[rightChildIndex] > heap[leftChildIndex])
                    {
                        maxChildIndex = rightChildIndex;
                    }

                    if (heap[currentIndex] < heap[maxChildIndex])
                    {
                        int temp = heap[currentIndex];
                        heap[currentIndex] = heap[maxChildIndex];
                        heap[maxChildIndex] = temp;
                        currentIndex = maxChildIndex;
                    }
                    else
                    {
                        break;
                    }
                }

                return max;
            }

            public int Count
            {
                get { return heap.Count; }
            }
        }

        static void Main(string[] args)
        {
            MaxHeap heap = new MaxHeap();

            heap.Insert(5);
            heap.Insert(10);
            heap.Insert(3);
            heap.Insert(8);

            Console.WriteLine("Heap elements:");
            while (heap.Count > 0)
            {
                int max = heap.ExtractMax();
                Console.WriteLine(max);
            }

            Console.ReadLine();
        }

    }
}