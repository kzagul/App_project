
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
            this.buttonNewAD = new System.Windows.Forms.Button();
            this.adDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.petDBDataSet = new App_project.PetDBDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.задатьФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНаселенномуПунктуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поКатегорииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поИмениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.плиткаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реестрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.adDataTableAdapter = new App_project.PetDBDataSetTableAdapters.AdDataTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.adDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petDBDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNewAD
            // 
            this.buttonNewAD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNewAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewAD.Location = new System.Drawing.Point(742, 406);
            this.buttonNewAD.Name = "buttonNewAD";
            this.buttonNewAD.Size = new System.Drawing.Size(80, 80);
            this.buttonNewAD.TabIndex = 0;
            this.buttonNewAD.Text = "+";
            this.buttonNewAD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNewAD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonNewAD.UseVisualStyleBackColor = true;
            this.buttonNewAD.Click += new System.EventHandler(this.button1_Click);
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
            this.поКатегорииToolStripMenuItem,
            this.поИмениToolStripMenuItem});
            this.задатьФильтрToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.задатьФильтрToolStripMenuItem.Name = "задатьФильтрToolStripMenuItem";
            this.задатьФильтрToolStripMenuItem.Size = new System.Drawing.Size(99, 19);
            this.задатьФильтрToolStripMenuItem.Text = "Задать фильтр";
            // 
            // поНаселенномуПунктуToolStripMenuItem
            // 
            this.поНаселенномуПунктуToolStripMenuItem.Name = "поНаселенномуПунктуToolStripMenuItem";
            this.поНаселенномуПунктуToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.поНаселенномуПунктуToolStripMenuItem.Text = "По населенному пункту";
            // 
            // поКатегорииToolStripMenuItem
            // 
            this.поКатегорииToolStripMenuItem.Name = "поКатегорииToolStripMenuItem";
            this.поКатегорииToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.поКатегорииToolStripMenuItem.Text = "По категории";
            // 
            // поИмениToolStripMenuItem
            // 
            this.поИмениToolStripMenuItem.Name = "поИмениToolStripMenuItem";
            this.поИмениToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.поИмениToolStripMenuItem.Text = "По имени";
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
            this.плиткаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.плиткаToolStripMenuItem.Text = "Плитка";
            // 
            // реестрToolStripMenuItem
            // 
            this.реестрToolStripMenuItem.Name = "реестрToolStripMenuItem";
            this.реестрToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.реестрToolStripMenuItem.Text = "Реестр";
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
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 465);
            this.panel1.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(834, 465);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ADListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(834, 498);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNewAD);
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

        private System.Windows.Forms.Button buttonNewAD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem задатьФильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНаселенномуПунктуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поКатегорииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поИмениToolStripMenuItem;
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
    }
}