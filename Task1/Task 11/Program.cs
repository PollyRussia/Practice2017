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
        static void Main(string[] args)
        {
            // НАПИСАТЬ ФИКСАЦИЮ ОШИБОК
            // Заполнение таблиц
            Tables();
            string word = "Полина";
            // шифрование
            string answer = Encryption(word);
            Console.WriteLine(word + " to " + answer);
            // дешифрование
            Console.WriteLine("Back: " + Decryption(answer));
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
        static string Decryption(string wordto) // шифрование
        {
            string word = "";
            int size = 0; string subs = "";
            foreach (Char c in wordto)
            {
                size++; subs = subs + c;
                if (size == 4)
                {
                    word = word + To[subs];
                    size = 0; subs = "";
                }
            }
            if (size != 0) word = word + To[subs]; // фиксацию багов сделать (когда символа нет)
            return word;
        }
        static string Encryption(string word) // дешифрование 
        {
            string answer = "";
            foreach (Char s in word)
                answer = answer + From[s]; // фиксацию багов сделать (когда символа нет)
            return answer;
        }
    }
}
