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
    public partial class PetCardForm : Form
    {
        public PetCardForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PetCardForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewPetCard(object sender, EventArgs e)
        {
            string categoryAnimal = CategoryAnimal.Text;
            string nickName = NickName.Text;
            string breed = Breed.Text;
            string locality = Locality.Text;

            //string password = passwordBox.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
