using System;

public class Solution
{
    public static void Main()
    {
        string s = Console.ReadLine();
        xml(s, 0);
    }
    public static void xml(string s,int h)
    {
        if (s != "")
        { 
            //выделяем первый элемент
            int ind = s.IndexOf('>') + 1;
            string a1 = s.Substring(0, ind);
            //смотрим у этого элемента наличие /
            string a2 = a1.Substring(1, 1);
            if (a2 != "/")
            {//если это открывающий
                Console.WriteLine(new string(' ', h*2) + a1);//то выводим
                xml(s.Substring(ind, s.Length - ind), ++h);//и вызываем рекурсивно от остальной строки с повышением ранга
            }
            else
            {//если закрывающая , то понижаем ранг
                h--;
                Console.WriteLine(new string(' ', h*2) + a1);//выводим
                xml(s.Substring(ind, s.Length - ind), h);//и вызываем след

            }
        }

    }
}