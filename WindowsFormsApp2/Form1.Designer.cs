namespace WindowsFormsApp2
{
    partial class Form1
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Dram = new System.Windows.Forms.CheckBox();
            this.Komedi = new System.Windows.Forms.CheckBox();
            this.Aksiyon = new System.Windows.Forms.CheckBox();
            this.Gerilim = new System.Windows.Forms.CheckBox();
            this.Bilim = new System.Windows.Forms.CheckBox();
            this.Fantastik = new System.Windows.Forms.CheckBox();
            this.EsaretinBedeli = new System.Windows.Forms.RadioButton();
            this.Idiots3 = new System.Windows.Forms.RadioButton();
            this.TheGoodFather = new System.Windows.Forms.RadioButton();
            this.FightClub = new System.Windows.Forms.RadioButton();
            this.Inception = new System.Windows.Forms.RadioButton();
            this.OlaganSupheliler = new System.Windows.Forms.RadioButton();
            this.Eklebtn = new System.Windows.Forms.Button();
            this.btntur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(30, 24);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(306, 448);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_SelectedNode);
            // 
            // Dram
            // 
            this.Dram.AutoSize = true;
            this.Dram.Location = new System.Drawing.Point(640, 24);
            this.Dram.Name = "Dram";
            this.Dram.Size = new System.Drawing.Size(64, 21);
            this.Dram.TabIndex = 2;
            this.Dram.Text = "Dram";
            this.Dram.UseVisualStyleBackColor = true;
            // 
            // Komedi
            // 
            this.Komedi.AutoSize = true;
            this.Komedi.Location = new System.Drawing.Point(785, 24);
            this.Komedi.Name = "Komedi";
            this.Komedi.Size = new System.Drawing.Size(77, 21);
            this.Komedi.TabIndex = 3;
            this.Komedi.Text = "Komedi";
            this.Komedi.UseVisualStyleBackColor = true;
            // 
            // Aksiyon
            // 
            this.Aksiyon.AutoSize = true;
            this.Aksiyon.Location = new System.Drawing.Point(640, 64);
            this.Aksiyon.Name = "Aksiyon";
            this.Aksiyon.Size = new System.Drawing.Size(79, 21);
            this.Aksiyon.TabIndex = 4;
            this.Aksiyon.Text = "Aksiyon";
            this.Aksiyon.UseVisualStyleBackColor = true;
            // 
            // Gerilim
            // 
            this.Gerilim.AutoSize = true;
            this.Gerilim.Location = new System.Drawing.Point(785, 64);
            this.Gerilim.Name = "Gerilim";
            this.Gerilim.Size = new System.Drawing.Size(74, 21);
            this.Gerilim.TabIndex = 5;
            this.Gerilim.Text = "Gerilim";
            this.Gerilim.UseVisualStyleBackColor = true;
            // 
            // Bilim
            // 
            this.Bilim.AutoSize = true;
            this.Bilim.Location = new System.Drawing.Point(640, 108);
            this.Bilim.Name = "Bilim";
            this.Bilim.Size = new System.Drawing.Size(101, 21);
            this.Bilim.TabIndex = 6;
            this.Bilim.Text = "Bilim Kurgu";
            this.Bilim.UseVisualStyleBackColor = true;
            // 
            // Fantastik
            // 
            this.Fantastik.AutoSize = true;
            this.Fantastik.Location = new System.Drawing.Point(785, 109);
            this.Fantastik.Name = "Fantastik";
            this.Fantastik.Size = new System.Drawing.Size(87, 21);
            this.Fantastik.TabIndex = 7;
            this.Fantastik.Text = "Fantastik";
            this.Fantastik.UseVisualStyleBackColor = true;
            // 
            // EsaretinBedeli
            // 
            this.EsaretinBedeli.AutoSize = true;
            this.EsaretinBedeli.Location = new System.Drawing.Point(447, 24);
            this.EsaretinBedeli.Name = "EsaretinBedeli";
            this.EsaretinBedeli.Size = new System.Drawing.Size(124, 21);
            this.EsaretinBedeli.TabIndex = 8;
            this.EsaretinBedeli.TabStop = true;
            this.EsaretinBedeli.Text = "Esaretin Bedeli";
            this.EsaretinBedeli.UseVisualStyleBackColor = true;
            // 
            // Idiots3
            // 
            this.Idiots3.AutoSize = true;
            this.Idiots3.Location = new System.Drawing.Point(447, 64);
            this.Idiots3.Name = "Idiots3";
            this.Idiots3.Size = new System.Drawing.Size(74, 21);
            this.Idiots3.TabIndex = 9;
            this.Idiots3.TabStop = true;
            this.Idiots3.Text = "3 İdiots";
            this.Idiots3.UseVisualStyleBackColor = true;
            // 
            // TheGoodFather
            // 
            this.TheGoodFather.AutoSize = true;
            this.TheGoodFather.Location = new System.Drawing.Point(447, 108);
            this.TheGoodFather.Name = "TheGoodFather";
            this.TheGoodFather.Size = new System.Drawing.Size(134, 21);
            this.TheGoodFather.TabIndex = 10;
            this.TheGoodFather.TabStop = true;
            this.TheGoodFather.Text = "The GoodFather";
            this.TheGoodFather.UseVisualStyleBackColor = true;
            // 
            // FightClub
            // 
            this.FightClub.AutoSize = true;
            this.FightClub.Location = new System.Drawing.Point(447, 151);
            this.FightClub.Name = "FightClub";
            this.FightClub.Size = new System.Drawing.Size(92, 21);
            this.FightClub.TabIndex = 11;
            this.FightClub.TabStop = true;
            this.FightClub.Text = "Fight Club";
            this.FightClub.UseVisualStyleBackColor = true;
            // 
            // Inception
            // 
            this.Inception.AutoSize = true;
            this.Inception.Location = new System.Drawing.Point(447, 195);
            this.Inception.Name = "Inception";
            this.Inception.Size = new System.Drawing.Size(86, 21);
            this.Inception.TabIndex = 12;
            this.Inception.TabStop = true;
            this.Inception.Text = "Inception";
            this.Inception.UseVisualStyleBackColor = true;
            // 
            // OlaganSupheliler
            // 
            this.OlaganSupheliler.AutoSize = true;
            this.OlaganSupheliler.Location = new System.Drawing.Point(447, 239);
            this.OlaganSupheliler.Name = "OlaganSupheliler";
            this.OlaganSupheliler.Size = new System.Drawing.Size(142, 21);
            this.OlaganSupheliler.TabIndex = 13;
            this.OlaganSupheliler.TabStop = true;
            this.OlaganSupheliler.Text = "Olağan Şüpheliler";
            this.OlaganSupheliler.UseVisualStyleBackColor = true;
            // 
            // Eklebtn
            // 
            this.Eklebtn.Location = new System.Drawing.Point(447, 303);
            this.Eklebtn.Name = "Eklebtn";
            this.Eklebtn.Size = new System.Drawing.Size(134, 41);
            this.Eklebtn.TabIndex = 14;
            this.Eklebtn.Text = "Film Ekle";
            this.Eklebtn.UseVisualStyleBackColor = true;
            this.Eklebtn.Click += new System.EventHandler(this.Eklebtn_Click);
            // 
            // btntur
            // 
            this.btntur.Location = new System.Drawing.Point(738, 303);
            this.btntur.Name = "btntur";
            this.btntur.Size = new System.Drawing.Size(134, 41);
            this.btntur.TabIndex = 15;
            this.btntur.Text = "Tür Ekle";
            this.btntur.UseVisualStyleBackColor = true;
            this.btntur.Click += new System.EventHandler(this.btntur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 501);
            this.Controls.Add(this.btntur);
            this.Controls.Add(this.Eklebtn);
            this.Controls.Add(this.OlaganSupheliler);
            this.Controls.Add(this.Inception);
            this.Controls.Add(this.FightClub);
            this.Controls.Add(this.TheGoodFather);
            this.Controls.Add(this.Idiots3);
            this.Controls.Add(this.EsaretinBedeli);
            this.Controls.Add(this.Fantastik);
            this.Controls.Add(this.Bilim);
            this.Controls.Add(this.Gerilim);
            this.Controls.Add(this.Aksiyon);
            this.Controls.Add(this.Komedi);
            this.Controls.Add(this.Dram);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Filmler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckBox Dram;
        private System.Windows.Forms.CheckBox Komedi;
        private System.Windows.Forms.CheckBox Aksiyon;
        private System.Windows.Forms.CheckBox Gerilim;
        private System.Windows.Forms.CheckBox Bilim;
        private System.Windows.Forms.CheckBox Fantastik;
        private System.Windows.Forms.RadioButton EsaretinBedeli;
        private System.Windows.Forms.RadioButton Idiots3;
        private System.Windows.Forms.RadioButton TheGoodFather;
        private System.Windows.Forms.RadioButton FightClub;
        private System.Windows.Forms.RadioButton Inception;
        private System.Windows.Forms.RadioButton OlaganSupheliler;
        private System.Windows.Forms.Button Eklebtn;
        private System.Windows.Forms.Button btntur;
    }
}

