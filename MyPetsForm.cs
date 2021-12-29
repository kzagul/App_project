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
using Excel = Microsoft.Office.Interop.Excel;

namespace App_project
{
    public partial class MyPetsForm : Form
    {

        public static Panel panel;

        public MyPetsForm()
        {
            InitializeComponent();
            listView1.MouseDoubleClick += new MouseEventHandler(listView1_MouseDoubleClick);
            panel = panel1;
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


            SqlConnection connection2 = DataBase.LinkDataBase();

            string sql = "Select NickName, Category, Breed, PassportNumber from [PetDataBase].[dbo].[PetData] WHERE [IDUser] = '" + IDUser_key.global_IDUser + "'";
            SqlConnection cnn = new SqlConnection(connection);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();

            SqlCommand cmdPhoto = new SqlCommand("SELECT [Photo] FROM [PetDataBase].[dbo].[PetData] WHERE [IDUser] = '" + IDUser_key.global_IDUser + "'", connection2);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdPhoto);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            listView1.Items.Clear();

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


        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            IDPetCard_key.global_PetCardPassport = listView1.SelectedItems[0].SubItems[4].Text;
            OpenChildForm(new Show_PetCardForm());
            //MessageBox.Show(IDPetCard_key.global_IDPetCard);

            //var epa = listView1.SelectedItems[]
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyPetsForm_Load(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Export_PetCardlist(object sender, EventArgs e)
        {
            string fileName = "C:\\Users\\kirillzagul\\Downloads\\ Список_карточек.xlsx";

            try
            {
                var excel = new Excel.Application();

                var workBooks = excel.Workbooks;
                var workBook = workBooks.Add();
                var workSheet = (Excel.Worksheet)excel.ActiveSheet;
                workSheet.Columns[1].ColumnWidth = 30;
                workSheet.Columns[2].ColumnWidth = 30;
                workSheet.Columns[3].ColumnWidth = 30;
                workSheet.Columns[4].ColumnWidth = 30;
                var excelcells = workSheet.get_Range("A1", "D1");
                excelcells.Borders.ColorIndex = 3;
                //workSheet.Cells.Borders[].Weight = Excel.XlBorderWeight.xlThin;
                //workSheet.Cells[1, "A"].Border.Weight = Excel.XlBorderWeight.xlThin;
                //workSheet.Cells[1, "A"].Border.LineStyle =Excel.XlLineStyle.xlContinuous;
                //workSheet.Cells[1, "A"].Border.ColorIndex = 0;
                workSheet.Cells.Style.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                workSheet.Cells[1, "A"] = "Кличка";
                workSheet.Cells[1, "B"] = "Вид";
                workSheet.Cells[1, "C"] = "Порода";
                workSheet.Cells[1, "D"] = "Номер паспорта";
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    workSheet.Cells[i + 2, "A"] = listView1.Items[i].SubItems[1].Text;
                    workSheet.Cells[i + 2, "B"] = listView1.Items[i].SubItems[2].Text;
                    workSheet.Cells[i + 2, "C"] = listView1.Items[i].SubItems[3].Text;
                    workSheet.Cells[i + 2, "D"] = listView1.Items[i].SubItems[4].Text;
                }

                //workSheet.Cells[6, "A"] = "Фото";
                //workSheet.Cells[6, "B"] = pictureBox1.ImageLocation;
                workBook.SaveAs(fileName);
                workBook.Close();

                MessageBox.Show("Файл " + Path.GetFileName(fileName) + " записан успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }
        }

        private void списокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void плиткаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
