using System;

public class Solution
{
    public static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        int[] x = new int[n];
        string[] s = Console.ReadLine().Split(' ');        
        int min = int.MaxValue;//устанавливаем мин=макс
        //переводим в инт и находим минимум
        for (int i=0;i<n;i++)
        {
           x[i]= Int32.Parse(s[i]);
            if (x[i] < min) min = x[i];
        }
        //считаем кол-во
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            if (x[i] == min) k++;
        }
        Console.WriteLine(k);
    }
}