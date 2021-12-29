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
    public partial class Show_ADForm : Form
    {
        public Show_ADForm()
        {
            InitializeComponent();
            Show_DataInForm();
        }


        public void Show_DataInForm()
        {
            string id_key = IDPetCard_key.global_PetCardPassport;

            SqlConnection connection = DataBase.LinkDataBase();

            string categoryAnimal = "";

            string nickName = "";

            string locality = "";

            //Image img;

            string dateOfPosting = "";

            string gender = "";

            var list = Controller.ShowAD();

           

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

            CategoryAnimal.Text = list[0];
            NickName.Text = list[1];
            Locality.Text = list[2];

            DateOfPosting.Text = list[3];
            GenderBox.Text = list[4];




        }





        private void Show_ADForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            NickName.ReadOnly = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CategoryAnimal.ReadOnly = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Gender.ReadOnly = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            DateOfPosting.ReadOnly = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Locality.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_AD(object sender, EventArgs e)
        {
            #region Поля texbox
            string idPetCard = IDPetCard_key.GetGlobalPetCardID();
            string locality = Locality.Text;
            string missingDate = DateOfMissing.Value.Date.ToString("dd-MM-yyyy");
            string postDate = DateTime.Now.Date.ToString("dd-MM-yyyy");
            #endregion

            Controller.AddNewAnnouncement(idPetCard, locality, missingDate, postDate);

            MessageBox.Show("Карточка добавлена в объявления");
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
