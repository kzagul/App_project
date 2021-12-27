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
    public partial class Show_ADForm : Form
    {
        public Show_ADForm()
        {
            InitializeComponent();
        }

        private void Show_ADForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.ReadOnly = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
