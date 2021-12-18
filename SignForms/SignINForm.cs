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
    public partial class SignINForm : Form
    {

        public string IDUser_outside;

        public SignINForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Клавиша входа в систему
        private void Sign_in_button(object sender, EventArgs e)
        {
            //поля логина и пароля, считываемые с боксов
            string login = loginBox.Text;
            string password = passwordBox.Text;

            //связь с бд
            string PetDBConnectionString = @"Data Source=C6F3\SQLEXPRESS; Initial Catalog=PetDataBase; Integrated Security=True";
            SqlConnection connection = new SqlConnection(PetDBConnectionString);
            connection.Open();

            //sql 
            string PetDBSelectQuery = "SELECT [Login] FROM [PetDataBase].[dbo].[LoginData] WHERE [Login] = '" + login + "'and [Password]='" + password + "'";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(PetDBSelectQuery, PetDBConnectionString))
            {
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                if (table.Rows.Count == 0) //т.е. если не нашел совпадающего по логину и паролю в Table будет 0 строк
                {
                    UncorrectSignINForm uncorrectForm = new UncorrectSignINForm();
                    uncorrectForm.Show();
                }
                else
                {
                    Body bodyForm = new Body();
                    bodyForm.Show();
                    this.Hide();
                }
            }
            //var SelectID = new SqlCommand("SELECT [IDUser] FROM [PetDataBase].[dbo].[LoginData] WHERE [Login] = '" + login + "'", connection);
            //IDUser_outside = SelectID.ExecuteScalar().ToString();
        }

        private void Sign_up_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUPForm newForm = new SignUPForm();
            newForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = '*';
        }
    }
}
