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
        
        //для каждой цифры
        for (int i = 0; i < 5; i++)
        {
            int k = 0;//пройдем по массиву
            for (int j = 0; j < n; j++)
            {
                if (x[j] == i)  k++;//считаем кол-во
            }//если не 0 выводим
            if (k!=0) Console.WriteLine("{0} {1}",i,k);
        }
        
    }
}
