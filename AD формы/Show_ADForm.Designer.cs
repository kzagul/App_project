
namespace App_project
{
    partial class Show_ADForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_ADForm));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.Locality = new System.Windows.Forms.TextBox();
            this.DateOfPosting = new System.Windows.Forms.TextBox();
            this.CategoryAnimal = new System.Windows.Forms.TextBox();
            this.NickName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DateOfMissing = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.GenderBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(794, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.GenderBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.DateOfMissing);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Locality);
            this.panel1.Controls.Add(this.DateOfPosting);
            this.panel1.Controls.Add(this.CategoryAnimal);
            this.panel1.Controls.Add(this.NickName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(46, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 282);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Разместить объявление";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Add_AD);
            // 
            // Locality
            // 
            this.Locality.Location = new System.Drawing.Point(573, 146);
            this.Locality.Name = "Locality";
            this.Locality.ReadOnly = true;
            this.Locality.Size = new System.Drawing.Size(136, 20);
            this.Locality.TabIndex = 10;
            this.Locality.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // DateOfPosting
            // 
            this.DateOfPosting.Location = new System.Drawing.Point(573, 91);
            this.DateOfPosting.Name = "DateOfPosting";
            this.DateOfPosting.ReadOnly = true;
            this.DateOfPosting.Size = new System.Drawing.Size(136, 20);
            this.DateOfPosting.TabIndex = 9;
            this.DateOfPosting.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // CategoryAnimal
            // 
            this.CategoryAnimal.Location = new System.Drawing.Point(290, 91);
            this.CategoryAnimal.Name = "CategoryAnimal";
            this.CategoryAnimal.ReadOnly = true;
            this.CategoryAnimal.Size = new System.Drawing.Size(121, 20);
            this.CategoryAnimal.TabIndex = 7;
            this.CategoryAnimal.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // NickName
            // 
            this.NickName.Location = new System.Drawing.Point(379, 13);
            this.NickName.Name = "NickName";
            this.NickName.ReadOnly = true;
            this.NickName.Size = new System.Drawing.Size(100, 20);
            this.NickName.TabIndex = 6;
            this.NickName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(436, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Населенный пункт";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(436, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Дата размещения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(178, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пол животного";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(178, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вид животного";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кличка";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DateOfMissing
            // 
            this.DateOfMissing.Location = new System.Drawing.Point(573, 201);
            this.DateOfMissing.Name = "DateOfMissing";
            this.DateOfMissing.Size = new System.Drawing.Size(136, 20);
            this.DateOfMissing.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(436, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Дата пропажи";
            // 
            // GenderBox
            // 
            this.GenderBox.Location = new System.Drawing.Point(291, 146);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.ReadOnly = true;
            this.GenderBox.Size = new System.Drawing.Size(120, 20);
            this.GenderBox.TabIndex = 14;
            // 
            // Show_ADForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(834, 353);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Show_ADForm";
            this.Text = "Show_ADForm";
            this.Load += new System.EventHandler(this.Show_ADForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Locality;
        private System.Windows.Forms.TextBox DateOfPosting;
        private System.Windows.Forms.TextBox CategoryAnimal;
        private System.Windows.Forms.TextBox NickName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateOfMissing;
        private System.Windows.Forms.TextBox GenderBox;
    }
}