using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_project
{
    public partial class ADListForm : Form
    {
        public ADListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ADListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petDBDataSet.AdData". При необходимости она может быть перемещена или удалена.
            this.adDataTableAdapter.Fill(this.petDBDataSet.AdData);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void реестрToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
