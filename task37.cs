using System;
using System.Collections.Generic;

public class Solution
{
    public static void Main()
    {
        
        string[] s = Console.ReadLine().Split(',');
        int n = Int32.Parse(Console.ReadLine());
        var list = new List<string>();
        for (int i = 0; i < s.Length; i++)
            if (s[i].Length >= n)
                list.Add(s[i]);
        Console.WriteLine(String.Join(",", list));
    }
}