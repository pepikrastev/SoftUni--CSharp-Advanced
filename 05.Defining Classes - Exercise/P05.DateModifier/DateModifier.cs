using System;
using System.Collections.Generic;
using System.Text;

namespace P05.DateModifier
{
   public class DateModifier
    {
        private DateTime startData;
        private DateTime endData;

        public  DateModifier(DateTime start, DateTime end)
        {
            this.StartData = start;
            this.EndData = end;
        }

        public DateTime StartData { get => startData; set => startData = value; }
        public DateTime EndData { get => endData; set => endData = value; }

        public  double GetDifference()
        {
            return Math.Abs((EndData - StartData).TotalDays);
        }
    }
}
