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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petDBDataSet.AdData". При необходимости она может быть перемещена или удалена.
            // this.adDataTableAdapter.Fill(this.petDBDataSet.AdData);

            //соединение с базой
            //string connection = DataBase.PetDBConnectionString;
            //DataBase.LinkDataBase();

            //listView1.GridLines = false;
            //listView1.View = View.SmallIcon;

            ////string sql = "SELECT NickName, Category, LocalityOfMissing FROM [PetDataBase].[dbo].[PetData] LEFT JOIN [PetDataBase].[dbo].[AdData] ON [PetDataBase].[dbo].[PetData].IDPet = [PetDataBase].[dbo].[AdData].IDPet  WHERE [PetDataBase].[dbo].[PetData].[IDUser] = '" + IDUser_key.global_IDUser + "'";

            //string sql = "Select IDAd, IDPet, LocalityOfMissing from [PetDataBase].[dbo].[AdData] INNER JOIN [PetDataBase].[dbo].[PetData] ON [PetDataBase].[dbo].[PetData].IDPet = [PetDataBase].[dbo].[AdData].IDPet";
            ////WHERE[IDUser] = '" + IDUser_key.global_IDUser + "'";
            //SqlConnection cnn = new SqlConnection(connection);
            //cnn.Open();
            //SqlCommand cmd = new SqlCommand(sql, cnn);
            //SqlDataReader Reader = cmd.ExecuteReader();

            //listView1.Items.Clear();

            //while (Reader.Read())
            //{
            //    ListViewItem lv = new ListViewItem(Reader.GetString(0));
            //    lv.SubItems.Add(Reader.GetString(1));
            //    //lv.SubItems.Add(Reader.GetString(2));
            //    listView1.Items.Add(lv);
            //    //perem = Convert.ToString(Reader.GetInt32(3));
            //}
            //Reader.Close();
            //cnn.Close();





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

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            IDPetCard_key.global_IDPetCard = listView1.SelectedItems[0].SubItems[3].Text;
            OpenChildForm(new Show_PetCardForm());
            //MessageBox.Show(IDPetCard_key.global_IDPetCard);

            //var epa = listView1.SelectedItems[]
        }
    }
}
