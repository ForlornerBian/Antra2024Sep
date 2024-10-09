// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Console.Write("What's your favorite color? ");
string favoriteColor = Console.ReadLine();
        
Console.Write("What's your astrology sign? ");
string astrologySign = Console.ReadLine();
        
Console.Write("What's the number of the street you live on? ");
string streetNumber = Console.ReadLine();

string hackerName = favoriteColor + astrologySign + streetNumber;
        
// Display the hacker name
Console.WriteLine("Your hacker name is " + hackerName + ".");