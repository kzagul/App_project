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
            #region Поля texbox
            string categoryAnimal = CategoryAnimal.Text;

            string nickName = NickName.Text;

            string breed = Breed.Text;

            string passportNumber = PassportNumber.Text;

            string idUser = IDUser_key.global_IDUser;

            //string gender;

            string locality = Locality.Text;
            #endregion


            #region Подключение базы
            string PetDBConnectionString = null;
            PetDBConnectionString = @"Data Source=C6F3\SQLEXPRESS; Initial Catalog=PetDB; Integrated Security=True";
            SqlConnection connection = new SqlConnection(PetDBConnectionString);
            connection.Open();
            #endregion



            SqlCommand cmd = new SqlCommand("INSERT INTO[PetDataBase].[dbo].[PetData](Category, NickName, Breed, PassportNumber, IDUser, Gender, Locality) VALUES (@Category, @NickName, @Breed, @PassportNumber, @IDUser, @Gender, @Locality)", connection);
            cmd.Parameters.AddWithValue("@Category", categoryAnimal);
            cmd.Parameters.AddWithValue("@NickName", nickName);
            cmd.Parameters.AddWithValue("@Breed", breed);
            cmd.Parameters.AddWithValue("@PassportNumber", passportNumber);
            cmd.Parameters.AddWithValue("@IDUser", idUser);
            cmd.Parameters.AddWithValue("@Gender", "male");
            cmd.Parameters.AddWithValue("@Locality", locality);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Облом!");
            }
            finally
            {
                connection.Close();
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
