using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_project
{
    public partial class MyADsForm : Form
    {
        public MyADsForm()
        {
            InitializeComponent();
            listView1.MouseDoubleClick += new MouseEventHandler(listView1_MouseDoubleClick);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MyADsForm_Load(object sender, EventArgs e)
        {
            //соединение с базой
            string connection = DataBase.PetDBConnectionString;
            DataBase.LinkDataBase();

            listView1.GridLines = false;
            listView1.View = View.Details;
            //string sql = "Select IDAd, [PetDataBase].[dbo].[AdData].IDPet, Locality from [PetDataBase].[dbo].[AdData] LEFT JOIN [PetDataBase].[dbo].[PetData] ON [PetDataBase].[dbo].[PetData].IDUser = [PetDataBase].[dbo].[AdData].IDUser WHERE [PetDataBase].[dbo].[AdData].IDUser = '" + IDUser_key.global_IDUser + "'";

            string sql = "Select PostDate, DateOfMissing, LocalityOfMissing from [PetDataBase].[dbo].[AdData] WHERE [IDUser] = '" + IDUser_key.global_IDUser + "'";

            string sql2 = "Select NickName, Category, Breed from [PetDataBase].[dbo].[PetData] WHERE [IDUser] = '" + IDUser_key.global_IDUser + "'";

            //для sql1
            SqlConnection cnn = new SqlConnection(connection);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();

            //для sql2
            SqlConnection cnn2 = new SqlConnection(connection);
            cnn2.Open();
            SqlCommand cmd2 = new SqlCommand(sql2, cnn2);
            SqlDataReader Reader2 = cmd2.ExecuteReader();

            listView1.Items.Clear();

            while (Reader2.Read()&& Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader2.GetString(0));
                lv.SubItems.Add(Reader2.GetString(1));
                lv.SubItems.Add(Reader2.GetString(2));
                lv.SubItems.Add(Reader.GetString(0));
                lv.SubItems.Add(Reader.GetString(1));
                lv.SubItems.Add(Reader.GetString(2));
                listView1.Items.Add(lv);
                //perem = Convert.ToString(Reader.GetInt32(3));
            }
            Reader.Close();
            cnn.Close();
            Reader2.Close();
            cnn2.Close();

            //string sql = "Select IDAd, IDPet, LocalityOfMissing from [PetDataBase].[dbo].[AdData] INNER JOIN [PetDataBase].[dbo].[PetData] ON [PetDataBase].[dbo].[PetData].IDPet = [PetDataBase].[dbo].[AdData].IDPet";


            //соединение с базой
            //string connection = DataBase.PetDBConnectionString;
            //DataBase.LinkDataBase();

            //listView1.GridLines = false;
            //listView1.View = View.Details;

            //string sql = "Select NickName, Category, Locality, PassportNumber from [PetDataBase].[dbo].[PetData] WHERE [IDUser] = '" + IDUser_key.global_IDUser + "'";
            //SqlConnection cnn = new SqlConnection(connection);
            //cnn.Open();
            //SqlCommand cmd = new SqlCommand(sql, cnn);
            //SqlDataReader Reader = cmd.ExecuteReader();

            //listView1.Items.Clear();

            //while (Reader.Read())
            //{
            //    ListViewItem lv = new ListViewItem(Reader.GetString(0));
            //    lv.SubItems.Add(Reader.GetString(1));
            //    lv.SubItems.Add(Reader.GetString(2));
            //    lv.SubItems.Add(Convert.ToString(Reader.GetInt32(3)));
            //    listView1.Items.Add(lv);
            //    //perem = Convert.ToString(Reader.GetInt32(3));
            //}
            //Reader.Close();
            //cnn.Close();

            //var selectIDPet_PetCard = new SqlCommand("Select IDPet from [PetDataBase].[dbo].[PetData] WHERE [IDUser] = '" + IDUser_key.global_IDUser + "'", connection);
            //var selectorIDPet = selectIDPet_PetCard.ExecuteScalar().ToString();

            ////var SelectQuery = "SELECT EXISTS (SELECT IDPet FROM [PetDataBase].[dbo].[PetData] WHERE login ='" + selectorIDPet + "')";

            //string SelectQuery = "Select IDPet from [PetDataBase].[dbo].[AdData] WHERE [IDPet] = '" + selectorIDPet + "'";


        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            IDPetCard_key.global_IDPetCard = listView1.SelectedItems[0].SubItems[3].Text;
            OpenChildForm(new Show_ADForm());
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

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

            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }
    }
}
