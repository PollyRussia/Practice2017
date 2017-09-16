using System;

namespace Task6
{
    class Program
    {

        static int M, N, m, n;
        public static void Main(string[] args)
        {
            Console.WriteLine("Задание 6");
            //print("Введите а1 а2 а3 М, N через пробел (целые числа, М, N - натуральные)");
            //string[] s = Console.ReadLine().Split(' ');
            //M = Convert.ToInt32(s[3]); N = Convert.ToInt32(s[4]);
            M = VVODN("M"); N = VVODN("N");
            m = 0; n = 3;
            int a1 = VVOD("a1"), a2 = VVOD("a2"), a3 = VVOD("a3");
            Console.WriteLine("Последовательность:");
            p(a1); p(a2); p(a3);
            if (a1 % 3 == 0) m++;
            if (a2 % 3 == 0) m++;
            if (a3 % 3 == 0) m++;
            //Rec(Convert.ToInt32(s[0]), Convert.ToInt32(s[1]), Convert.ToInt32(s[2]));
            if (n >= N)
                print("Построены первые N элементов последовательности");
            if (m >= M)
                print("Найдены первы M элементов, кратные трем.");
            if (m < M && n < N)
                Rec(a1, a2, a3);
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
        static int VVODN(string s)
        {
            int value;
            bool rightValue;
            Console.WriteLine("Введите натуральное число " + s);
            do
            {
                string inputValue = Console.ReadLine();
                rightValue = int.TryParse(inputValue, out value);
                if (!rightValue || value < 1)
                {
                    Console.WriteLine("Неверное значение, ожидалось натуральное число. повторите.");
                }
            }
            while (!rightValue || value < 1);
            return value;
        }
        static int VVOD(string s)
        {
            int value;
            bool rightValue;
            Console.WriteLine("Введите целое число " + s);
            do
            {
                string inputValue = Console.ReadLine();
                rightValue = int.TryParse(inputValue, out value);
                if (!rightValue)
                {
                    Console.WriteLine("Неверное значение, ожидалось целое число. повторите.");
                }
            }
            while (!rightValue || value < 1);
            return value;
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

