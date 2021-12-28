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

namespace App_project
{
    public partial class Add_PetCardForm : Form
    {
        public Add_PetCardForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PetCardForm_Load(object sender, EventArgs e)
        {

        }

        private void CloseThisForm_Button(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewPetCard_Button(object sender, EventArgs e)
        {
            #region Поля texbox
            string categoryAnimal = CategoryAnimal.Text;

            string nickName = NickName.Text;

            string breed = Breed.Text;

            string passportNumber = PassportNumber.Text;

            string idUser = IDUser_key.global_IDUser;        

            string gender="";

            string dateOfBirth = dateTimePicker1.Value.Date.ToString("dd-MM-yyyy");

            string registrationDate = dateTimePicker2.Value.Date.ToString("dd-MM-yyyy");



            if (radioButton1.Checked)
                gender = "male";
            if (radioButton2.Checked)
                gender = "female";

            string locality = Locality.Text;

            string photo = pictureBox1.ImageLocation;
            #endregion

            Controller.AddNewPetCard(categoryAnimal,
                       nickName,
                       breed,
                       Convert.ToInt32(passportNumber),
                       idUser,
                       gender,
                       locality,
                       photo,
                       dateOfBirth,
                       registrationDate);
        }

        //-
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //-
        private void label14_Click(object sender, EventArgs e)
        {

        }
        string imgLocation = "";
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }
    }
}
