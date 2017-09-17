using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // read or genirate
            //Дана действительная квадратная матрица порядка n. 
            //Найти наибольшее из значений элементов, расположенных в заштрихованной части матрицы 
            // read M
            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите размерность матрцы (целое число)");
            int n = VVODN();
            double[,] M = new double[n, n];
            Console.WriteLine("Если вы хотите ввести элементы вручную, нажмите 1. В противном случае элементы будут сгенерированы автоматически.");
            if (Console.ReadLine() == "1")
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine("Введите (" + i + "," + j + ") элемент (действительное число)");
                        M[i, j] = VVOD();
                    }
                }
                //вывести всю матрицу
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i <= j)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("{0:0.00}  ", M[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                            Console.Write("{0:0.00}  ", M[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {//genirate M:
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
                    }
                    Console.WriteLine();
                }
            }

            double max = M[0, 0];
            for (int i = 0; i < n; i++)
                for (int j = i; j < n; j++)
                    if (i <= j && M[i, j] > max)
                        max = M[i, j];
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Наибольшее из значений, расположенных в заштрихованной части:");
            Console.WriteLine("              {0:0.00}", max);
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
