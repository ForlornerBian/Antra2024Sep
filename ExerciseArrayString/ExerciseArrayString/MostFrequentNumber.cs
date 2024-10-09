namespace ExerciseArrayString
{
    public class MostFrequentNumber
    {
        public static void Run()
        {
            Console.WriteLine("Array Question 6: find the most frequent number");
            Console.WriteLine("Enter the array elements separated by space (e.g., 4 1 1 4 2 3 4 4 1 2 4 9 3 ): ");
            string input = Console.ReadLine();

            // Convert the input string to an array of integers
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (var num in array)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else
                {
                    frequency[num] = 1;
                }
            }

            // Find the maximal frequency
            int maxFrequency = frequency.Values.Max();

            // Find all numbers with the maximal frequency
            List<int> mostFrequentNumbers = frequency
                .Where(kvp => kvp.Value == maxFrequency)
                .Select(kvp => kvp.Key)
                .ToList();

            // Find the leftmost of the most frequent numbers in the original array
            int leftmostNumber = array.First(num => mostFrequentNumbers.Contains(num));

            // Output the result based on how many numbers have the maximal frequency
            if (mostFrequentNumbers.Count == 1)
            {
                // If only one number has the highest frequency
                Console.WriteLine($"The number {leftmostNumber} is the most frequent (occurs {maxFrequency} times).");
            }
            else
            {
                // If multiple numbers have the same highest frequency
                Console.WriteLine(
                    $"The numbers {string.Join(", ", mostFrequentNumbers)} have the same maximal frequency (each occurs {maxFrequency} times). The leftmost of them is {leftmostNumber}.");
            }
        }
    }
}