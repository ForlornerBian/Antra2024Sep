namespace ExerciseArrayString
{
    public class PrimeNumbers
    {
        public static void Run()
        {
            int startNum, endNum;
            Console.WriteLine("Array Question 3: find primes in range");

            // Try to get valid input for start number
            try
            {
                Console.Write("Enter the start number: ");
                startNum = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Start number must be an integer.");
                return; // Exit the function if input is invalid
            }

            // Try to get valid input for end number
            try
            {
                Console.Write("Enter the end number: ");
                endNum = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! End number must be an integer.");
                return; // Exit the function if input is invalid
            }

            // Ensure that the end number is greater than the start number
            if (endNum < startNum)
            {
                Console.WriteLine("End number must be greater than or equal to the start number.");
                return;
            }

            // Call the FindPrimesInRange method with validated input
            int[] primes = FindPrimesInRange(startNum, endNum);

            // Display the prime numbers found in the range
            if (primes.Length > 0)
            {
                Console.WriteLine("Prime numbers in the range:");
                Console.WriteLine(string.Join(", ", primes));
            }
            else
            {
                Console.WriteLine("No prime numbers found in the given range.");
            }
        }

        static int[] FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primes = new List<int>();

            for (int num = startNum; num <= endNum; num++)
            {
                bool isPrime = true;
                if (num < 2) isPrime = false;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) primes.Add(num);
            }

            return primes.ToArray();
        }
    }
}