using System;
//using System.Collections.Generic;

namespace Task_8___Long_arithmetics
{
    class Program
    {
        static Mas newarr = new Mas(1); //возводимое число - 2^0, представление - длинная арифметика
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4");
            Console.WriteLine("2 в 200 степени =");
            int degree = 200; // степень, в которую необходимо возвести 2
            for (int i = 1; i <= degree; i++)
                Degree();
            while (newarr.next != null) newarr = newarr.next;
            while (newarr != null)
            {
                Console.Write(newarr.elem);
                newarr = newarr.last;
            }
            Console.ReadLine();
        }
        static void Degree() //функция удваивающая число
        {
            Mas head = newarr, first = newarr;
            int k = 0;
            while (newarr != null)
            {
                newarr.elem = newarr.elem * 2 + k;
                k = 0;
                if (newarr.elem >= 10)
                {
                    k = 1;
                    newarr.elem = newarr.elem - 10;
                }
                first = newarr;
                newarr = newarr.next;
            }
            if (k == 1)
                first.next = new Mas(1, first);
            newarr = head;
        }
       
    }
    // с List
    //static void Main(string[] args)
    //{
    //    int degree = 200; // степень, в которую необходимо возвести 2
    //    List<int> arr = new List<int> { 1 }; //возводимое число - 2^0, представление - длинная арифметика
    //    for (int i = 1; i <= degree; i++)
    //        Degree(ref arr);
    //    arr.Reverse();
    //    foreach (int a in arr)
    //        Console.Write(a);
    //    Console.ReadLine();

    //}
    //static void Degree(ref List<int> arr) //функция удваивающая число
    //{
    //    int c = arr.Count, k = 0;
    //    for (int i = 0; i < c; i++)
    //    {
    //        arr[i] = arr[i] * 2 + k;
    //        k = 0;
    //        if (arr[i] >= 10)
    //        {
    //            k = 1;
    //            arr[i] = arr[i] - 10;
    //        }
    //    }
    //    if (k == 1)
    //        arr.Add(1);
    //}
}

