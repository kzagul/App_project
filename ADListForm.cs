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
    public partial class ADListForm : Form
    {
        public ADListForm()
        {
            InitializeComponent();
            listView1.MouseDoubleClick += new MouseEventHandler(listView1_MouseDoubleClick);
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

        private void AddNewAD_Button(object sender, EventArgs e)
        {
           //Body.OpenChildForm(new MakeNewADForm());
            //panelChildForm.Visible = true;
        }

        private void ADListForm_Load(object sender, EventArgs e)
        {

            //соединение с базой
            string connection = DataBase.PetDBConnectionString;
            DataBase.LinkDataBase();

            ListView list = listView1;

            Controller.LoadADList(list);

        }


        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            IDPetCard_key.global_PetCardPassport = listView1.SelectedItems[0].SubItems[7].Text;
            OpenChildForm(new Show_ADForm_ForMyADs());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void реестрToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //
        private void поКатегорииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filtr = toolStripTextBox1.Text;
            //for(int i=0;i<listView1.Items.Count;i++)
            //{
            //    if (listView1.Items[i].SubItems[2].Text != filtr)
            //        listView1.Items.Remove(listView1.Items[i]);
            //}
            string connection = DataBase.PetDBConnectionString;
            DataBase.LinkDataBase();

            listView1.GridLines = false;
            listView1.View = View.Details;

            SqlConnection connection2 = DataBase.LinkDataBase();

            string sql = "Select NickName, Category, Breed, PassportNumber from [PetDataBase].[dbo].[PetData] WHERE [IDUser] = '" + IDUser_key.global_IDUser + "' AND [Category] = '" + filtr + "'";
            SqlConnection cnn = new SqlConnection(connection);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();

            SqlCommand cmdPhoto = new SqlCommand("SELECT [Photo] FROM [PetDataBase].[dbo].[PetData] WHERE [Category] = '" + filtr + "'", connection2);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdPhoto);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            listView1.Items.Clear();

            ImageList imagelist = new ImageList();
            imagelist.ImageSize = new Size(50, 50);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(dataSet.Tables[0].Rows[i]["Photo"]);
                MemoryStream mem = new MemoryStream(data);

                imagelist.Images.Add(Image.FromStream(mem));
            }

            listView1.SmallImageList = imagelist;
            var nick = new List<string>();
            var category = new List<string>();
            var breed = new List<string>();
            var passportn = new List<string>();

            while (Reader.Read())
            {
                nick.Add(Reader.GetString(0));
                category.Add(Reader.GetString(1));
                breed.Add(Reader.GetString(2));
                passportn.Add(Convert.ToString(Reader.GetInt32(3)));
            }

            for (int i = 0; i < category.Count; i++)
            {
                ListViewItem lst = new ListViewItem(new string[] { "", nick[i], category[i], breed[i], passportn[i] });
                lst.ImageIndex = i;
                listView1.Items.Add(lst);
            }

            Reader.Close();
            cnn.Close();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Renew_button(object sender, EventArgs e)
        {
            ADListForm_Load(sender, e);
        }
    }
}
