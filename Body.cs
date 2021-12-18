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
    public partial class Body : Form
    {
        public Body()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ADListForm());

            //удалить это
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           //удалить это
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ADList(object sender, EventArgs e)
        {
            OpenChildForm(new ADListForm());
            panelChildForm.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MyADsForm());
            panelChildForm.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MakeNewADForm());
            panelChildForm.Visible = true;
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new MyPetsForm());
            panelChildForm.Visible = true;
        }
        



        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }




        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
