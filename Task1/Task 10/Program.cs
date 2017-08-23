using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        static Mas newarr = null; //возводимое число - 2^0, представление - длинная арифметика
        static void Main(string[] args)
        {// читаем n
         // читаем все элементы и загружаем в динамический массив
         // сохраняем начало и конец массива
         // указываем двойное условие и идем с двух концов массива
            Console.WriteLine("Введите кол-во элементов (целое число)");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите 1 элемент (действительное число)");
            newarr = new Mas(Double.Parse(Console.ReadLine()));
            Mas head = newarr;
            for (int i = 2; i <= n; i++)
            {
                Console.WriteLine("Введите " + i + " элемент (действительное число)");
                newarr.next = new Mas(Double.Parse(Console.ReadLine()), newarr);
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
    }
}
