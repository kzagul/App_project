
namespace App_project
{
    partial class ADListForm
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
            this.components = new System.ComponentModel.Container();
            this.adDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.petDBDataSet = new App_project.PetDBDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.задатьФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНаселенномуПунктуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.поКатегорииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.плиткаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реестрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.adDataTableAdapter = new App_project.PetDBDataSetTableAdapters.AdDataTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petDBDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adDataBindingSource
            // 
            this.adDataBindingSource.DataMember = "AdData";
            this.adDataBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.petDBDataSet;
            this.bindingSource1.Position = 0;
            // 
            // petDBDataSet
            // 
            this.petDBDataSet.DataSetName = "PetDBDataSet";
            this.petDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задатьФильтрToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // задатьФильтрToolStripMenuItem
            // 
            this.задатьФильтрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНаселенномуПунктуToolStripMenuItem,
            this.toolStripTextBox1,
            this.поКатегорииToolStripMenuItem});
            this.задатьФильтрToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.задатьФильтрToolStripMenuItem.Name = "задатьФильтрToolStripMenuItem";
            this.задатьФильтрToolStripMenuItem.Size = new System.Drawing.Size(99, 19);
            this.задатьФильтрToolStripMenuItem.Text = "Задать фильтр";
            // 
            // поНаселенномуПунктуToolStripMenuItem
            // 
            this.поНаселенномуПунктуToolStripMenuItem.Name = "поНаселенномуПунктуToolStripMenuItem";
            this.поНаселенномуПунктуToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.поНаселенномуПунктуToolStripMenuItem.Text = "Введите вид животного";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // поКатегорииToolStripMenuItem
            // 
            this.поКатегорииToolStripMenuItem.Name = "поКатегорииToolStripMenuItem";
            this.поКатегорииToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.поКатегорииToolStripMenuItem.Text = "Поиск";
            this.поКатегорииToolStripMenuItem.Click += new System.EventHandler(this.поКатегорииToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.плиткаToolStripMenuItem,
            this.реестрToolStripMenuItem});
            this.toolStripMenuItem1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(116, 19);
            this.toolStripMenuItem1.Text = "Вид отображения";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // плиткаToolStripMenuItem
            // 
            this.плиткаToolStripMenuItem.Name = "плиткаToolStripMenuItem";
            this.плиткаToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.плиткаToolStripMenuItem.Text = "Плитка";
            // 
            // реестрToolStripMenuItem
            // 
            this.реестрToolStripMenuItem.Name = "реестрToolStripMenuItem";
            this.реестрToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.реестрToolStripMenuItem.Text = "Список";
            this.реестрToolStripMenuItem.Click += new System.EventHandler(this.реестрToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(314, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Доска объявлений";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // adDataTableAdapter
            // 
            this.adDataTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 364);
            this.panel1.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(5);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(834, 330);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Фото";
            this.columnHeader1.Width = 121;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Кличка";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Вид животного";
            this.columnHeader3.Width = 147;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Порода";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Дата размещения";
            this.columnHeader5.Width = 118;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Дата пропажи";
            this.columnHeader6.Width = 122;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Место пропажи";
            this.columnHeader7.Width = 113;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Renew_button);
            // 
            // ADListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(834, 498);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ADListForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ADListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petDBDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem задатьФильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНаселенномуПунктуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поКатегорииToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private PetDBDataSet petDBDataSet;
        private System.Windows.Forms.BindingSource adDataBindingSource;
        private PetDBDataSetTableAdapters.AdDataTableAdapter adDataTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem плиткаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реестрToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Button button1;
    }
}