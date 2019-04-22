﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P06.StrategyPattern
{
    public class PersonNameLangthComparer : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            int nameLengthResult = first.Name.Length.CompareTo(second.Name.Length);

            if (nameLengthResult == 0)
            {
                return first.Name.ToLower()[0].CompareTo(second.Name.ToLower()[0]);
            }

            return nameLengthResult;
        }
    }
}
