using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8___Long_arithmetics
{
    public class Mas
    {
        public Mas next = null;
        public int elem;
        public Mas last = null;
        public Mas(int a)
        {
            elem = a;
        }
        public Mas(int a, Mas b)
        {
            elem = a; last = b;
        }
    }
}
