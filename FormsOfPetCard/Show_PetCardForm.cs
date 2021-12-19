using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_project
{
    public partial class Show_PetCardForm : Form
    {
        public Show_PetCardForm()
        {
            InitializeComponent();
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
            #region Поля texbox
            string categoryAnimal = CategoryAnimal.Text;

            string nickName = NickName.Text;

            string breed = Breed.Text;

            string passportNumber = PassportNumber.Text;

            string idUser = IDUser_key.global_IDUser;

            //string gender;

            string locality = Locality.Text;
            #endregion







        }
    }
}
