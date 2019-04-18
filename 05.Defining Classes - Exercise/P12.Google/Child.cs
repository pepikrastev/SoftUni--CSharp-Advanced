using System;
using System.Collections.Generic;
using System.Text;

namespace P12.Google
{
    public class Child
    {
        public Child(string name, string birthDay)
        {
            this.Name = name;
            this.Birthday = birthDay;
        }
        public string Name { get; set; }

        public string Birthday { get; set; }
    }
}
