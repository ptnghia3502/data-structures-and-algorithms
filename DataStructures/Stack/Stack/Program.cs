// A stack is a data structure that follows the Last-In-First-Out (LIFO) principle
// which means that the last item pushed onto the stack is the first item popped off the stack.

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Stack elements:");
            while (stack.Count > 0)
            {
                int element = stack.Pop();
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }
    }
}