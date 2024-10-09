namespace _02UnderstandingTypes;

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Practice 1: ");
        Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "Type", "Size (Bytes)", "Min Value", "Max Value");
        Console.WriteLine(new string('-', 100));

        Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
        Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "short", sizeof(short), short.MinValue, short.MaxValue);
        Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
        Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "int", sizeof(int), int.MinValue, int.MaxValue);
        Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
        Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "long", sizeof(long), long.MinValue, long.MaxValue);
        Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
        Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "float", sizeof(float), float.MinValue, float.MaxValue);
        Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "double", sizeof(double), double.MinValue, double.MaxValue);
        Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
        
        Console.WriteLine("Practice 2: ");
        Console.Write("Enter number of centuries: ");
        int centuries = int.Parse(Console.ReadLine());

        // Conversions
        int years = centuries * 100;
        long days = (long)(years * 365.2422); // average days per year, accounting for leap years
        long hours = days * 24;
        long minutes = hours * 60;
        long seconds = minutes * 60;
        long milliseconds = seconds * 1000;
        long microseconds = milliseconds * 1000;
        long nanoseconds = microseconds * 1000;

        // Output the result
        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    }
}