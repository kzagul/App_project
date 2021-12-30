using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static App_project.Controller;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;


namespace App_project
{

    //
    //Карточка ДЖ
    //
    public class PetCard
    {
        #region Конструктор
        public PetCard()
        {

        }
        #endregion


        //СДЕЛАНО
        //Просмотр карточки ДЖ
        //+
        public List<string> ShowPetCard()
        {
            SqlConnection connection = DataBase.LinkDataBase();

            string id_key = IDPetCard_key.global_PetCardPassport;

            var list = new List<string>();

            //Category
            SqlCommand cmdCategory = new SqlCommand("SELECT [Category] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);

            SqlDataReader thisReaderCategory = cmdCategory.ExecuteReader();
            string res1 = string.Empty;
            while (thisReaderCategory.Read())
            {
                res1 += thisReaderCategory["Category"];
            }
            thisReaderCategory.Close();
            list.Add(res1);

            //Breed
            SqlCommand cmbBreed = new SqlCommand("SELECT [Breed] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);

            SqlDataReader thisReaderBreed = cmbBreed.ExecuteReader();
            string res2 = string.Empty;
            while (thisReaderBreed.Read())
            {
                res2 += thisReaderBreed["Breed"];
            }
            thisReaderBreed.Close();
            list.Add(res2);

            //NickName
            SqlCommand cmdNickName = new SqlCommand("SELECT [NickName] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);

            SqlDataReader thisReaderNickName = cmdNickName.ExecuteReader();
            string res3 = string.Empty;
            while (thisReaderNickName.Read())
            {
                res3 += thisReaderNickName["NickName"];
            }
            thisReaderNickName.Close();
            list.Add(res3);

            //Locality
            SqlCommand cmdLocality = new SqlCommand("SELECT [Locality] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);

            SqlDataReader thisReaderLocality = cmdLocality.ExecuteReader();
            string res4 = string.Empty;
            while (thisReaderLocality.Read())
            {
                res4 += thisReaderLocality["Locality"];
            }
            thisReaderLocality.Close();
            list.Add(res4);

            

            //FIO
            SqlCommand cmdFIO_ID = new SqlCommand("SELECT [IDUser] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);
            var thisUserID = cmdFIO_ID.ExecuteScalar().ToString();

            SqlCommand cmdName = new SqlCommand("SELECT [Name] FROM [PetDataBase].[dbo].[User] WHERE [IDUser] = '" + thisUserID + "'", connection);
            var thisUserName = cmdName.ExecuteScalar().ToString();
            SqlCommand cmdSurname = new SqlCommand("SELECT [Surname] FROM [PetDataBase].[dbo].[User] WHERE [IDUser] = '" + thisUserID + "'", connection);
            var thisUserSurname = cmdSurname.ExecuteScalar().ToString();
            SqlCommand cmdSecondName = new SqlCommand("SELECT [SecondName] FROM [PetDataBase].[dbo].[User] WHERE [IDUser] = '" + thisUserID + "'", connection);
            var thisUserSecondName = cmdSecondName.ExecuteScalar().ToString();

            var FullName = thisUserSurname + " " + thisUserName + " " + thisUserSecondName;

            list.Add(FullName);


            //DateOfBirth
            SqlCommand cmdDateOfBirth = new SqlCommand("SELECT [DateOfBirth] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);

            SqlDataReader thisReaderDateOfBirth = cmdDateOfBirth.ExecuteReader();
            string res6 = string.Empty;
            while (thisReaderDateOfBirth.Read())
            {
                res6 += thisReaderDateOfBirth["DateOfBirth"];
            }
            thisReaderDateOfBirth.Close();
            list.Add(res6);

            //RegistrationdDate
            SqlCommand cmdRegistrationdDate = new SqlCommand("SELECT [RegistrationdDate] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);

            SqlDataReader thisReaderRegistrationdDate = cmdRegistrationdDate.ExecuteReader();
            string res7 = string.Empty;
            while (thisReaderRegistrationdDate.Read())
            {
                res7 += thisReaderRegistrationdDate["RegistrationdDate"];
            }
            thisReaderRegistrationdDate.Close();
            list.Add(res7);


            //PassportNumber
            list.Add(id_key);


            return list;
        }




        //СДЕЛАНО
        //Добавление карточки ДЖ
        //+ 
        public void AddNewPetCard(string category,
                       string nickName,
                       string breed,
                       int passportNumber, //unique
                       string idUser,
                       string gender,
                       string locality,
                       string photo,
                       string dateOfBirth,
                       string registrationDate
            )
        {
            SqlConnection connection = DataBase.LinkDataBase();

            SqlCommand cmd = new SqlCommand("INSERT INTO[PetDataBase].[dbo].[PetData](Category, NickName, Breed, PassportNumber, IDUser, Gender, Locality, Photo, DateOfBirth, RegistrationdDate) VALUES (@Category, @NickName, @Breed, @PassportNumber, @IDUser, @Gender, @Locality, @Photo, @DateOfBirth, @RegistrationdDate)", connection);

            //проверка на уникальность passportNumber
            string SQLCheckLogin = "SELECT [PassportNumber] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + passportNumber + "'";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(SQLCheckLogin, DataBase.PetDBConnectionString))
            {
                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                byte[] images = null;
                FileStream stream = new FileStream(photo, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);

                if (table.Rows.Count == 0) 
                {

                    //добавление в БД в PetCard
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@NickName", nickName);
                    cmd.Parameters.AddWithValue("@Breed", breed);
                    cmd.Parameters.AddWithValue("@PassportNumber", passportNumber);
                    cmd.Parameters.AddWithValue("@IDUser", idUser);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Locality", locality);
                    cmd.Parameters.AddWithValue("@Photo", images);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    cmd.Parameters.AddWithValue("@RegistrationdDate", registrationDate);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Что-то пошло не так!");
                    }
                    finally
                    {
                        connection.Close();
                    }


                    MessageBox.Show("Карточка успешно добавлена!");

                }
                else
                {
                    MessageBox.Show("Не корректные данные проверьте правильность заполнения полей и уникальность номера паспорта");
                }
            }
        }



        //СДЕЛАНО
        //+
        //Редактирование карточки ДЖ
        public void EditPetCard(string categoryAnimal,
                                        string nickName,
                                        string breed,
                                        string passportNumber,
                                        string idUser,
                                        string dateOfBirth,
                                        string registrationDate,
                                        string gender,
                                        string locality
                                       
            )

        {
            //byte[] images = null;
            //FileStream stream = new FileStream(photo, FileMode.Open, FileAccess.Read);
            //BinaryReader brs = new BinaryReader(stream);
            //images = brs.ReadBytes((int)stream.Length);

            //подключение базы
            SqlConnection connection = DataBase.LinkDataBase();


            string sql = string.Format("Update PetData Set NickName = '{1}', Category = '{2}', DateOfBirth = '{3}', Breed = '{4}', RegistrationdDate = '{5}', PassportNumber = '{6}', Gender = '{7}', Locality = '{8}' Where IDPet = '{0}'",
            IDPetCard_key.GetGlobalPetCardID(), nickName, categoryAnimal, dateOfBirth, breed, registrationDate, passportNumber, gender, locality);
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.ExecuteNonQuery();
            }

            //string sql = string.Format("Update PetData Set NickName = '{1}', Category = '{2}', DateOfBirth = '{3}', Breed = '{4}', RegistrationdDate = '{5}', PassportNumber = '{6}', Photo = '{7}', Gender = '{8}', Locality = '{9}' Where IDPet = '{0}'",
            //IDPetCard_key.GetGlobalPetCardID(), nickName, categoryAnimal, dateOfBirth, breed, registrationDate, passportNumber, images, gender, locality);
            //using (SqlCommand cmd = new SqlCommand(sql, connection))
            //{
            //    cmd.ExecuteNonQuery();
            //}
        }




        //СДЕЛАНО
        //+
        //Удаление карточки о пропаже домашнего животного
        public void DeletePetCard(string idCard)
        {
            SqlConnection connection = DataBase.LinkDataBase();

            var PetDBSelectQuery = new SqlCommand("SELECT [IDPet] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + idCard + "'", connection);
            var sqlForIdPet = PetDBSelectQuery.ExecuteScalar().ToString();

            string sql1 = string.Format("DELETE FROM [PetDataBase].[dbo].[AdData] WHERE [IDPet] = '{0}'", sqlForIdPet);
            using (SqlCommand cmd1 = new SqlCommand(sql1, connection))
            {
                try
                {
                    cmd1.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Ошибка", ex);
                    throw error;
                }
            }



            string sql = string.Format("DELETE FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '{0}'", idCard);
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Exception error = new Exception("Ошибка", ex);
                        throw error;
                    }
                }

        }






        //СДЕЛАНО
        //+
        //Сформировать паспорт домашнего животного в Microsoft Word
        public void Export2WordPetCard(string nickName, string categoryAnimal, string breed, string locality, string passportNumber, string dateofbirth, string dateofregistration, string fio, string gender)
        {
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
                document.Content.Text = "Кличка: " + nickName + Environment.NewLine
                    + "Вид животного: " + categoryAnimal + Environment.NewLine
                     + "Порода: " + breed + Environment.NewLine
                     + "Населённый пункт: " + locality + Environment.NewLine
                      + "Номер паспорта: " + passportNumber + Environment.NewLine
                      + "Пол: " + gender + Environment.NewLine
                      + "Дата рождения: " + dateofbirth + Environment.NewLine
                      + "Дата регистрации: " + dateofregistration + Environment.NewLine
                      + "Ф.И.О.: " + fio + Environment.NewLine;
                //document.Content.Text = CategoryAnimal.Text + Environment.NewLine;
                //winword.Visible = true;

                //Сохранение документа
                object filename = "C:\\Users\\kirillzagul\\Downloads\\" + nickName + ".docx";
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




        //сДЕЛАНО
        //+
        //Экспорт карточки домашнего животного в Microsoft Excel
        public void Export2ExcelPetCard(string nickName, string categoryAnimal, string breed, string locality, string passportNumber, string dateofbirth, string dateofregistration, string fio, string gender)
        {
            //throw new NotImplementedException();
            string fileName = "C:\\Users\\kirillzagul\\Downloads\\" + nickName + ".xlsx";

            try
            {
                var excel = new Excel.Application();

                var workBooks = excel.Workbooks;
                var workBook = workBooks.Add();
                var workSheet = (Excel.Worksheet)excel.ActiveSheet;
                workSheet.Columns[1].ColumnWidth = 30;
                workSheet.Columns[2].ColumnWidth = 30;
                var excelcells = workSheet.get_Range("A1", "A9");
                excelcells.Borders.ColorIndex = 3;
                workSheet.Cells.Style.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                workSheet.Cells.NumberFormat = "@";
                workSheet.Cells[1, "A"] = "Кличка";
                workSheet.Cells[1, "B"] = nickName;
                workSheet.Cells[2, "A"] = "Вид животного";
                workSheet.Cells[2, "B"] = categoryAnimal;
                workSheet.Cells[3, "A"] = "Порода";
                workSheet.Cells[3, "B"] = breed;
                workSheet.Cells[4, "A"] = "Населённый пункт";
                workSheet.Cells[4, "B"] = locality;
                workSheet.Cells[5, "A"] = "Номер паспорта";
                workSheet.Cells[5, "B"] = passportNumber;
                workSheet.Cells[6, "A"] = "Пол";
                workSheet.Cells[6, "B"] = gender;
                workSheet.Cells[7, "A"] = "Дата рождения";
                workSheet.Cells[7, "B"] = dateofbirth;
                workSheet.Cells[8, "A"] = "Дата регистрации";
                workSheet.Cells[8, "B"] = dateofregistration;
                workSheet.Cells[9, "A"] = "Ф.И.О.";
                workSheet.Cells[9, "B"] = fio;
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


        //////////////////



        //СДЕЛАНО
        //+
        //Просмотр списка карточек ДЖ
        public void LoadPetList(ListView list)
        {

            string connection = DataBase.PetDBConnectionString;
            DataBase.LinkDataBase();


            list.GridLines = false;
            list.View = View.Details;


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

            list.Items.Clear();

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
            list.SmallImageList = imagelist;
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
                list.Items.Add(lst);
            }

            Reader.Close();
            cnn.Close();


        }



        //СДЕЛАНО
        //+
        //Экспорт записей реестра карточек домашних животных в Microsoft Excel
        public void ExportPetRegisterExcel(ListView list)
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
                for (int i = 0; i < list.Items.Count; i++)
                {
                    workSheet.Cells[i + 2, "A"] = list.Items[i].SubItems[1].Text;
                    workSheet.Cells[i + 2, "B"] = list.Items[i].SubItems[2].Text;
                    workSheet.Cells[i + 2, "C"] = list.Items[i].SubItems[3].Text;
                    workSheet.Cells[i + 2, "D"] = list.Items[i].SubItems[4].Text;
                }

                //workSheet.Cells[6, "A"] = "Фото";
                //workSheet.Cells[6, "B"] = pictureBox1.ImageLocation;
                workBook.SaveAs(fileName);
                workBook.Close();


            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ошибка: " + ex.ToString());
            }
        }



    }
}
