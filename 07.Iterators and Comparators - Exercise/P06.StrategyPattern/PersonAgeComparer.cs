using System;
using System.Collections.Generic;
using System.Text;

namespace P06.StrategyPattern
{
    public class PersonAgeComparer : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            return first.Age - second.Age;
        }
    }
}
