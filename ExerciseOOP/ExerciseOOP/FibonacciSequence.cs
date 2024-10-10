namespace ExerciseOOP
{
    public class FibonacciSequence
    {
        // Recursive method to calculate Fibonacci number
        public static int Fibonacci(int n)
        {
            // Base case: The 1st and 2nd numbers are 1
            if (n == 1 || n == 2)
            {
                return 1;
            }

            // Recursive case: Fibonacci(n) = Fibonacci(n-1) + Fibonacci(n-2)
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        // Method to print the first 'count' Fibonacci numbers
        public static void PrintFirstNFibonacci(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"Fibonacci({i}) = {Fibonacci(i)}");
            }
        }
    }
}
