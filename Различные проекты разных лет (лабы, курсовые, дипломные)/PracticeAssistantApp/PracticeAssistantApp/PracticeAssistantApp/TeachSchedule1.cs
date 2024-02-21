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
    public partial class TeachSchedule1 : Form
    {
        public TeachSchedule1()
        {
            InitializeComponent();
        }

        private void scheduleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.scheduleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sourceDataSet1);

        }

        private void TeachSchedule1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sourceDataSet1.Schedule". При необходимости она может быть перемещена или удалена.
            this.scheduleTableAdapter.Fill(this.sourceDataSet1.Schedule);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Teacher form = new Teacher();
            form.Show();
        }

        private void scheduleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
