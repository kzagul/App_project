
namespace App_project
{
    partial class Show_PetCardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_PetCardForm));
            this.label2 = new System.Windows.Forms.Label();
            this.NickName = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.PassportNumber = new System.Windows.Forms.TextBox();
            this.DateOfRegistration = new System.Windows.Forms.TextBox();
            this.Breed = new System.Windows.Forms.TextBox();
            this.FIO = new System.Windows.Forms.TextBox();
            this.DateOfBirth = new System.Windows.Forms.TextBox();
            this.Locality = new System.Windows.Forms.TextBox();
            this.CategoryAnimal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Кличка *";
            // 
            // NickName
            // 
            this.NickName.Location = new System.Drawing.Point(104, 263);
            this.NickName.Name = "NickName";
            this.NickName.ReadOnly = true;
            this.NickName.Size = new System.Drawing.Size(123, 20);
            this.NickName.TabIndex = 48;
            this.NickName.TextChanged += new System.EventHandler(this.NickName_TextChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(461, 132);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(36, 17);
            this.radioButton2.TabIndex = 47;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ж";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(406, 132);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(34, 17);
            this.radioButton1.TabIndex = 46;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "М";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // PassportNumber
            // 
            this.PassportNumber.Location = new System.Drawing.Point(657, 170);
            this.PassportNumber.Name = "PassportNumber";
            this.PassportNumber.ReadOnly = true;
            this.PassportNumber.Size = new System.Drawing.Size(100, 20);
            this.PassportNumber.TabIndex = 45;
            this.PassportNumber.TextChanged += new System.EventHandler(this.PassportNumber_TextChanged);
            // 
            // DateOfRegistration
            // 
            this.DateOfRegistration.Location = new System.Drawing.Point(657, 129);
            this.DateOfRegistration.Name = "DateOfRegistration";
            this.DateOfRegistration.ReadOnly = true;
            this.DateOfRegistration.Size = new System.Drawing.Size(100, 20);
            this.DateOfRegistration.TabIndex = 44;
            this.DateOfRegistration.TextChanged += new System.EventHandler(this.DateOfRegistration_TextChanged);
            // 
            // Breed
            // 
            this.Breed.Location = new System.Drawing.Point(657, 86);
            this.Breed.Name = "Breed";
            this.Breed.ReadOnly = true;
            this.Breed.Size = new System.Drawing.Size(100, 20);
            this.Breed.TabIndex = 43;
            this.Breed.TextChanged += new System.EventHandler(this.Breed_TextChanged);
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(406, 263);
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            this.FIO.Size = new System.Drawing.Size(351, 20);
            this.FIO.TabIndex = 42;
            this.FIO.TextChanged += new System.EventHandler(this.FIO_textbox);
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Location = new System.Drawing.Point(406, 217);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            this.DateOfBirth.Size = new System.Drawing.Size(100, 20);
            this.DateOfBirth.TabIndex = 41;
            this.DateOfBirth.TextChanged += new System.EventHandler(this.DateOfBirth_TextChanged);
            // 
            // Locality
            // 
            this.Locality.Location = new System.Drawing.Point(406, 170);
            this.Locality.Name = "Locality";
            this.Locality.ReadOnly = true;
            this.Locality.Size = new System.Drawing.Size(123, 20);
            this.Locality.TabIndex = 40;
            this.Locality.TextChanged += new System.EventHandler(this.Locality_TextChanged);
            // 
            // CategoryAnimal
            // 
            this.CategoryAnimal.Location = new System.Drawing.Point(406, 86);
            this.CategoryAnimal.Name = "CategoryAnimal";
            this.CategoryAnimal.ReadOnly = true;
            this.CategoryAnimal.Size = new System.Drawing.Size(123, 20);
            this.CategoryAnimal.TabIndex = 39;
            this.CategoryAnimal.TextChanged += new System.EventHandler(this.CategoryAnimal_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(550, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Номер паспорта *";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(550, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Дата регистрации:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(550, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Порода *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "ФИО владельца:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Дата рождения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Населенный пункт *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Пол животного *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Вид животного *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(344, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Основные характеристики животного";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(776, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 25);
            this.button4.TabIndex = 50;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.CloseThisForm_Button);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(224, 295);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(389, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Поля, помеченные звездочкой *, обязательны для заполнения!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 42);
            this.button1.TabIndex = 51;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Edit_PetCard_Button);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 41);
            this.button2.TabIndex = 55;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Delete_PetCard_Button);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(529, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 42);
            this.button3.TabIndex = 56;
            this.button3.Text = "Экспорт в Excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ExportToExcel_PetCard);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(679, 313);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(87, 42);
            this.button8.TabIndex = 57;
            this.button8.Text = "Экспорт в Word";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ExportToWord_PetCard);
            // 
            // Show_PetCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(869, 459);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NickName);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.PassportNumber);
            this.Controls.Add(this.DateOfRegistration);
            this.Controls.Add(this.Breed);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.Locality);
            this.Controls.Add(this.CategoryAnimal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Show_PetCardForm";
            this.Text = "Delete_PetCardForm";
            this.Load += new System.EventHandler(this.Show_PetCardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NickName;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox PassportNumber;
        private System.Windows.Forms.TextBox DateOfRegistration;
        private System.Windows.Forms.TextBox Breed;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.TextBox DateOfBirth;
        private System.Windows.Forms.TextBox Locality;
        private System.Windows.Forms.TextBox CategoryAnimal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button8;
    }
}