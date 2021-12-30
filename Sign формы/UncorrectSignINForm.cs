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
    public partial class UncorrectSignINForm : Form
    {
        public UncorrectSignINForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Клавиша закрытия
        private void close_button(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
