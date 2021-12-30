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
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace App_project
{
    public partial class Show_PetCardForm : Form
    {
        public Show_PetCardForm()
        {
            InitializeComponent();
            Show_DataInForm();
        }

        private void Show_PetCardForm_Load(object sender, EventArgs e)
        {
            
        }

        private void CloseThisForm_Button(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_PetCard_Button(object sender, EventArgs e)
        {
            this.Hide();
            OpenChildForm(new Edit_PetCardForm());
        }

        private void Delete_PetCard_Button(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Карточка удалена");
            Controller.DeletePetCard(IDPetCard_key.global_PetCardPassport);

            //dataGridView1.Rows.Remove(SelectedRows);
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

            MyPetsForm.panel.Controls.Add(childForm);
            MyPetsForm.panel.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }



        public void Show_DataInForm()
        {
            string id_key = IDPetCard_key.global_PetCardPassport;

            SqlConnection connection = DataBase.LinkDataBase();

            Controller.ShowPetCard(id_key);


            void fullData() {
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

        //-
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CategoryAnimal_TextChanged(object sender, EventArgs e)
        {
            CategoryAnimal.ReadOnly = true;
        }

        private void Breed_TextChanged(object sender, EventArgs e)
        {
            Breed.ReadOnly = true;
        }

        private void Locality_TextChanged(object sender, EventArgs e)
        {
            Locality.ReadOnly = true;
        }

        private void PassportNumber_TextChanged(object sender, EventArgs e)
        {
            PassportNumber.ReadOnly = true;
        }

        private void NickName_TextChanged(object sender, EventArgs e)
        {
            NickName.ReadOnly = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            //panel1.Parent = this;
        }

        private void ExportToExcel_PetCard(object sender, EventArgs e)
        {
            #region поля
            string nickName = NickName.Text;
            string categoryAnimal = CategoryAnimal.Text;
            string breed = Breed.Text;
            string locality = Locality.Text;
            string passportNumber = PassportNumber.Text;

            string dateofbirth = DateOfBirth.Text;
            string dateofregistration = DateOfRegistration.Text;
            string fio = FIO.Text;

            string gender = "";
            if (radioButton1.Checked)
                gender = "Мужской";
            if (radioButton2.Checked)
                gender = "Женский";
            #endregion

            Controller.Export2ExcelPetCard(nickName, categoryAnimal, breed, locality, passportNumber, dateofbirth, dateofregistration, fio, gender);
           
        }

        private void ExportToWord_PetCard(object sender, EventArgs e)
        {
            string nickName = NickName.Text;
            string categoryAnimal = CategoryAnimal.Text;
            string breed = Breed.Text;
            string locality = Locality.Text;
            string passportNumber = PassportNumber.Text;

            string dateofbirth = DateOfBirth.Text;
            string dateofregistration = DateOfRegistration.Text;
            string fio = FIO.Text;

            string gender = "";
            if (radioButton1.Checked)
                gender = "Мужской";
            if (radioButton2.Checked)
                gender = "Женский";


            // Создаём объект документа
            //Word.Document doc = null;
            //try
            //{
            //    Word.Application winword = new Word.Application();

            //    winword.Visible = false;
            //    object missing = System.Reflection.Missing.Value;

            //    //Создание нового документа
            //    Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

            //    //добавление новой страницы
            //    winword.Selection.InsertNewPage();
            //    document.Content.SetRange(0, 0);
            //    document.Content.Text = "Кличка: " + nickName + Environment.NewLine
            //        + "Вид животного: " + categoryAnimal + Environment.NewLine
            //         + "Порода: " + breed + Environment.NewLine
            //         + "Населённый пункт: " + locality + Environment.NewLine
            //          + "Номер паспорта: " + passportNumber + Environment.NewLine
            //          + "Пол: " + gender + Environment.NewLine
            //          + "Дата рождения: " + dateofbirth + Environment.NewLine
            //          + "Дата регистрации: " + dateofregistration + Environment.NewLine
            //          + "Ф.И.О.: " + fio + Environment.NewLine;
            //    //document.Content.Text = CategoryAnimal.Text + Environment.NewLine;
            //    //winword.Visible = true;

            //    //Сохранение документа
            //    object filename = "C:\\Users\\kirillzagul\\Downloads\\" + nickName + ".docx";
            //    document.SaveAs(ref filename);
            //    //Закрытие текущего документа
            //    document.Close(ref missing, ref missing, ref missing);
            //    document = null;
            //    //Закрытие приложения Word
            //    winword.Quit(ref missing, ref missing, ref missing);
            //    winword = null;
            //    MessageBox.Show("Успешно!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            Controller.Export2WordPetCard(nickName, categoryAnimal, breed, locality, passportNumber, dateofbirth, dateofregistration, fio, gender);


        }

        //-
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FIO_textbox(object sender, EventArgs e)
        {
            FIO.ReadOnly = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DateOfBirth_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DateOfRegistration_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
