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
    public partial class TeachQuartMarks : Form
    {
        public TeachQuartMarks()
        {
            InitializeComponent();
        }

        private void quartMarksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.quartMarksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sourceDataSet);

        }

        private void quartMarksBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.quartMarksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sourceDataSet);

        }

        private void TeachQuartMarks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sourceDataSet.QuartMarks". При необходимости она может быть перемещена или удалена.
            this.quartMarksTableAdapter.Fill(this.sourceDataSet.QuartMarks);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Teacher form = new Teacher();
            form.Show();
        }
    }
}
