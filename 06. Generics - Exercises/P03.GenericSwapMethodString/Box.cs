using System;
using System.Collections.Generic;
using System.Text;

namespace P03.GenericSwapMethodString
{
    public class Box<T>
    {
        private T element;

        public Box(T element)
        {
            this.element = element;
        }

        public static void Swap(List<Box<T>> list, int firstIndex, int secondIndex)
        {
            if (list.Count > firstIndex && firstIndex >= 0 && list.Count > secondIndex && secondIndex >= 0)
            {
                var temporary = list[firstIndex];
                list[firstIndex] = list[secondIndex];
                list[secondIndex] = temporary;
            }
        }

        public override string ToString()
        {
            return $"{this.element.GetType()}: {this.element}";
        }
    }
}
