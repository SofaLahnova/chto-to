using System;

public class Solution
{
    public static void Main()
    {
        string[] line = Console.ReadLine().Split(' ');
        int a = Int32.Parse(line[0]);
        int b = Int32.Parse(line[1]);
        int n = 0;
        while ((a != 0) && (b != 0))
        {
            n++;
            if (a > b)
                a -= b;
            else
                b -= a;
        }

        Console.WriteLine("{0} {1}", n, Math.Max(a,b));
    }
}