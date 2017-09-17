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
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите значение x (ожидается действительное число)");
            double x = VVOD();
            Console.WriteLine("Введите значение y (ожидается действительное число)");
            double y = VVOD();
            Console.WriteLine("Данная точка принадлежит заштрихованной части плоскости?");
            if (IsPointInSquare(x, y))
                Console.WriteLine("Да");
            else
                Console.WriteLine("Нет");
            Console.ReadLine();
        }
        static bool IsPointInSquare(double x1, double y1)
        {
            return (Math.Abs(y1) <= -Math.Abs(x1) + 1);
        }
        static double VVOD()
        {
            double value;
            bool rightValue;
            do
            {
                string inputValue = Console.ReadLine();
                rightValue = double.TryParse(inputValue, out value);
                if (!rightValue)
                {
                    Console.WriteLine("Неверное значение для дробного числа вида 0,0 , повторите.");
                }
            }
            while (!rightValue);
            return value;
        }
    }
}
