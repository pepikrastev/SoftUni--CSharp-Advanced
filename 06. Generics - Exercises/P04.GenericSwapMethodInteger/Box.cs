using System;
using System.Collections.Generic;
using System.Text;

namespace P04.GenericSwapMethodInteger
{
    public class Box<T>
    {
        private List<T> data;

        public List<T> Data => this.data;

        public Box()
        {
            this.data = new List<T>();
        }

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T temporary = this.data[firstIndex]; 
            this.data[firstIndex] = this.data[secondIndex];
            this.data[secondIndex] = temporary;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var element in this.data)
            {
                stringBuilder.AppendLine($"{typeof(T)}: {element}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
