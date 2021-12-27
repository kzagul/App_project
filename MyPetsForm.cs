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
using System.IO;

namespace App_project
{
    public partial class MyPetsForm : Form
    {
        public MyPetsForm()
        {
            InitializeComponent();
            listView1.MouseDoubleClick += new MouseEventHandler(listView1_MouseDoubleClick);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Add_PetCardForm());
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

            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }


        private void MyPetsForm_Load(object sender, EventArgs e)
        {
            string connection = DataBase.PetDBConnectionString;
            DataBase.LinkDataBase();
            
            listView1.GridLines = false;
            listView1.View = View.Details;

            //Add Column Header

            //listView1.Columns.Add("Employee ID", 150);
            //listView1.Columns.Add("First Name", 150);
            //listView1.Columns.Add("Last Name", 150);
            SqlConnection connection2 = DataBase.LinkDataBase();
            string sql = "Select NickName, Category, Breed, PassportNumber from [PetDataBase].[dbo].[PetData]";
            SqlConnection cnn = new SqlConnection(connection);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();

            SqlCommand cmdPhoto = new SqlCommand("SELECT [Photo] FROM [PetDataBase].[dbo].[PetData]", connection2);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdPhoto);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            //if (dataSet.Tables[0].Rows.Count == 1)
            //{
            //    Byte[] data = new Byte[0];
            //    data = (Byte[])(dataSet.Tables[0].Rows[0]["Photo"]);
            //    MemoryStream mem = new MemoryStream(data);
            //    pictureBox1.Image = Image.FromStream(mem);
            //}

            listView1.Items.Clear();
            //int i= 0;
            ImageList imagelist = new ImageList();
            imagelist.ImageSize = new Size(50, 50);
            //if (dataSet.Tables[0].Rows.Count == 1)
            //{
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(dataSet.Tables[0].Rows[i]["Photo"]);
                MemoryStream mem = new MemoryStream(data);

                imagelist.Images.Add(Image.FromStream(mem));
            }
               
            //}
            listView1.SmallImageList = imagelist;
            var nick = new List<string>();
            var category = new List<string>();
            var breed = new List<string>();
            var passportn = new List<string>();
            while (Reader.Read())
            {
                //i++;
                //ListViewItem lv = new ListViewItem(Reader.GetString(0));
                nick.Add(Reader.GetString(0));
                category.Add(Reader.GetString(1));
                breed.Add(Reader.GetString(2));
                passportn.Add(Convert.ToString(Reader.GetInt32(3)));
                //lv.SubItems.Add(Reader.GetString(1));
                //lv.SubItems.Add(Reader.GetString(2));
                //lv.SubItems.Add(Convert.ToString(Reader.GetInt32(3)));
                

                //listView1.Items.Add(lv);
                //perem = Convert.ToString(Reader.GetInt32(3));
            }
            for(int i=0;i<category.Count;i++)
            {
                ListViewItem lst = new ListViewItem(new string[] { "",nick[i],category[i],breed[i],passportn[i]});
                lst.ImageIndex = i;
                listView1.Items.Add(lst);
            }
            Reader.Close();
            cnn.Close();
        }


        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            IDPetCard_key.global_IDPetCard = listView1.SelectedItems[0].SubItems[4].Text;
            OpenChildForm(new Show_PetCardForm());
            //MessageBox.Show(IDPetCard_key.global_IDPetCard);

            //var epa = listView1.SelectedItems[]
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Add_PetCardForm());

            MessageBox.Show("Выберете карточку животного");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
