using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        int[] x = new int[n];
        string[] s = Console.ReadLine().Split(' ');
        int l, r;
        //переводим в инт
        for (int i = 0; i < n; i++)
        {
            x[i] = Int32.Parse(s[i]);
        }
        //переменные для максимальных зн
        int max = 0;
        int lm = 0;
        int rm = 0;
        //перебор первых элементов подпослед
        for (l = 0; l < n - 1; l++)
        {//если у него и следующего разница >1 сразу идем дальше  иначе
            if (x[l]==x[l+1]||Math.Abs(x[l]-x[l+1])==1)
            { //начиная о последующего элемента
                r = l + 1;
                int st = x[l];
                int len = 0;
                var list = new List<int>();//список уникальных чисел в последовательности
                var ne = new List<int>();
                list.Add(x[l]);//добавим в него первый
                while (r<n&&(x[r] == st || Math.Abs(x[r] - st) == 1))//пока не достигнем конца будем проверять элементы на разницу с первым <2
                {
                    list.Add(x[r]);//добавим его в список
                    ne = list;
                    if (ne.Distinct().Count()<=2 )//если удалив дубликаты у нас <2 элементов
                    {
                        r++;//тогда двигаемся дальше
                        len++;
                    }
                    else break;//иначе выходим
                }
                if (len > max) //проверяем длину подпоследовательности
                { //если нужно запоминаем
                    max = len;
                    lm = l + 1;

                    rm = r;
                }
            }
        }

        Console.WriteLine("{0} {1}",lm,rm);//выводим
    }
}