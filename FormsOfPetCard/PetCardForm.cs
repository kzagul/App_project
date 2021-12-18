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

            string idUser; // получим из sql выражения

            //var smth = 

            //var PetDBSelectQuery = new SqlCommand("SELECT [IDUser] FROM [PetDataBase].[dbo].[User] WHERE [Name] = '" + name + "'and [Surname]='" + surname + "'and [SecondName]='" + secondName + "'", connection);
            //idUser = PetDBSelectQuery.ExecuteScalar().ToString();
            
            //string gender;

            string locality = Locality.Text;
            #endregion 


            string PetDBConnectionString = null;
            PetDBConnectionString = @"Data Source=C6F3\SQLEXPRESS; Initial Catalog=PetDB; Integrated Security=True";
            SqlConnection connection = new SqlConnection(PetDBConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO[PetDataBase].[dbo].[PetData](Category, NickName, Breed, PassportNumber, IDUser, Gender, Locality) VALUES('b', 'mike', 'york', '7722', '22', 'male', 'tyumen')", connection);

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
