using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace App_project
{
    public class ADList
    {
        //конструктор
        public ADList()
        {
        }

        //Просмотр списка объявлений
        public void LoadADList(ListView list)
        {
            //соединение с базой
            string connection = DataBase.PetDBConnectionString;
            DataBase.LinkDataBase();

            list.GridLines = false;
            list.View = View.Details;
            //string sql = "Select IDAd, [PetDataBase].[dbo].[AdData].IDPet, Locality from [PetDataBase].[dbo].[AdData] LEFT JOIN [PetDataBase].[dbo].[PetData] ON [PetDataBase].[dbo].[PetData].IDUser = [PetDataBase].[dbo].[AdData].IDUser WHERE [PetDataBase].[dbo].[AdData].IDUser = '" + IDUser_key.global_IDUser + "'";

            string sql = "Select PostDate, DateOfMissing, LocalityOfMissing from [PetDataBase].[dbo].[AdData]";

            string sql2 = "Select NickName, Category, Breed, PassportNumber from [PetDataBase].[dbo].[PetData]";

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



            //photo
            SqlCommand cmdPhoto = new SqlCommand("SELECT [Photo] FROM [PetDataBase].[dbo].[PetData]", DataBase.LinkDataBase());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdPhoto);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            list.Items.Clear();

            ImageList imagelist = new ImageList();
            imagelist.ImageSize = new Size(50, 50);

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

            //PostDate, DateOfMissing, LocalityOfMissing
            var postDate = new List<string>();
            var dateOfMissing = new List<string>();
            var localityOfMissing = new List<string>();
            var passportNumber = new List<string>();

            while (Reader2.Read() && Reader.Read())
            {
                nick.Add(Reader2.GetString(0));
                category.Add(Reader2.GetString(1));
                breed.Add(Reader2.GetString(2));

                postDate.Add(Reader.GetString(0));
                dateOfMissing.Add(Reader.GetString(1));
                localityOfMissing.Add(Reader.GetString(2));
                passportNumber.Add(Convert.ToString(Reader2.GetInt32(3)));
            }

            for (int i = 0; i < category.Count; i++)
            {
                ListViewItem lst = new ListViewItem(new string[] { "", nick[i], category[i], breed[i], postDate[i], dateOfMissing[i], localityOfMissing[i], passportNumber[i] });
                lst.ImageIndex = i;
                list.Items.Add(lst);
            }

            Reader.Close();
            cnn.Close();
            Reader2.Close();
            cnn2.Close();

        }
    }
}
