using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Mas
    {
        public Mas next = null;
        public Double elem;
        public Mas last = null;
        public Mas(Double a)
        {
            elem = a;
        }
        public Mas(Double a, Mas b)
        {
            elem = a; last = b;
        }
    }
}
