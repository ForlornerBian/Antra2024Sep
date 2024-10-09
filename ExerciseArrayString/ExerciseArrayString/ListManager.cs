namespace ExerciseArrayString
{
    public class ListManager
    {
        public static void Run()
        {
            Console.WriteLine("Array Question 2: list manager");
            List<string> list = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, -- to clear, or 'exit' to quit):");
                string input = Console.ReadLine().Trim();  // Trim leading/trailing whitespace

                // Exit command
                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting the list manager...");
                    break; // Break out of the loop and end the program
                }

                // Clear the list when "--" is entered
                if (input == "--")
                {
                    list.Clear(); // Clear the list
                    Console.WriteLine("List cleared.");
                }
                // Add an item when input starts with "+"
                else if (input.StartsWith("+"))
                {
                    list.Add(input.Substring(2).Trim()); // Add item (ensure input is trimmed)
                }
                // Remove an item when input starts with "-"
                else if (input.StartsWith("-"))
                {
                    list.Remove(input.Substring(2).Trim()); // Remove item (ensure input is trimmed)
                }

                // Display the current list
                Console.WriteLine("Current list: " + (list.Count > 0 ? string.Join(", ", list) : "The list is empty."));
            }
        }
    }
}
