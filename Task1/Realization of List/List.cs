using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realization_of_List
{
    class List<T>
    {
        <T> head ;

        
            //public List <T>()
            //{
            //    // создание пустого списка
            //    this.headNode = null;
            //    this.tailNode = this.headNode;
            //    this.Length = 0;
            //}
            //public void Push(int _element)
            //{
            //    if (headNode == null)
            //    {
            //        // создать узел, сделать его головным
            //        this.headNode = new Node();
            //        this.headNode.Element = _element;
            //        // этот же узел и является хвостовым
            //        this.tailNode = this.headNode;
            //        // следующего узла нет
            //        this.headNode.SetNextNode(null);
            //    }
            //    else
            //    {
            //        // создать временный узел
            //        Node newNode = new Node();
            //        // следующий за предыдущим хвостовым узлом - это наш временный новый узел
            //        this.tailNode.SetNextNode(newNode);
            //        // сделать его же новым хвостовым
            //        this.tailNode = newNode;
            //        this.tailNode.Element = _element;
            //        // следующего узла пока нет
            //        this.tailNode.SetNextNode(null);
            //    }

            //    ++this.Length;
            //}
            //public int this[int _position]
            //{
            //    get
            //    {
            //        // дабы не загромождать пример, 
            //        // опустим проверку на валидность переданного параметра '_position'
            //        Node tempNode = this.headNode;
            //        for (int i = 0; i < _position; ++i)
            //            // переходим к следующему узлу списка
            //            tempNode = tempNode.Next;
            //        return tempNode.Element;
            //    }
            //}

            //public int Length { get; private set; }
            //private Node headNode;
            //private Node tailNode;
        
    }
}
