using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Tree
    {
        public Tree left = null;
        public Tree right = null;
        public double frequency;
        public string key = "";
        public Tree(double f)
        {
            frequency = f;
        }
    }
}
