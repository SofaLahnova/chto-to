using System;

public class Solution
{
    public static void Main()
    {
        int a = Int32.Parse(Console.ReadLine());
        int n = 0;
        for (int i = 2; i <= a; i = i * 2)
            if (a % i == 0)
                n++;
            else break;
        Console.WriteLine(n);
    }
}