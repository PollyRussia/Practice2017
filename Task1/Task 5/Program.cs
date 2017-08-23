using System;

namespace Task_5
{
    class Program
    {
        static int n = 5;
        static double[,] M = new double[n, n];
        static void Main(string[] args)
        {
            // read or genirate
            //genirate M:
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    M[i, j] = rand.NextDouble() + rand.Next(0, 10);
                    if (i <= j)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0:0.00}  ", M[i, j]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    Console.Write("{0:0.00}  ", M[i, j]);
                } p();
            }
            double max = M[0, 0];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (i <= j && M[i, j] > max)
                        max = M[i, j];
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("              {0:0.00}", max);
            input();
            // output
        }
        static void print(string s)
        {
            Console.Write(s + " ");
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
