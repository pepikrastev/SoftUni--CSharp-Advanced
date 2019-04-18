using System;
using System.Collections.Generic;
using System.Text;

namespace P12.Google
{
    public class Pokemon
    {
        public Pokemon(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }

        public string Name { get; set; }

        public string Type { get; set; }
    }
}
