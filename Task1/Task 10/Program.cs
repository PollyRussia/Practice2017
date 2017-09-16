using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        static Mas newarr = null;
        static void Main(string[] args)
        {// читаем n
         // читаем все элементы и загружаем в динамический массив
         // сохраняем начало и конец массива
         // указываем двойное условие и идем с двух концов массива
            Console.WriteLine("Задание 10");
            Console.WriteLine("Введите кол-во элементов (целое число)");
            int n = VVODN();
            Console.WriteLine("Введите 1 элемент (действительное число)");
            newarr = new Mas(VVOD());
            Mas head = newarr;
            for (int i = 2; i <= n; i++)
            {
                Console.WriteLine("Введите " + i + " элемент (действительное число)");
                newarr.next = new Mas(VVOD(), newarr);
                newarr = newarr.next;
            }
            Mas tail = newarr;
            double sum = 1; // самый большой вещественный тип данных
            while (head != null || tail != null)
            {
                sum *= head.elem + tail.elem;
                head = head.next;
                tail = tail.last;
            }
            Console.Write("Результат, полученный по формуле (x1 + xn)(x2 + xn-1)...(xn + x1): " + sum);
            Console.ReadLine();
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
        static int VVODN()
        {
            int value;
            bool rightValue;
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
    }
}
