using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    class Program
    {
        static Dictionary<Char, string> From = new Dictionary<char, string> { };
        static Dictionary<string, Char> To = new Dictionary<string, Char> { };
        static bool Check1 = true, Check2 = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 11");
            // Заполнение таблиц
            Tables();
            string word = "Полина";
            Console.WriteLine("Пожалуйста, введите строку, которую необходимо зашифровать");
            word = Console.ReadLine();
            // шифрование
            string answer = Encryption(word);
            Console.WriteLine("Шифрование:");
            if (!Check1) Console.WriteLine("ВНИМАНИЕ! При шифровании были найдены символы, которых нет в таблице. Они будут зашифрованы как 0000");
            Console.WriteLine(answer);
            // дешифрование
            Console.WriteLine("Дешифрование:");
            if(!Check2) Console.WriteLine("ВНИМАНИЕ! При дешифровании были найдены шифры, которых нет в таблице. Они будут расшифрованы как §");
            Console.WriteLine(Decryption(answer));
            Console.ReadLine();
        }
        static void Tables() // Заполнение таблиц
        {
            // Заполнение таблицы шифрования
            for (int i = 32; i < 123; i++) // английский алфавит и символы (цифры)
                From.Add((Char)i, String.Format("{0,0:D4}", i));
            for (int i = 1040; i < 1104; i++) // русский алфавит
                From.Add((Char)i, String.Format("{0,0:D4}", i));
            // Заполнение таблицы дешифрования
            foreach (var x in From)
                To.Add(x.Value, x.Key);
        }
        static string Decryption(string wordto) // дешифрование
        {
            string word = "";
            int size = 0; string subs = "";
            foreach (Char c in wordto)
            {
                size++; subs = subs + c;
                if (size == 4)
                {
                    if (To.ContainsKey(subs))
                        word = word + To[subs];
                    else // если код не найден
                    {
                        Check2 = false;
                        word = word + "§";
                    }
                    size = 0; subs = "";
                }
            }
            if (size != 0)
            {
                if (To.ContainsKey(subs))
                    word = word + To[subs];
                else // если код не найден
                {
                    Check2 = false;
                    word = word + "§";
                }
                    }
            return word;
        }
        static string Encryption(string word) // шифрование 
        {
            string answer = "";
            foreach (Char s in word)
            {
                if (From.ContainsKey(s))
                answer = answer + From[s];
                else // если символ не найден
                {
                    Check1 = false;
                    answer = answer + "0000";
                }
            }
            return answer;
        }
    }
}
