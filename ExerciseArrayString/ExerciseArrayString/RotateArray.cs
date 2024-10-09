namespace ExerciseArrayString
{
    public class RotateArray
    {
        public static void Run()
        {
            // Get array input from the user
            Console.WriteLine("Array Question 4: array rotation");
            Console.WriteLine("Enter the array elements separated by comma and space (e.g., 3, 2, 4, -1): ");
            string input = Console.ReadLine();

            // Convert input string to an array of integers
            int[] array = input.Split(new[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToArray();
            int arrayLength = array.Length;

            // Ask for number of rotations
            int rotations;
            while (true)
            {
                Console.WriteLine($"Enter the number of rotations (must be less than {arrayLength}): ");
                rotations = int.Parse(Console.ReadLine());

                // Ensure the rotations are less than the array length
                if (rotations < arrayLength)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Invalid input! Number of rotations must be less than the length of the array ({arrayLength}).");
                }
            }

            // Array to store the sum of rotations
            int[] sumArray = new int[arrayLength];

            // Perform rotations and sum the arrays
            for (int r = 1; r <= rotations; r++)
            {
                int[] rotatedArray = new int[arrayLength];
                for (int i = 0; i < arrayLength; i++)
                {
                    rotatedArray[(i + r) % arrayLength] = array[i];
                }

                // Sum the rotated arrays
                for (int i = 0; i < arrayLength; i++)
                {
                    sumArray[i] += rotatedArray[i];
                }
            }

            // Output the result
            Console.WriteLine("Sum of rotated arrays: ");
            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
