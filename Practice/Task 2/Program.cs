using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static List<int> results = new List<int>();
        static int[,] m;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            m = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int j = 0;
                foreach (string s in Console.ReadLine().Split())
                    m[i, j++] = int.Parse(s);
            }
            int[] N = new int [n];
            for (int i = 0; i < n; i++)
                m[i, i] = 0;
            int group = 1;
            while (M())
            {
                bron_kerbosh(m);
                int try_please = 1;
                foreach (int i in results)
                {
                    foreach (int j in results)
                    {
                        m[i, j] = 0;
                        m[j, i] = 0;
                            }
                    N[i] = group;
                    try_please++;
                    if (try_please > 5) break;
                }
                    group++;
            }
            for (int i = 0; i < n; i++)
                if (N[i] == 0) N[i] = group++;
            Console.WriteLine(--group);
            print(N.ToList<int>());
            Console.ReadLine();

        }
        static void bron_kerbosh(int [,] m)
        {
            results = new List<int>();
            List<int> L = new List<int>();
            for (int i = 0; i < m.GetLength(0); i++)
                L.Add(i);
            Extend(new List<int>(), L, new List<int>());
        }
        static void Extend (List<int>  compsub, List<int> candidates, List<int> wrong)
        {
            
            while (candidates.Count != 0 && Check(candidates, wrong))
            {
                int v = candidates[0];
                compsub.Add(v);
                List<int> new_candidates = new List<int>();
                foreach (int i in candidates)
                    if (m[i, v] == 1 && i != v) //
                        new_candidates.Add(i);
                List<int> new_wrong = new List<int>();
                foreach (int i in wrong)
                    if (m[i, v] == 1 && i != v) //
                        new_wrong.Add(i);
                if (new_candidates.Count == 0 && new_wrong.Count == 0)
                {
                    //foreach (int i in compsub)
                    //    results.Add(i);
                    //print(compsub);
                    if (compsub.Count > results.Count)
                    {
                        results = new List<int>();
                        foreach (int i in compsub)
                            results.Add(i);
                    }
                }
                else
                    Extend(compsub, new_candidates, new_wrong);
                candidates.Remove(v);
                compsub.Remove(v);
                wrong.Add(v);

            }

        }
        static void print(List<int> compsub)
        {
            foreach (int a in compsub)
                Console.Write(a + " ");
            Console.WriteLine();
        }
        static bool Check(List<int> candidates, List<int> wrong)
        {
            bool b = true;
            foreach (int i in wrong)
            {
                b = true;
                foreach (int j in candidates)
                    if (m[i, j] == 0) //
                    {
                        b = false;
                        break;
                    }
                if (b) return false;
            }
            return true;
        }
        static bool M()
        {
            foreach (int i in m)
                if (i != 0) return true; //проверка напустоту (false - пусто)
            return false;
        }
    }
}


