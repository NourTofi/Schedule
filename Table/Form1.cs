using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Table
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(5);
            //int time = 8;
            //for (int i = 0; i < 9; i++)
            //{
            //    dataGridView1.Rows[i].HeaderCell.Value = (time++) + "";
            //}
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        Controller lecture = new Controller();
        int counter = 0;
        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            int subjectDay = int.Parse(dayBox.Text);
            double startSubject = double.Parse(startSubjectBox.Text);
            double endSubject = double.Parse(endSubjectBox.Text);
            String subjectName = subjectNameBox.Text;
            if (startSubject < endSubject)
            {
                Schedule schedule = new Schedule();
                Schedule[] schedules = new Schedule[40];
                schedule.Day = subjectDay;
                schedule.Subject = subjectName;
                schedule.From = startSubject;
                schedule.To = endSubject;
                lecture.addSubject(schedule);
                deleteBox.Items.Add(subjectName);
                counter++;
                MessageBox.Show("The lecture has add successfully", "Success");
            }
            else
            {
                MessageBox.Show("The end time of the lecture can not be before the start time. ", "Error Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }

            for (int i = 0; i < lecture.schedules.Length - 1; i++)
            {
                if (lecture.schedules[i] != null)
                {
                    Schedule lectures = lecture.schedules[i];
                    for (int j = 0; j < 5; j++)
                    {
                        if (lectures.Day == j)
                        {
                            for (int k = 8; k < 16; k++)
                            {
                                double startLectures = lectures.From;
                                if ((startLectures == k && lectures.To > k) ||
                                    (startLectures + 1 == k && lectures.To > k) ||
                                    (startLectures + 2 == k && lectures.To > k) ||
                                    (startLectures + 3 == k && lectures.To > k))
                                {
                                    if (startLectures == 8 || startLectures == 9)
                                    {
                                        dataGridView1.Rows[0].Cells[j].Value = lectures.Subject + " " + startLectures + "--->" + lectures.To;
                                    }
                                    else if (startLectures == 10 || startLectures == 11)
                                    {
                                        dataGridView1.Rows[1].Cells[j].Value = lectures.Subject + " " + startLectures + "--->" + lectures.To;
                                    }
                                    else if (startLectures == 12 || startLectures == 13)
                                    {
                                        dataGridView1.Rows[2].Cells[j].Value = lectures.Subject + " " + startLectures + "--->" + lectures.To;
                                    }
                                    else if (startLectures == 14 || startLectures == 15)
                                    {
                                        dataGridView1.Rows[3].Cells[j].Value = lectures.Subject + " " + startLectures + "--->" + lectures.To;
                                    }
                                    else
                                    {
                                        MessageBox.Show("You can not add lectures in this time. ", "Error Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }

                    }
                }
            }
        }

        private void freeTimeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteSubjectButton_Click(object sender, EventArgs e)
        {
            lecture.deleteSubject(deleteBox.Text);
            MessageBox.Show("The lecture has been deleted successfully", "Success Delete");

        }

        private void endSubjectBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void startSubjectBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dayBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void subjectNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void freeTimeButton_Click(object sender, EventArgs e)
        {
            StudentFreeTimeDay studentFreeTime = lecture.findFreeTime(int.Parse(freeTimeBox.Text));
            freeTimeListBox.Items.Clear();
            for (int i = 0; i < studentFreeTime.EmptyTimes.Length; i++)
            {
                EmptyTime empty = studentFreeTime.EmptyTimes[i];

                if (empty != null)
                {
                    freeTimeListBox.Items.Add("from " + empty.From + " ===> to " + empty.To);
                }
            }
            MessageBox.Show("Her is the free time.", "Success");
        }

        private void freeTimeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void deleteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cleerFreeTime_Click(object sender, EventArgs e)
        {
            freeTimeListBox.Items.Clear();
        }

    }
}

