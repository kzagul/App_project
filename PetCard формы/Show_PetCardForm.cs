using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_project
{
    public partial class Show_PetCardForm : Form
    {
        public Show_PetCardForm()
        {
            InitializeComponent();
            Show_DataInForm();
        }

        private void Delete_PetCardForm_Load(object sender, EventArgs e)
        {

        }

        private void CloseThisForm_Button(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_PetCard_Button(object sender, EventArgs e)
        {
            OpenChildForm(new Edit_PetCardForm());
        }

        private void Delete_PetCard_Button(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Карточка удалена");
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

            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }



        public void Show_DataInForm()
        {
            string id_key = IDPetCard_key.global_IDPetCard;

            SqlConnection connection = DataBase.LinkDataBase();

            //Category
            SqlCommand cmdCategory = new SqlCommand("SELECT [Category] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);

            SqlDataReader thisReaderCategory = cmdCategory.ExecuteReader();
            string res1 = string.Empty;
            while (thisReaderCategory.Read())
            {
                res1 += thisReaderCategory["Category"];
            }
            thisReaderCategory.Close();

            CategoryAnimal.Text = res1;

            //Breed
            SqlCommand cmbBreed = new SqlCommand("SELECT [Breed] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);

            SqlDataReader thisReaderBreed = cmbBreed.ExecuteReader();
            string res2 = string.Empty;
            while (thisReaderBreed.Read())
            {
                res2 += thisReaderBreed["Breed"];
            }
            thisReaderBreed.Close();
            Breed.Text = res2;

            //NickName
            SqlCommand cmdNickName = new SqlCommand("SELECT [NickName] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);

            SqlDataReader thisReaderNickName = cmdNickName.ExecuteReader();
            string res3 = string.Empty;
            while (thisReaderNickName.Read())
            {
                res3 += thisReaderNickName["NickName"];
            }
            thisReaderNickName.Close();
            NickName.Text = res3;

            //Locality
            SqlCommand cmdLocality = new SqlCommand("SELECT [Locality] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);

            SqlDataReader thisReaderLocality = cmdLocality.ExecuteReader();
            string res4 = string.Empty;
            while (thisReaderLocality.Read())
            {
                res4 += thisReaderLocality["Locality"];
            }
            thisReaderLocality.Close();
            Locality.Text = res4;


            //string SQLCheckLogin = "SELECT [Сategory] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'";


            //string nickName = NickName.Text;

            //string breed = Breed.Text;

            PassportNumber.Text = id_key;

            //string idUser = IDUser_key.global_IDUser;

            //string gender = "male";

            //string locality = Locality.Text;


            //Controller.ShowPetCard(id_key);






            //IDPetCard_key.global_IDPetCard;
            //MessageBox.Show(IDPetCard_key.global_IDPetCard);

        }

        //-
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
