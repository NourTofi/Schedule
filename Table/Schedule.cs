using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    class Schedule
    {
        private string subject;
        private int day;
        private double from;
        private double to;

        public Schedule()
        {
            this.day = 0;
            this.subject = "";
            this.from = 0;
            this.to = 0;
        }

        public Schedule(string subject, int day, double from, double to)
        {
            this.day = day;
            this.subject = subject;
            this.from = from;
            this.to = to;
        }

        public string Subject
        {
            set
            {
                subject = value;
            }
            get
            {
                return subject;
            }
        }

        public int Day
        {
            set
            {
                day = value;
            }
            get
            {
                return day;
            }
        }

        public double From
        {
            set
            {
                from = value;
            }
            get
            {
                return from;
            }
        }

        public double To
        {
            set
            {
                to = value;
            }
            get
            {
                return to;
            }
        }

        public void print()
        {
            Console.WriteLine(subject + "  " + day + "  " + from + " ==> " + to);
        }
    }
}
