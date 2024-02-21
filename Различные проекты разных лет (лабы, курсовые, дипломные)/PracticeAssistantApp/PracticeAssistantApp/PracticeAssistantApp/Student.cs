using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeAssistantApp
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudSchedule schedule = new StudSchedule();
            schedule.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudQuartMarks quartmarks = new StudQuartMarks();
            quartmarks.Show();
        }

        

        private void Student_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message message = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
