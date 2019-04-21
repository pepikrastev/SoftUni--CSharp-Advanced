using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
   public class Box<T>
    {
        Stack<T> list;


        public Box()
        {
            this.list = new Stack<T>();
        }

        public int Count { get; private  set; }

        public void Add(T element)
        {
            list.Push(element);
            this.Count++;
        }

        public T Remove()
        {
            this.Count--;
            return list.Pop();
        }
    }
}
