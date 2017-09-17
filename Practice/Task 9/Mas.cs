using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Mas
    {
        public Mas next = null;
        public double elem;
        public Mas(double a)
        {
            elem = a;
            next = this;
            kol++;
            if (a > 0) GoodElem++;
            if (a < 0) BadElem++;
        }
        public Mas(double a, Mas b)
        {
            elem = a;
            next = b.next;
            b.next = this;
            kol++;
            if (a > 0) GoodElem++;
            if (a < 0) BadElem++;

        }
        public static int kol = 0, GoodElem = 0, BadElem = 0;
    }
}
