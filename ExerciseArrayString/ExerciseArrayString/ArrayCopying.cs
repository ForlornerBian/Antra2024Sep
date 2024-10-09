namespace ExerciseArrayString
{
    public class ArrayCopying
    {
        public static void Run()
        {
            int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] copiedArray = new int[originalArray.Length];

            for (int i = 0; i < originalArray.Length; i++)
            {
                copiedArray[i] = originalArray[i];
            }

            Console.WriteLine("Array Question 1: copy an array");
            Console.WriteLine("Original Array: " + string.Join(", ", originalArray));
            Console.WriteLine("Copied Array: " + string.Join(", ", copiedArray));
        }
    }
}