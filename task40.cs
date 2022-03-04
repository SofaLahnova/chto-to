using System;

public class Solution
{
    public static void Main()
    {
        string s = Console.ReadLine();       
        Console.WriteLine(min_cyclic_shift(s));
    }
    public static string min_cyclic_shift(string s)
    {
        s += s;//продублируем строку
        int n = (int)s.Length;
        int i = 0, ans = 0;
        //найдем в первой половине начало новой строки
        while (i < n / 2)
        {
            ans = i;
            int j = i + 1, k = i;
            while (j < n && s[k] <= s[j])
            {
                if (s[k] < s[j])
                    k = i;
                else
                    ++k;
                ++j;
            }
            while (i <= k) i += j - k;
        }
        return s.Substring(ans, n / 2);
    }
}