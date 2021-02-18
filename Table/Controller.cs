using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    class Controller
    {
        public Schedule[] schedules = new Schedule[40];
        int counter = 0;
        public void addSubject(Schedule schedule)
        {
            schedules[counter] = schedule;
            Console.WriteLine(schedules[counter].Subject);
            counter += 1;
        }
        public StudentFreeTimeDay findFreeTime(int day)
        {
            StudentFreeTimeDay[] freeTimeDays = getFreeTime();
            return freeTimeDays[day];
        }

        public StudentFreeTimeDay [] getFreeTime()
        {
            StudentFreeTimeDay[] studentFreeTimeDays = new StudentFreeTimeDay[5];
            for (int day = 0; day < 5; day++)
            {
                StudentFreeTimeDay studentEmtpyTime = new StudentFreeTimeDay(16);
                EmptyTime emptyTime;
                int emptyTimeCounter = 0;
                double lastSubjectTime = 8;
                for (int subjectNumber = 0; subjectNumber < schedules.Length - 1; subjectNumber++)
                {
                    if (schedules[subjectNumber] != null)
                    {
                        if (day == schedules[subjectNumber].Day)
                        {
                            Schedule subject = schedules[subjectNumber];

                            if (subject.From > lastSubjectTime)
                            {
                                emptyTime = new EmptyTime(lastSubjectTime, subject.From, subject.Day);
                                studentEmtpyTime.EmptyTimes[emptyTimeCounter] = emptyTime;
                                emptyTimeCounter++;
                            }
                            lastSubjectTime = subject.To;
                        }
                    }
                }
                String lastItem = "";
                if (lastSubjectTime < 16)
                {
                    lastItem = lastSubjectTime + " ----- " + 16;
                }
                if (lastItem != "")
                {
                    emptyTime = new EmptyTime(lastSubjectTime, 16, day);
                    studentEmtpyTime.EmptyTimes[emptyTimeCounter] = emptyTime;
                }
                studentFreeTimeDays[day] = studentEmtpyTime;
            }
            return studentFreeTimeDays;
        }

        public void deleteSubject(String subjectName)
        {
            for (int i = 0; i < schedules.Length; i++)
            {
                if (schedules[i] != null)
                {
                    if (schedules[i].Subject == subjectName)
                    {
                        if (schedules.Length == 1)
                        {
                            schedules[counter - 1] = null;
                        }
                        else
                        {
                            for (int j = i; j < counter; j++)
                            {
                                if (schedules.Length - 1 == j)
                                {
                                    schedules[j] = null;
                                }
                                else
                                {
                                    schedules[j] = schedules[j + 1];
                                }
                            }
                        }
                    }
                }
            }
        }

        public void checkDayFrom(int subjectDay, int counter, Schedule[] schedule)
        {
            for (int j = 0; j < counter; j++)
            {
                if (schedule[counter].Day == schedule[j].Day)
                {
                    if (schedule[counter].From == schedule[j].From)
                    {
                        schedule[counter].From = int.Parse(Console.ReadLine());
                        j--;
                    }
                }
            }
        }

    }
}



