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
    public partial class Show_ADForm_ForADs : Form
    {
        public Show_ADForm_ForADs()
        {
            InitializeComponent();
            Show_DataInForm();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exit_button(object sender, EventArgs e)
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


        }
    }
}
