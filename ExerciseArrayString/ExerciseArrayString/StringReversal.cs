namespace ExerciseArrayString
{
    public class StringReversal
    {
        public static void Run()
        {
            Console.WriteLine("String Question 1: string reversal");
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Using char array
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine("Reversed (char array): " + new string(charArray));

            // Using for loop
            Console.Write("Reversed (for loop): ");
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }
    }
}