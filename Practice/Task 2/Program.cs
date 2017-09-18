using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static HashSet<Elem> compsub = new HashSet<Elem>();
        static void Main(string[] args)
        {
            //string[] s = Console.ReadLine().Split();
            HashSet<Elem> candidates = new HashSet<Elem>();
            HashSet<Elem> wrong = new HashSet<Elem>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                HashSet<int> H = new HashSet<int>();
                int j = 1;
                foreach (string s in Console.ReadLine().Split())
                    if (s == "1") H.Add(j++);
                candidates.Add(new Elem(i, H));
            }
            Extend(candidates, wrong);
            Console.ReadLine();

        }
        static void Extend (HashSet <Elem> candidates, HashSet <Elem> wrong)
        {
            
            while (candidates.Count != 0 && !Check(candidates, wrong))
            {
                foreach(Elem v in candidates)
                {
                    compsub.Add(v);
                    HashSet<Elem> new_candidates = new HashSet<Elem>();
                    HashSet<Elem> new_not = new HashSet<Elem>();
                    foreach (Elem c in candidates)
                        if (v.Spisok.Contains(c.V))
                            new_candidates.Add(c);
                    foreach (Elem c in wrong)
                        if (v.Spisok.Contains(c.V))
                            new_not.Add(c);
                    if (new_candidates.Count == 0 && new_not.Count == 0)
                        print(); // клика
                    else
                    {
                        Extend(new_candidates, new_not);
                        compsub.Remove(v);
                        candidates.Remove(v);
                        wrong.Add(v);
                    }
                }

            }

        }
        static void print()
        {
            foreach (Elem a in compsub)
                Console.Write(a.V + " ");
            Console.WriteLine();
        }
        static bool Check(HashSet<Elem> candidates, HashSet<Elem> wrong)
        {
            bool b = true;
            foreach (Elem el in wrong)
            {
                b = true;
                foreach (Elem c in candidates)
                    if (!el.Spisok.Contains(c.V))
                    {
                        b = false;
                        break;
                    }
                if (!b) break;
            }
            return b;
        }
    }
}
