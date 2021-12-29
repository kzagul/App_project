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
    public partial class Edit_ADForm : Form
    {
        public Edit_ADForm()
        {
            InitializeComponent();
            Show_DataInForm();
        }

        private void Exit_Button(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_ADForm_Load(object sender, EventArgs e)
        {

        }

        private void Save_Button(object sender, EventArgs e)
        {
            string localityOfMissing = Locality.Text;

            string postDate = PostDate.Value.Date.ToString("dd-MM-yyyy");//

            string dateOfMissing = DateOfMissing.Value.Date.ToString("dd-MM-yyyy");

            SqlConnection connection = DataBase.LinkDataBase();

            string sql = string.Format("Update AdData Set PostDate = '{1}', LocalityOfMissing = '{2}', DateOfMissing = '{3}' Where IDPet = '{0}'",
            IDPetCard_key.GetGlobalPetCardID(), postDate, localityOfMissing, dateOfMissing);
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.ExecuteNonQuery();
            }

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

                //DateOfPosting
                //DateOfPosting.Text = DateTime.Now.Date.ToString("dd-MM-yyyy");

                SqlCommand cmdDateOfPost = new SqlCommand("SELECT [PostDate] FROM [PetDataBase].[dbo].[AdData] WHERE [IDPet] = '" + IDPetCard_key.GetGlobalPetCardID() + "'", connection);

                SqlDataReader thisReaderDateOfPost = cmdDateOfPost.ExecuteReader();
                string res6 = string.Empty;
                while (thisReaderDateOfPost.Read())
                {
                    res6 += thisReaderDateOfPost["PostDate"];
                }
                thisReaderDateOfPost.Close();
                PostDate.Text = res6;

                //DateOfMissing
                //DateOfPosting.Text = DateTime.Now.Date.ToString("dd-MM-yyyy");

                SqlCommand cmdDateOfMissing = new SqlCommand("SELECT [DateOfMissing] FROM [PetDataBase].[dbo].[AdData] WHERE [IDPet] = '" + IDPetCard_key.GetGlobalPetCardID() + "'", connection);

                SqlDataReader thisReaderDateOfMissing = cmdDateOfMissing.ExecuteReader();
                string res7 = string.Empty;
                while (thisReaderDateOfMissing.Read())
                {
                    res7 += thisReaderDateOfMissing["DateOfMissing"];
                }
                thisReaderDateOfMissing.Close();
                DateOfMissing.Text = res7;
            }

            fullData();

        }
    }
}
