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
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace App_project
{
    public partial class Show_PetCardForm : Form
    {
        public Show_PetCardForm()
        {
            InitializeComponent();
            Show_DataInForm();
        }

        private void Delete_PetCardForm_Load(object sender, EventArgs e)
        {

        }

        private void CloseThisForm_Button(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_PetCard_Button(object sender, EventArgs e)
        {
            OpenChildForm(new Edit_PetCardForm());
        }

        private void Delete_PetCard_Button(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Карточка удалена");
            Controller.DeletePetCard(IDPetCard_key.global_IDPetCard);

            //dataGridView1.Rows.Remove(SelectedRows);
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



        public void Show_DataInForm()
        {
            string id_key = IDPetCard_key.global_IDPetCard;

            SqlConnection connection = DataBase.LinkDataBase();

            Controller.ShowPetCard(id_key);

            //CategoryAnimal.Text;

            void fullData() {
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

                //Breed
                SqlCommand cmbBreed = new SqlCommand("SELECT [Breed] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);

                SqlDataReader thisReaderBreed = cmbBreed.ExecuteReader();
                string res2 = string.Empty;
                while (thisReaderBreed.Read())
                {
                    res2 += thisReaderBreed["Breed"];
                }
                thisReaderBreed.Close();
                Breed.Text = res2;

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

                //FIO


                string Fio = FIO.Text;

                //string SQLCheckLogin = "SELECT [Сategory] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'";


                //string nickName = NickName.Text;

                //string breed = Breed.Text;

                PassportNumber.Text = id_key;

                //string idUser = IDUser_key.global_IDUser;

                //string gender = "male";

                //string locality = Locality.Text;


                //Controller.ShowPetCard(id_key);


            }

            fullData();

            //Image ConvertByteArrayToImage(byte[] data)
            //{
            //    using (MemoryStream ms = new MemoryStream(data))
            //    {
            //        return Image.FromStream(ms);
            //    }
            //}


            //IDPetCard_key.global_IDPetCard;
            //MessageBox.Show(IDPetCard_key.global_IDPetCard);
        }

        //-
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CategoryAnimal_TextChanged(object sender, EventArgs e)
        {
            CategoryAnimal.ReadOnly = true;
        }

        private void Breed_TextChanged(object sender, EventArgs e)
        {
            Breed.ReadOnly = true;
        }

        private void Locality_TextChanged(object sender, EventArgs e)
        {
            Locality.ReadOnly = true;
        }

        private void PassportNumber_TextChanged(object sender, EventArgs e)
        {
            PassportNumber.ReadOnly = true;
        }

        private void NickName_TextChanged(object sender, EventArgs e)
        {
            NickName.ReadOnly = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel1.Parent = this;
        }

        private void ExportToExcel_PetCard(object sender, EventArgs e)
        {
            string nick = NickName.Text;
            string fileName = "C:\\Users\\kirillzagul\\Downloads\\" + nick + ".xlsx";

            try
            {
                var excel = new Excel.Application();

                var workBooks = excel.Workbooks;
                var workBook = workBooks.Add();
                var workSheet = (Excel.Worksheet)excel.ActiveSheet;
                workSheet.Columns[1].ColumnWidth = 30;
                workSheet.Columns[2].ColumnWidth = 30;
                var excelcells = workSheet.get_Range("A1", "A5");
                excelcells.Borders.ColorIndex = 3;
                workSheet.Cells.Style.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                workSheet.Cells[1, "A"] = "Кличка";
                workSheet.Cells[1, "B"] = NickName.Text;
                workSheet.Cells[2, "A"] = "Вид животного";
                workSheet.Cells[2, "B"] = CategoryAnimal.Text;
                workSheet.Cells[3, "A"] = "Порода";
                workSheet.Cells[3, "B"] = Breed.Text;
                workSheet.Cells[4, "A"] = "Населённый пункт";
                workSheet.Cells[4, "B"] = Locality.Text;
                workSheet.Cells[5, "A"] = "Номер паспорта";
                workSheet.Cells[5, "B"] = PassportNumber.Text;
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

        private void ExportToWord_PetCard(object sender, EventArgs e)
        {
            string nick = NickName.Text;


            // Создаём объект документа
            Word.Document doc = null;
            try
            {
                Word.Application winword = new Word.Application();

                winword.Visible = false;
                object missing = System.Reflection.Missing.Value;

                //Создание нового документа
                Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                //добавление новой страницы
                winword.Selection.InsertNewPage();
                document.Content.SetRange(0, 0);
                document.Content.Text = "Кличка: " + NickName.Text + Environment.NewLine
                    + "Вид животного: " + CategoryAnimal.Text + Environment.NewLine
                     + "Порода: " + Breed.Text + Environment.NewLine
                     + "Населённый пункт: " + Locality.Text + Environment.NewLine
                     + "Номер паспорта: " + PassportNumber.Text + Environment.NewLine;
                //document.Content.Text = CategoryAnimal.Text + Environment.NewLine;
                //winword.Visible = true;

                //Сохранение документа
                object filename = "C:\\Users\\kirillzagul\\Downloads\\" + nick + ".docx";
                document.SaveAs(ref filename);
                //Закрытие текущего документа
                document.Close(ref missing, ref missing, ref missing);
                document = null;
                //Закрытие приложения Word
                winword.Quit(ref missing, ref missing, ref missing);
                winword = null;
                MessageBox.Show("Успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //-
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
