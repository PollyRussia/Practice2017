using System;
using System.Collections.Generic;

namespace Task_7
{
    class Program
    {
        static List<Tree> l = new List<Tree>();
        static List<string> s = new List<string>();
        public static void Main(string[] args)
        {
            print("Введите кол-во элементов");
            int n = inputInt(); // проверка на 0 и на отрицательные плюс проверка ввода
            print("Поочередно введите все элементы в формате 0,0...");
            for (int i = 0; i < n; i++)
                l.Add(new Tree(inputD())); // читаем и сразу добавляем
            while (l.Count > 1)
            {
                Tree min1 = Min(), min2 = Min();
                Tree elem = new Tree(min1.frequency + min2.frequency);
                elem.left = min1; elem.right = min2;
                l.Add(elem);
            }
            Tree head = l[0];
            MakeKey(ref head);
            s.Sort();
            Console.WriteLine();
            foreach (string str in s)
                Console.Write(str + " ");
        }
        static Tree Min()
        {
            Tree min = l[0];// необходимо ли здесь глубинное копирование?
            foreach (Tree x in l)
                if (x.frequency < min.frequency)
                    min = x; // ????????????????
            l.Remove(min);
            return min;
        }
        
        static void MakeKey(ref Tree x) // определение кода числа и добавление его в список слов
        {
            if (x != null)
            {
                if (x.left != null)
                {
                    x.left.key = x.key + "1";
                    MakeKey(ref x.left);
                }
                if (x.right != null)
                {
                    x.right.key = x.key + "0";
                    MakeKey(ref x.right);
                }
                if (x.left == null && x.right == null)
                    s.Add(x.key);
            }
        }
        static void PrintTree(Tree x) // дополнительная функция проверки дерева
        {
            if (x != null)
            {
                Console.Write(" " + x.frequency);
                if (x.left == null && x.right == null)
                    Console.Write("*");
                else
                {
                    PrintTree(x.left);
                    PrintTree(x.right);
                }
            }
        }
        static void print(string a)
        {
            Console.WriteLine();
            Console.WriteLine(a);
        }
        static double inputD()
        {
            //string s = Console.ReadLine(); //Нужна проверка ввода
            return Convert.ToDouble(Console.ReadLine());
        }
        static int inputInt()
        {
            //string s = Console.ReadLine(); 
            //int k = Convert.ToInt32(Console.ReadLine());//Нужна проверка ввода
            return Convert.ToInt32(Console.ReadLine()); // вспомнить, как ловить исключения, в общем
        }
    }
}
