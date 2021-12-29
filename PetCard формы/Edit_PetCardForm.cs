using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_project
{
    public partial class Edit_PetCardForm : Form
    {
        public Edit_PetCardForm()
        {
            InitializeComponent();
            Show_DataInForm();
        }

        private void Edit_PetCardForm_Load(object sender, EventArgs e)
        {

        }

        private void close_button(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Show_DataInForm()
        {
            string id_key = IDPetCard_key.global_PetCardPassport;

            SqlConnection connection = DataBase.LinkDataBase();

            Controller.ShowPetCard(id_key);

            //CategoryAnimal.Text;

            void fullData()
            {
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

                //Photo
                SqlCommand cmdPhoto = new SqlCommand("SELECT [Photo] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdPhoto);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                if (dataSet.Tables[0].Rows.Count == 1)
                {
                    Byte[] data = new Byte[0];
                    data = (Byte[])(dataSet.Tables[0].Rows[0]["Photo"]);
                    MemoryStream mem = new MemoryStream(data);
                    pictureBox1.Image = Image.FromStream(mem);
                }

                //FIO
                SqlCommand cmdFIO_ID = new SqlCommand("SELECT [IDUser] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);
                var thisUserID = cmdFIO_ID.ExecuteScalar().ToString();

                SqlCommand cmdName = new SqlCommand("SELECT [Name] FROM [PetDataBase].[dbo].[User] WHERE [IDUser] = '" + thisUserID + "'", connection);
                var thisUserName = cmdName.ExecuteScalar().ToString();
                SqlCommand cmdSurname = new SqlCommand("SELECT [Surname] FROM [PetDataBase].[dbo].[User] WHERE [IDUser] = '" + thisUserID + "'", connection);
                var thisUserSurname = cmdSurname.ExecuteScalar().ToString();
                SqlCommand cmdSecondName = new SqlCommand("SELECT [SecondName] FROM [PetDataBase].[dbo].[User] WHERE [IDUser] = '" + thisUserID + "'", connection);
                var thisUserSecondName = cmdSecondName.ExecuteScalar().ToString();

                var FullName = thisUserSurname + " " + thisUserName + " " + thisUserSecondName;

                FIO.Text = FullName;


                //Gender
                SqlCommand cmdGender = new SqlCommand("SELECT [Gender] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);
                var thisGender = cmdGender.ExecuteScalar().ToString();

                if (thisGender == "male")
                {
                    radioButton1.Checked = true;
                }
                else if (thisGender == "female")
                {
                    radioButton2.Checked = true;
                }

                //DateOfBirth
                SqlCommand cmdDateOfBirth = new SqlCommand("SELECT [DateOfBirth] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);

                SqlDataReader thisReaderDateOfBirth = cmdDateOfBirth.ExecuteReader();
                string res6 = string.Empty;
                while (thisReaderDateOfBirth.Read())
                {
                    res6 += thisReaderDateOfBirth["DateOfBirth"];
                }
                thisReaderDateOfBirth.Close();
                DateOfBirth.Text = res6;

                //RegistrationdDate
                SqlCommand cmdRegistrationdDate = new SqlCommand("SELECT [RegistrationdDate] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);

                SqlDataReader thisReaderRegistrationdDate = cmdRegistrationdDate.ExecuteReader();
                string res7 = string.Empty;
                while (thisReaderRegistrationdDate.Read())
                {
                    res7 += thisReaderRegistrationdDate["RegistrationdDate"];
                }
                thisReaderRegistrationdDate.Close();
                DateOfRegistration.Text = res7;




                ///

                //SqlDataReader thisReaderLocality = cmdLocality.ExecuteReader();
                //string res4 = string.Empty;
                //while (thisReaderLocality.Read())
                //{
                //    res4 += thisReaderLocality["Locality"];
                //}
                //thisReaderLocality.Close();
                //Locality.Text = res4;


                //string Fio = FIO.Text;



                //string SQLCheckLogin = "SELECT [Сategory] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'";


                //string nickName = NickName.Text;

                //string breed = Breed.Text;

                PassportNumber.Text = id_key;

                //string idUser = IDUser_key.global_IDUser;

                //string gender = "male";

                //string locality = Locality.Text;


                //Controller.ShowPetCard(id_key);


            }
            fullData();

        }

        
        private void Add_Photo(object sender, EventArgs e)
        {
            string imgLocation = "";
            pictureBox1.ImageLocation = "";
            OpenFileDialog dialog = new OpenFileDialog();
            
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
           
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {

            #region Поля texbox
            string categoryAnimal = CategoryAnimal.Text;//

            string nickName = NickName.Text;//

            string breed = Breed.Text;//

            string passportNumber = PassportNumber.Text;

            string idUser = IDUser_key.global_IDUser;

            string dateOfBirth = DateOfBirth.Value.Date.ToString("dd-MM-yyyy");//

            string registrationDate = DateOfRegistration.Value.Date.ToString("dd-MM-yyyy");

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

            //byte[] images = null;
            //FileStream stream = new FileStream(photo, FileMode.Open, FileAccess.Read);
            //BinaryReader brs = new BinaryReader(stream);
            //images = brs.ReadBytes((int)stream.Length);

            //подключение базы
            SqlConnection connection = DataBase.LinkDataBase();


            string sql = string.Format("Update PetData Set NickName = '{1}', Category = '{2}', DateOfBirth = '{3}', Breed = '{4}', RegistrationdDate = '{5}', PassportNumber = '{6}', Gender = '{7}', Locality = '{8}' Where IDPet = '{0}'",
            IDPetCard_key.GetGlobalPetCardID(), nickName, categoryAnimal, dateOfBirth, breed, registrationDate, passportNumber, gender, locality);
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.ExecuteNonQuery();
            }

            //string sql = string.Format("Update PetData Set NickName = '{1}', Category = '{2}', DateOfBirth = '{3}', Breed = '{4}', RegistrationdDate = '{5}', PassportNumber = '{6}', Photo = '{7}', Gender = '{8}', Locality = '{9}' Where IDPet = '{0}'",
            //IDPetCard_key.GetGlobalPetCardID(), nickName, categoryAnimal, dateOfBirth, breed, registrationDate, passportNumber, images, gender, locality);
            //using (SqlCommand cmd = new SqlCommand(sql, connection))
            //{
            //    cmd.ExecuteNonQuery();
            //}




            MessageBox.Show("Карточка успешно изменена");
            this.Close();
        }
    }
}
