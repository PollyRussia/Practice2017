using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8___Long_arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int degree = 200; // степень, в которую необходимо возвести 2
            List<int> arr = new List<int> { 1 }; //возводимое число - 2^0, представление - длинная арифметика
            for (int i = 1; i <= degree; i++)
                Degree(ref arr);
            arr.Reverse();
            foreach(int a in arr)
                Console.Write(a);
            Console.ReadLine();

        }
        static void Degree( ref List<int> arr) //функция удваивающая число
        {
            int c = arr.Count, k = 0;
            for (int i = 0; i < c; i++)
            {
                arr[i] = arr[i] * 2 + k;
                k = 0;
                if (arr[i] >= 10)
                {
                    k = 1;
                    arr[i] = arr[i] - 10;
                }
            }
            if (k == 1)
                arr.Add(1);
        }
    }
}
