using System;

public class Solution
{
    public static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        int[] x = new int[n];
        
        string[] s = Console.ReadLine().Split(' ');

        //переводим в инт
        for (int i = 0; i < n; i++)
        {
            x[i] = Int32.Parse(s[i]);
        }
        int nP = Int32.Parse(Console.ReadLine());
        int[] xN = new int[nP];
        for (int i=0; i<nP;i++)
        {
            string[] sP = Console.ReadLine().Split(' ');
            int a = Int32.Parse(sP[0]);
            int b = Int32.Parse(sP[1]);
            int min = int.MaxValue;//устанавливаем мин=макс
            
            for (int j = a - 1; j < b; j++)
            {
                if (x[j] < min) min = x[j];
            }
            xN[i] = min;
        }
        for (int i = 0; i < nP; i++)
        {
           Console.WriteLine(xN[i]);
        }
        
    }
}