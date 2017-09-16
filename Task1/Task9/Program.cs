using System;

namespace Task9
{
    class MainClass
    {
        //В программе построен циклический список. 
        //Напишите процедуру подсчета двух сумм: всех положительных и всех отрицательных значений,
        //записанных в информационные поля элементов списка.
        public static void Main(string[] args)
        {
            Console.WriteLine("Задание 9");
            Console.WriteLine("Введите кол-во элементов (целое число)");
            int n = VVODN();
            Console.WriteLine("Если вы хотите ввести элементы вручную, нажмите 1. В противном случае элементы будут сгенерированы автоматически.");
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("Введите 1 элемент (действительное число)");
                Mas a = new Mas(VVOD());
                for (int i = 2; i <= n; i++)
                {
                    Console.WriteLine("Введите " + i + " элемент (действительное число)");
                    a = new Mas(VVOD(), a);
                }
            }
            else
            {
                Random rand = new Random();
                Mas a = new Mas(rand.NextDouble() + rand.Next(-100, 100));
                for (int i = 1; i < n; i++)
                    a = new Mas(rand.NextDouble() + rand.Next(-100, 100), a);
                Console.WriteLine("Сгенерированные элементы:");
                for (int i = 0; i < Mas.kol; i++)
                {
                    //Console.Write(a.elem  + " ");
                    Console.Write("{0:0.00}  ", a.elem);
                    a = a.next;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Сумма положительных элементов: " + Mas.GoodElem);
            Console.WriteLine("Сумма отрицательных элементов: " + Mas.BadElem);
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
