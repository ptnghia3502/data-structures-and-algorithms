public class RecursionExample
{
    public static void Main()
    {
        int num = 5; // number whose factorial to compute
        int result = Factorial(num); // call the recursive Factorial function
        Console.WriteLine("The factorial of " + num + " is " + result);
    }

    public static int Factorial(int n)
    {
        if (n == 0)
        { // base case: factorial of 0 is 1
            return 1;
        }
        else
        { // recursive case: multiply n by the factorial of n-1
            return n * Factorial(n - 1);
        }
    }
}
