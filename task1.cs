using System;

public class Solution
{
    public static void Main()
    {
        string[] line = Console.ReadLine().Split(' ');
        int a = Int32.Parse(line[0]);
        int b = Int32.Parse(line[1]);
        Console.WriteLine(a + b);
    }
}