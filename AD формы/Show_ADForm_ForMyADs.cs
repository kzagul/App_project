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
    public partial class Show_ADForm_ForMyADs : Form
    {
        public Show_ADForm_ForMyADs()
        {
            InitializeComponent();
            Show_DataInForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void Show_DataInForm()
        {
            string id_key = IDPetCard_key.global_PetCardPassport;

            SqlConnection connection = DataBase.LinkDataBase();

            //Controller.ShowPetCard(id_key);

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


                //DateOfPosting
                DateOfPosting.Text = DateTime.Now.Date.ToString("dd-MM-yyyy");


                //Gender

                SqlCommand cmdGender = new SqlCommand("SELECT [Gender] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);
                var thisGender = cmdGender.ExecuteScalar().ToString();

                if (thisGender == "male")
                {
                    GenderBox.Text = "Мужской";
                }
                else if (thisGender == "female")
                {
                    GenderBox.Text = "Женский";
                }

                //DateOfMissing

                SqlCommand cmdDateOfMissing = new SqlCommand("SELECT [DateOfMissing] FROM [PetDataBase].[dbo].[AdData] WHERE [IDPet] = '" + IDPetCard_key.GetGlobalPetCardID() + "'", connection);

                SqlDataReader thisReaderDateOfMissing = cmdDateOfMissing.ExecuteReader();
                string res5 = string.Empty;
                while (thisReaderDateOfMissing.Read())
                {
                    res5 += thisReaderDateOfMissing["DateOfMissing"];
                }
                thisReaderDateOfMissing.Close();
                DateOfMissing.Text = res5;




            }

            fullData();


            //IDPetCard_key.global_IDPetCard;
            //MessageBox.Show(IDPetCard_key.global_IDPetCard);

        }

        private void Show_ADForm_ForMyADs_Load(object sender, EventArgs e)
        {

        }

        private void Delete_Announcement(object sender, EventArgs e)
        {
            SqlConnection connection = DataBase.LinkDataBase();

            var petCardID = IDPetCard_key.GetGlobalPetCardID();


            Controller.DeleteADCard(petCardID);
            
            //var PetDBSelectQuery = new SqlCommand("SELECT [IDPet] FROM [PetDataBase].[dbo].[AdData] WHERE [IDPet] = '" + petCardID + "'", connection);
            //var sqlForIdPet = PetDBSelectQuery.ExecuteScalar().ToString();

            //string sql1 = string.Format("DELETE FROM [PetDataBase].[dbo].[AdData] WHERE [IDPet] = '{0}'", sqlForIdPet);
            //using (SqlCommand cmd1 = new SqlCommand(sql1, connection))
            //{
            //    try
            //    {
            //        cmd1.ExecuteNonQuery();
                   
            //    }
            //    catch (SqlException ex)
            //    {
            //        Exception error = new Exception("Ошибка", ex);
            //        throw error;
            //    }
            //}

            MessageBox.Show("Объявление удалено");
            this.Close();
        }

        private void Change_Announcement(object sender, EventArgs e)
        {
            this.Hide();
            OpenChildForm(new Edit_ADForm());
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

            MyADsForm.panel.Controls.Add(childForm);
            MyADsForm.panel.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

    }
}
