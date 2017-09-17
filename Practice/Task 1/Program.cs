using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*В прямоугольной декартовой системе координат прямая задана двумя принадлежащими ей точками (0, W) и (100•N, E). 
            Также заданы N2 квадратов со сторонами, параллельными осям координат. 
            Квадрат Si,jимеет координаты углов (100•i, 100•j) и (100•i - 100, 100•j - 100), i, j = 1, 2, ..., N.
            Требуется найти количество квадратов, имеющих общую точку с прямой.*/
            //Console.WriteLine("Задание 1");
            //Console.WriteLine("Введите через пробел n w e");
            decimal n, w, e; // входные данные
            string[] s = Console.ReadLine().Split();
            n = decimal.Parse(s[0]);
            w = decimal.Parse(s[1]);
            e = decimal.Parse(s[2]);
            decimal sum = 0;
            for (decimal i = 1; i <= n; i++)
                for (decimal j = 1; j <= n; j++)
                {
                    decimal x1 = 100 * i - 100, x2 = 100 * i, y1 = 100 * j - 100,
                        y2 = 100 * j, y = w + x1 * (e - w) / (100 * n);
                    if ((y - y1) * (y - y2) > 0)
                    {
                        y = w + x2 * (e - w) / (100 * n);
                        if ((y - y1) * (y - y2) <= 0)
                            sum++;
                    }
                    else sum++;
                }
            //Console.WriteLine("Количество квадратов, имеющих общую точку с прямой:");
            Console.WriteLine(sum); // выходные данные
            Console.ReadLine();
        }
    }
}
