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
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainApp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String StudLogin = "user";
            String StudPass = "123";


            String TeacherLogin = "teacher";
            String TeacherPass = "456";

            if(textBox1.Text == StudLogin && textBox2.Text == StudPass)
            {
               Student form = new Student();
               form.Show();
                label4.Visible = false;
                this.Hide();
            }
            if (textBox1.Text == TeacherLogin && textBox2.Text == TeacherPass)
            {
                Teacher form = new Teacher();
                form.Show();
                label4.Visible = false;
                this.Hide();
            }
            else
            {
                label4.Visible = true;
            }
        }

        private void MainApp_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message message = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref message);
        }
    }
}
