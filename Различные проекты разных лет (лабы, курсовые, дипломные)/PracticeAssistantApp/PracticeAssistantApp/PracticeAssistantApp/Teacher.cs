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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachSchedule1 schedule = new TeachSchedule1();
            schedule.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachQuartMarks quartmarks = new TeachQuartMarks();
            quartmarks.Show();
        }

     
    }
}
