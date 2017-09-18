using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Elem
    {
        public int V;
        public HashSet<int> Spisok;
        public Elem(int v, HashSet<int> l)
        {
            V = v; Spisok = l;
        }
    }
}
