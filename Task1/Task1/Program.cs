using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static long n, w, e;
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            StreamWriter sw = new StreamWriter("output.txt");
            string[] s = sr.ReadLine().Split();
            n = long.Parse(s[0]);
            w = long.Parse(s[1]);
            e = long.Parse(s[2]);
            long sum = 0;
            for (long i = 1; i <= n; i++)
                for (long j = 1; j <= n; j++)
                {
                    long x1 = 100 * i - 100, x2 = 100 * i, y1 = 100 * j - 100, y2 = 100 * j, y = Y(x1);
                    if ((y - y1) * (y - y2) > 0)
                    {
                        y = Y(x2);
                        if ((y - y1) * (y - y2) <= 0)
                            sum++;
                    }
                    else sum++;
                }
            sw.WriteLine(sum + "");
            sr.Close();
            sw.Close();
        }

        static long Y(long x)
        {
        return w  + x * (e - w) / (100 * n);
        }
    }
}



