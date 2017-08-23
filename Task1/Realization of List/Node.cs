using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realization_of_List
{
    class Node
    {
            public void SetNextNode(Node _nextNode)
            {
                this.next = _nextNode;
            }
            public int Element
            {
                get
                {
                    return this.element;
                }
                set
                {
                    this.element = value;
                }
            }

            public Node Next
            {
                get
                {
                    return this.next;
                }
            }

            private Node next;
            private int element;
        
    }
}
