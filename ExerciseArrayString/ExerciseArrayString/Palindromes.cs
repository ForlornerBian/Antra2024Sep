using System.Text.RegularExpressions;

namespace ExerciseArrayString
{
    public class Palindromes
    {
        public static void Run()
        {
            // Get input from the user
            Console.WriteLine("String Question 3: extract palindromes from the input");
            Console.WriteLine("Enter a sentence: ");
            string input = Console.ReadLine();

            // Regex to extract words from the sentence
            string pattern = @"[a-zA-Z0-9]+";

            // Use HashSet to store unique palindromes
            HashSet<string> palindromes = new HashSet<string>();

            foreach (Match match in Regex.Matches(input, pattern))
            {
                string word = match.Value;
                if (IsPalindrome(word))
                {
                    palindromes.Add(word); // Only add exact palindromes (case-sensitive)
                }
            }

            // Print the unique palindromes
            Console.WriteLine("Palindromes found: ");
            Console.WriteLine(string.Join(", ", palindromes));
        }

        // Function to check if a word is a palindrome (case-sensitive)
        static bool IsPalindrome(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}