using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace App_project
{ 
//{
//    public class ListPetCards
//    {
//        List<PetCard> petList;

//        public ListPetCards()
//        {
//            //Конструктор
//        }

//        //Просмотр списка карточек ДЖ
//        public void LoadPetList(ListView list)
//        {

//            string connection = DataBase.PetDBConnectionString;
//            DataBase.LinkDataBase();


//            list.GridLines = false;
//            list.View = View.Details;


//            SqlConnection connection2 = DataBase.LinkDataBase();

//            string sql = "Select NickName, Category, Breed, PassportNumber from [PetDataBase].[dbo].[PetData] WHERE [IDUser] = '" + IDUser_key.global_IDUser + "'";
//            SqlConnection cnn = new SqlConnection(connection);
//            cnn.Open();
//            SqlCommand cmd = new SqlCommand(sql, cnn);
//            SqlDataReader Reader = cmd.ExecuteReader();

//            SqlCommand cmdPhoto = new SqlCommand("SELECT [Photo] FROM [PetDataBase].[dbo].[PetData] WHERE [IDUser] = '" + IDUser_key.global_IDUser + "'", connection2);
//            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdPhoto);
//            DataSet dataSet = new DataSet();
//            dataAdapter.Fill(dataSet);

//            list.Items.Clear();

//            ImageList imagelist = new ImageList();
//            imagelist.ImageSize = new Size(50, 50);
//            //if (dataSet.Tables[0].Rows.Count == 1)
//            //{

//            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
//            {
//                Byte[] data = new Byte[0];
//                data = (Byte[])(dataSet.Tables[0].Rows[i]["Photo"]);
//                MemoryStream mem = new MemoryStream(data);

//                imagelist.Images.Add(Image.FromStream(mem));
//            }

//            //}
//            list.SmallImageList = imagelist;
//            var nick = new List<string>();
//            var category = new List<string>();
//            var breed = new List<string>();
//            var passportn = new List<string>();

//            while (Reader.Read())
//            {
//                nick.Add(Reader.GetString(0));
//                category.Add(Reader.GetString(1));
//                breed.Add(Reader.GetString(2));
//                passportn.Add(Convert.ToString(Reader.GetInt32(3)));
//            }

//            for (int i = 0; i < category.Count; i++)
//            {
//                ListViewItem lst = new ListViewItem(new string[] { "", nick[i], category[i], breed[i], passportn[i] });
//                lst.ImageIndex = i;
//                list.Items.Add(lst);
//            }

//            Reader.Close();
//            cnn.Close();


//        }

//        //СДЕЛАНО
//        //+
//        //Экспорт записей реестра карточек домашних животных в Microsoft Excel
//        public void ExportPetRegisterExcel(ListView list)
//        {
//            string fileName = "C:\\Users\\kirillzagul\\Downloads\\ Список_карточек.xlsx";
//            try
//            {
//                var excel = new Excel.Application();

//                var workBooks = excel.Workbooks;
//                var workBook = workBooks.Add();
//                var workSheet = (Excel.Worksheet)excel.ActiveSheet;
//                workSheet.Columns[1].ColumnWidth = 30;
//                workSheet.Columns[2].ColumnWidth = 30;
//                workSheet.Columns[3].ColumnWidth = 30;
//                workSheet.Columns[4].ColumnWidth = 30;
//                var excelcells = workSheet.get_Range("A1", "D1");
//                excelcells.Borders.ColorIndex = 3;
//                //workSheet.Cells.Borders[].Weight = Excel.XlBorderWeight.xlThin;
//                //workSheet.Cells[1, "A"].Border.Weight = Excel.XlBorderWeight.xlThin;
//                //workSheet.Cells[1, "A"].Border.LineStyle =Excel.XlLineStyle.xlContinuous;
//                //workSheet.Cells[1, "A"].Border.ColorIndex = 0;
//                workSheet.Cells.Style.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
//                workSheet.Cells[1, "A"] = "Кличка";
//                workSheet.Cells[1, "B"] = "Вид";
//                workSheet.Cells[1, "C"] = "Порода";
//                workSheet.Cells[1, "D"] = "Номер паспорта";
//                for (int i = 0; i < list.Items.Count; i++)
//                {
//                    workSheet.Cells[i + 2, "A"] = list.Items[i].SubItems[1].Text;
//                    workSheet.Cells[i + 2, "B"] = list.Items[i].SubItems[2].Text;
//                    workSheet.Cells[i + 2, "C"] = list.Items[i].SubItems[3].Text;
//                    workSheet.Cells[i + 2, "D"] = list.Items[i].SubItems[4].Text;
//                }

//                //workSheet.Cells[6, "A"] = "Фото";
//                //workSheet.Cells[6, "B"] = pictureBox1.ImageLocation;
//                workBook.SaveAs(fileName);
//                workBook.Close();

               
//            }
//            catch (Exception ex)
//            {
//                //MessageBox.Show("Ошибка: " + ex.ToString());
//            }
//        }
    
//    }
}
