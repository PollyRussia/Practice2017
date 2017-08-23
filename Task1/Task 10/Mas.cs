using System;

namespace Task_10
{
    public class Mas
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
