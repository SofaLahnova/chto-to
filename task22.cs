using System;

public class Solution
{
    public static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        int[] x = new int[n];
        string[] s = Console.ReadLine().Split(' ');
        
        //переводим в инт и находим минимум
        for (int i = 0; i < n; i++)
        {
            x[i] = Int32.Parse(s[i]);
        }
        //считаем кол-во
        int k = 0;
        for (int i = 0; i < n; i++)
            for(int j=0;j<n;j++)
        {
                if(i!=j)
                  if (x[j] % x[i] ==0) k++;
        }
        Console.WriteLine(k);
    }
}