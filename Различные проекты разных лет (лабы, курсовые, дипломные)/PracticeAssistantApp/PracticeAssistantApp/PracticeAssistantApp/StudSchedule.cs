using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PracticeAssistantApp
{
    public partial class StudSchedule : Form
    {
        public StudSchedule()
        {
            InitializeComponent();
            Database db = new Database();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand sql22 = new SqlCommand("SELECT Subject,Mark,HomeWork,Date FROM [dbo].[Schedule] WHERE Day(Date)=@Day and Mark IS NOT NULL", db.getConnection());
            int day = 22;
            sql22.Parameters.Add("@Day", SqlDbType.Int).Value = day;

            db.openConnection();
            adapter.SelectCommand = sql22;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {


                SqlDataReader comm1 = sql22.ExecuteReader();
                if (comm1.HasRows)
                {
                    while (comm1.Read())
                    {
                        groupBox1.Text = Convert.ToString(comm1.GetDateTime(3));
                        listBox1.Items.Add(comm1.GetString(0));
                        listBox3.Items.Add(comm1.GetString(2));
                        listBox5.Items.Add(comm1.GetValue(1));
                    }
                }
                comm1.Close();

            }
            db.closeConnection();

            SqlCommand sql23 = new SqlCommand("SELECT Subject,Mark,HomeWork,Date FROM [dbo].[Schedule] WHERE Day(Date)=@Day and (Mark IS NOT NULL and HomeWork is not null)", db.getConnection());
            day++;
            sql23.Parameters.Add("@Day", SqlDbType.Int).Value = day;

            db.openConnection();
            adapter.SelectCommand = sql23;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {


                SqlDataReader comm2 = sql23.ExecuteReader();
                if (comm2.HasRows)
                {
                    while (comm2.Read())
                    {
                        groupBox2.Text = Convert.ToString(comm2.GetDateTime(3));
                        listBox2.Items.Add(comm2.GetString(0));
                        listBox4.Items.Add(comm2.GetString(2));
                        listBox6.Items.Add(comm2.GetValue(1));
                        
                    }
                }
                comm2.Close();

            }
            db.closeConnection();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Student form = new Student();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
