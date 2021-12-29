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
            var connection = DataBase.LinkDataBase();
            var id_key = IDUser_key.global_IDUser;
            //FIO
            //SqlCommand cmdFIO_ID = new SqlCommand("SELECT [IDUser] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);
            //var thisUserID = cmdFIO_ID.ExecuteScalar().ToString();
            
            SqlCommand cmdName = new SqlCommand("SELECT [Name] FROM [PetDataBase].[dbo].[User] WHERE [IDUser] = '" + id_key + "'", connection);
            var thisUserName = cmdName.ExecuteScalar().ToString();
            SqlCommand cmdSurname = new SqlCommand("SELECT [Surname] FROM [PetDataBase].[dbo].[User] WHERE [IDUser] = '" + id_key + "'", connection);
            var thisUserSurname = cmdSurname.ExecuteScalar().ToString();
            SqlCommand cmdSecondName = new SqlCommand("SELECT [SecondName] FROM [PetDataBase].[dbo].[User] WHERE [IDUser] = '" + id_key + "'", connection);
            var thisUserSecondName = cmdSecondName.ExecuteScalar().ToString();

            var FullName = thisUserSurname + " " + thisUserName + " " + thisUserSecondName;

            FIO.Text = FullName;
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

            string dateOfBirth = dateTimePicker1.Value.Date.ToString("dd-MM-yyyy");

            string registrationDate = dateTimePicker2.Value.Date.ToString("dd-MM-yyyy");

            //Gender
            string gender = "male";

            if (radioButton1.Checked == true)
            {
                gender = "male";
            }
            else if (radioButton2.Checked == true)
            {
                gender = "female";
            }


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
                       registrationDate
                       );

            this.Close();
        }

        //-
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //-
        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Breed_TextChanged(object sender, EventArgs e)
        {

        }
        string imgLocation = "";
        private void Add_Photo(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void FIO_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //dateTimePicker1.Value.Tostring("#dd/mm/yyyy#");
        }
    }
}
