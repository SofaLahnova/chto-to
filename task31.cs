using System;
using System.Linq;

public class Solution
{
   
    public static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        int[] x = new int[n];
        string[] s = Console.ReadLine().Split(' ');
        string[] str;
        //переводим в инт
        for (int i = 0; i < n; i++)
        {
            x[i] = Int32.Parse(s[i]);
        }
        //найдем элементы
        var s1 = (from x1 in x
                  where x.Count(y => x1 == y) > 1//где кол-во больше 1
                  select x1).Distinct();//отберем их иудалим дубликаты
        //выводим кол-во
        Console.WriteLine(s1.Count());
        //объединяя в строку выводим
        Console.WriteLine(String.Join(" ", s1));
       

    }
}
