using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            double x = Double.Parse(input());
            double y = Double.Parse(input());
            if (IsPointInSquare(x, y))
                print("YES");
            else
                print("NO");
            input();
        }
        static bool IsPointInSquare(double x1, double y1)
        {
            return (Math.Abs(y1) <= -Math.Abs(x1) + 1);
        }
        static void print(string s)
        {
            Console.WriteLine(s);
        }
        static void p()
        {
            Console.WriteLine();
        }
        static string input()
        {
            return Console.ReadLine();
        }
    }
}
