namespace ExerciseOOP
{
    public class ArrayReversal
    {
        // Method to generate an array of numbers
        public static int[] GenerateNumbers(int length)
        {
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                numbers[i] = i + 1;
            }
            return numbers;
        }

        // Method to reverse the array
        public static void Reverse(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[length - i - 1];
                array[length - i - 1] = temp;
            }
        }

        // Method to print the array
        public static void PrintNumbers(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
