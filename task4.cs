
using System;

public class Solution
{
    public static void Main()
    {        
        int a = Int32.Parse(Console.ReadLine());
        if ((a % 4 == 0 && a % 100 != 0) || a % 400 == 0)
           Console.WriteLine(1);
        else Console.WriteLine(0);
    }
}