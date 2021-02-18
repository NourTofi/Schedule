using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    class StudentFreeTimeDay
    {
        private EmptyTime[] emptyTimes;

        public EmptyTime[] EmptyTimes
        {
            get 
            { return emptyTimes; }
            set 
            { emptyTimes = value; }
        }

        public StudentFreeTimeDay(int maxSubject)
        {
            emptyTimes = new EmptyTime[maxSubject];
        }
    }
}
