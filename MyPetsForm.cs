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

            string sql = "Select NickName, Category, Breed, PassportNumber from [PetDataBase].[dbo].[PetData]";
            SqlConnection cnn = new SqlConnection(connection);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();

            listView1.Items.Clear();

            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetString(0));
                lv.SubItems.Add(Reader.GetString(1));
                lv.SubItems.Add(Reader.GetString(2));
                lv.SubItems.Add(Convert.ToString(Reader.GetInt32(3)));
                listView1.Items.Add(lv);
                //perem = Convert.ToString(Reader.GetInt32(3));
            }
            Reader.Close();
            cnn.Close();
        }


        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            IDPetCard_key.global_IDPetCard = listView1.SelectedItems[0].SubItems[3].Text;
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
