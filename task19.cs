using System;

public class Solution
{
    public static void Main()
    {
        int a = Int32.Parse(Console.ReadLine());
        int k = 1;
        for (int i = 1; ;)
            if (i + k > a) break;
            else
            {
                i = i + k;
                k++;                
            }
         Console.WriteLine(k);
    }
}