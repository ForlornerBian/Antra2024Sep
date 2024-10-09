using System.Text.RegularExpressions;

namespace ExerciseArrayString
{
    public class WordReversal
    {
        public static void Run()
        {
            // Get sentence input from the user
            Console.WriteLine("String Question 2: word reversal");
            Console.WriteLine("Enter a sentence: ");
            string input = Console.ReadLine();

            // Regex pattern to match words with special characters and separators
            string pattern = @"[a-zA-Z0-9\#\+\-]+|[.,:;=\(\)&\[\]""'\\/!? ]";

            // Use Regex to separate the words and separators
            List<string> parts = new List<string>();
            foreach (Match match in Regex.Matches(input, pattern))
            {
                parts.Add(match.Value);
            }

            // List to store words and reverse only the words
            List<string> words = new List<string>();
            for (int i = 0; i < parts.Count; i++)
            {
                if (Regex.IsMatch(parts[i], @"[a-zA-Z0-9\#\+\-]+")) // Matches words (including special characters like #, +, -)
                {
                    words.Add(parts[i]);
                }
            }

            // Reverse the list of words
            words.Reverse();

            // Replace words in the original structure
            int wordIndex = 0;
            for (int i = 0; i < parts.Count; i++)
            {
                if (Regex.IsMatch(parts[i], @"[a-zA-Z0-9\#\+\-]+"))
                {
                    parts[i] = words[wordIndex];
                    wordIndex++;
                }
            }

            // Join the parts back together and print the reversed sentence
            Console.WriteLine("Reversed sentence: ");
            Console.WriteLine(string.Join("", parts));
        }
    }
}