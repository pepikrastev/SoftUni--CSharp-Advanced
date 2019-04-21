using System;
using System.Collections.Generic;
using System.Text;

namespace P02.GenericBoxOfInteger
{
    public class Box <T>
    {
        private T element;

        public Box(T element)
        {
            this.element = element;
        }

        public override string ToString()
        {
            return $"{this.element.GetType()}: {this.element}";
        }
    }
}
