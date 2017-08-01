using System;
using System.IO;

namespace Task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            decimal n, w, e;
            string[] s = Console.ReadLine().Split();
            n = decimal.Parse(s[0]);
            w = decimal.Parse(s[1]);
            e = decimal.Parse(s[2]);
            decimal sum = 0;
            for (decimal i = 1; i <= n; i++)
                for (decimal j = 1; j <= n; j++)
                {
                    decimal x1 = 100 * i - 100, x2 = 100 * i, y1 = 100 * j - 100, y2 = 100 * j, y = w + x1 * (e - w) / (100 * n); ;
                    if ((y - y1) * (y - y2) > 0)
                    {
                        y = w + x2 * (e - w) / (100 * n);
                        if ((y - y1) * (y - y2) <= 0)
                            sum++;
                    }
                    else sum++;
                }
            Console.WriteLine(sum + "");
        }
    }
}



