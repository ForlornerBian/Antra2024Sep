namespace ExerciseArrayString
{
    public class UrlParsing
    {
        public static void Run()
        {
            // Get URL input from the user
            Console.WriteLine("String Question 4: parse an URL");
            Console.WriteLine("Enter a URL: ");
            string url = Console.ReadLine();

            // Parse the URL to extract protocol, server, and resource
            ParseUrl(url);
        }

        public static void ParseUrl(string url)
        {
            // Find the protocol, server, and resource
            var protocolEnd = url.IndexOf("://");
            var serverStart = protocolEnd == -1 ? 0 : protocolEnd + 3;
            var resourceStart = url.IndexOf("/", serverStart);

            // Extract the protocol, server, and resource
            string protocol = protocolEnd == -1 ? "" : url.Substring(0, protocolEnd);
            string server = resourceStart == -1 ? url.Substring(serverStart) : url.Substring(serverStart, resourceStart - serverStart);
            string resource = resourceStart == -1 ? "" : url.Substring(resourceStart + 1);

            // Display the results
            Console.WriteLine($"[protocol] = \"{protocol}\"");
            Console.WriteLine($"[server] = \"{server}\"");
            Console.WriteLine($"[resource] = \"{resource}\"");
        }
    }
}