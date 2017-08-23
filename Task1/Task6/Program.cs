using System;

namespace Task6
{
    class Program
    {

        static int M, N, m, n;
        public static void Main(string[] args)
        {
            print("Введите а1 а2 а3 М, N через пробел (целые числа, М, N - натуральные)");
            string[] s = Console.ReadLine().Split(' ');
            M = Convert.ToInt32(s[3]); N = Convert.ToInt32(s[4]);
            m = 0; n = 0;
            Rec(Convert.ToInt32(s[0]), Convert.ToInt32(s[1]), Convert.ToInt32(s[2]));
            Console.ReadLine();
        }
        static void Rec(int a1, int a2, int a3)
        {
            int ak = 2 * Math.Abs(a1 - a2) + a3;
            p(ak); n++;
            if (ak % 3 == 0) m++;
            if (n >= N)
                print("Построены первые Н элементов последовательности");
            if (m >= M)
                print("Найдены первы М элементов, кратные трем.");
            if (m < M && n < N)
                Rec(ak, a1, a2);

        }

        static void p(int a)
        {
            Console.Write(a + " ");
        }
        static void print(string a)
        {
            Console.WriteLine();
            Console.WriteLine(a);
        }
    }
}

