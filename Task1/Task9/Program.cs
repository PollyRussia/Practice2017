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
            int n = 10;
            Random rand = new Random();
            Mas a = new Mas(rand.NextDouble() + rand.Next(-100, 100));
            for (int i = 1; i < n; i++)
                a = new Mas(rand.NextDouble() + rand.Next(-100, 100), a);
            for (int i = 0; i < Mas.kol; i++)
            {
                Console.Write(a.elem + " ");
                a = a.next;
            }
            Console.WriteLine();
            Console.WriteLine(Mas.GoodElem);
            Console.WriteLine(Mas.BadElem);
            Console.ReadLine();

        }
    }
}
