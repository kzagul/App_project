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

            string gender = "male";

            string locality = Locality.Text;
            #endregion

            Controller.AddNewPetCard(categoryAnimal,
                       nickName,
                       breed,
                       Convert.ToInt32(passportNumber),
                       idUser,
                       gender,
                       locality);
        }

        //-
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //-
        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
