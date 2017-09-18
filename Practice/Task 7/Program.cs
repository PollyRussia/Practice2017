using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static List<Tree> l = new List<Tree>();
        static List<string> s = new List<string>();
        public static void Main(string[] args)
        {
            Console.WriteLine("Задание 7");
            Console.WriteLine("Введите кол-во элементов");
            int n = VVODN(); // проверка на 0 и на отрицательные плюс проверка ввода
            Console.WriteLine("Поочередно введите все элементы в формате 0,0...");
            for (int i = 0; i < n; i++)
                l.Add(new Tree(VVOD(i))); // читаем и сразу добавляем
            while (l.Count > 1)
            {
                Tree min1 = Min(), min2 = Min(); // определяются две наименьшие частоты в списке и удаление элементов из списка
                Tree elem = new Tree(min1.frequency + min2.frequency); // над наименьшими элементами надстраивается новый
                elem.left = min1; elem.right = min2;
                l.Add(elem);
            }
            Tree head = l[0];
            if (head.frequency != 1)
                Console.WriteLine("Программа вынуждена завершить работу в связи с тем, что сумма всех частот не равна 1");
            else
            {
                MakeKey(ref head);
                s.Sort();
                Console.WriteLine();
                Console.WriteLine("Полученные слова Хаффмана:");
                foreach (string str in s)
                    Console.Write(str + " ");
            }
            Console.ReadLine();
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
       
        static double VVOD(int k)
        {
            double value;
            bool rightValue;
            Console.WriteLine("Введите частоту элемента " + (k + 1));
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
