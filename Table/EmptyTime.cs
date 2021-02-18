using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    class EmptyTime
    {
        private double from;

        public double From
        {
            get { return from; }
            set { from = value; }
        }

        private double to;

        public double To
        {
            get { return to; }
            set { to = value; }
        }

        private int day;

        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public EmptyTime(double from, double to, int day)
        {
            this.To = to;
            this.from = from;
            this.day = day;
        }
    }
}
