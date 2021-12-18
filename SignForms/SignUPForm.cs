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
    public partial class SignUPForm : Form
    {
        public SignUPForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Метод регистрации
        private void ToAuthorize(object sender, EventArgs e)
        {
            #region Поля фоомы регистрации
            //поля для регистрации пользователя
            string login = loginBox.Text;
            string surname = surnameBox.Text;
            string name = nameBox.Text;
            string secondName = secondNameBox.Text;
            string password = passwordBox.Text;
            #endregion

            #region Подключение базы
            //подключение базы
            string PetDBConnectionString = null;
            PetDBConnectionString = @"Data Source=C6F3\SQLEXPRESS; Initial Catalog=PetDB; Integrated Security=True";
            SqlConnection connection = new SqlConnection(PetDBConnectionString);
            connection.Open();
            //sql 
            #endregion

            string SQLCheckLogin = "SELECT [Login] FROM [PetDataBase].[dbo].[LoginData] WHERE [Login] = '" + login + "'";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(SQLCheckLogin, PetDBConnectionString))
            {
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                if (table.Rows.Count == 0) //т.е. если не нашел совпадающего по логину и паролю в Table будет 0 строк
                {
                    #region SQL запросы
                    SqlCommand cmd = new SqlCommand("INSERT INTO [PetDataBase].[dbo].[User] (IDRole, Name, Surname, SecondName) VALUES (@IDRole, @Name, @Surname, @SecondName)", connection);
                    cmd.Parameters.AddWithValue("@IDRole", 2);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Surname", surname);
                    cmd.Parameters.AddWithValue("@SecondName", secondName);
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

                    connection.Open();

                    var PetDBSelectQuery = new SqlCommand("SELECT [IDUser] FROM [PetDataBase].[dbo].[User] WHERE [Name] = '" + name + "'and [Surname]='" + surname + "'and [SecondName]='" + secondName + "'", connection);
                    var sqlForID = PetDBSelectQuery.ExecuteScalar().ToString();

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO [PetDataBase].[dbo].[LoginData] (IDUser, Login, Password) VALUES (@IDUser, @Login, @Password)", connection);
                    cmd2.Parameters.AddWithValue("@IDUser", sqlForID);
                    cmd2.Parameters.AddWithValue("@Login", login);
                    cmd2.Parameters.AddWithValue("@Password", password);
                    try
                    {
                        cmd2.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Облом!");
                    }
                    finally
                    {
                        connection.Close();
                    }
                    #endregion
                }
                else
                {
                    MessageBox.Show("Облом!");
                }
            }

            SignUPSuccessful newForm = new SignUPSuccessful();
            newForm.Show();
        }



        private void back_button(object sender, EventArgs e)
        {
            SignINForm newForm = new SignINForm();
            newForm.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
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
