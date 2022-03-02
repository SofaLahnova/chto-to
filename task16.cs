using System;

public class Solution
{
    public static void Main()
    {
        string[] line = Console.ReadLine().Split(' ');
        int a = Int32.Parse(line[0]);
        int b = Int32.Parse(line[1]);
        int c = Int32.Parse(line[2]);
        int q = b * b - 4 * a * c;
        if (q > 0) Console.WriteLine(2);
        if (q == 0) Console.WriteLine(1);
        if (q < 0) Console.WriteLine(0);
    }
}