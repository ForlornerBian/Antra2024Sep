namespace ExerciseArrayString
{
    public class LongestSequence
    {
        public static void Run()
        {
            // Get the array input from the user
            Console.WriteLine("Array Question 5: find the longest sequence");
            Console.WriteLine("Enter the array elements separated by space (e.g., 2 1 1 2 3 3 2 2 2 1): ");
            string input = Console.ReadLine();

            // Convert the input string to an array of integers
            int[] array = input.Split(' ').Select(int.Parse).ToArray();

            // Variables to track the longest sequence
            int maxLength = 1, currentLength = 1, start = 0;

            // Find the longest sequence of equal elements
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        start = i - currentLength;
                    }
                    currentLength = 1;
                }
            }

            // Check if the last sequence was the longest
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                start = array.Length - currentLength;
            }

            // Output the longest sequence
            Console.WriteLine("Longest sequence of equal elements:");
            Console.WriteLine(string.Join(" ", array[start..(start + maxLength)]));
        }
    }
}