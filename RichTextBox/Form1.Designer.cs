namespace RichTextBox
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeşilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diğerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kalınToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altıÇiziliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boyutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnFontSec = new System.Windows.Forms.Button();
            this.btnSolaYasla = new System.Windows.Forms.Button();
            this.btnOrtala = new System.Windows.Forms.Button();
            this.btnSagaYasla = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnRenkDegistir = new System.Windows.Forms.Button();
            this.menuDosya = new System.Windows.Forms.MenuStrip();
            this.menuItemYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAç = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.menuDosya.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Location = new System.Drawing.Point(16, 102);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(613, 494);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renkToolStripMenuItem,
            this.görünümToolStripMenuItem,
            this.boyutToolStripMenuItem,
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 176);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // renkToolStripMenuItem
            // 
            this.renkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sarıToolStripMenuItem,
            this.maviToolStripMenuItem,
            this.yeşilToolStripMenuItem,
            this.diğerToolStripMenuItem});
            this.renkToolStripMenuItem.Name = "renkToolStripMenuItem";
            this.renkToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.renkToolStripMenuItem.Text = "Renk";
            // 
            // sarıToolStripMenuItem
            // 
            this.sarıToolStripMenuItem.Name = "sarıToolStripMenuItem";
            this.sarıToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.sarıToolStripMenuItem.Text = "Sarı";
            this.sarıToolStripMenuItem.Click += new System.EventHandler(this.sarıToolStripMenuItem_Click);
            // 
            // maviToolStripMenuItem
            // 
            this.maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            this.maviToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.maviToolStripMenuItem.Text = "Mavi";
            this.maviToolStripMenuItem.Click += new System.EventHandler(this.maviToolStripMenuItem_Click);
            // 
            // yeşilToolStripMenuItem
            // 
            this.yeşilToolStripMenuItem.Name = "yeşilToolStripMenuItem";
            this.yeşilToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.yeşilToolStripMenuItem.Text = "Yeşil";
            this.yeşilToolStripMenuItem.Click += new System.EventHandler(this.yeşilToolStripMenuItem_Click);
            // 
            // diğerToolStripMenuItem
            // 
            this.diğerToolStripMenuItem.Name = "diğerToolStripMenuItem";
            this.diğerToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.diğerToolStripMenuItem.Text = "Diğer";
            this.diğerToolStripMenuItem.Click += new System.EventHandler(this.diğerToolStripMenuItem_Click);
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kalınToolStripMenuItem,
            this.italikToolStripMenuItem,
            this.altıÇiziliToolStripMenuItem});
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // kalınToolStripMenuItem
            // 
            this.kalınToolStripMenuItem.CheckOnClick = true;
            this.kalınToolStripMenuItem.Name = "kalınToolStripMenuItem";
            this.kalınToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.kalınToolStripMenuItem.Text = "Kalın";
            this.kalınToolStripMenuItem.Click += new System.EventHandler(this.kalınToolStripMenuItem_Click);
            // 
            // italikToolStripMenuItem
            // 
            this.italikToolStripMenuItem.CheckOnClick = true;
            this.italikToolStripMenuItem.Name = "italikToolStripMenuItem";
            this.italikToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.italikToolStripMenuItem.Text = "İtalik";
            this.italikToolStripMenuItem.Click += new System.EventHandler(this.italikToolStripMenuItem_Click);
            // 
            // altıÇiziliToolStripMenuItem
            // 
            this.altıÇiziliToolStripMenuItem.CheckOnClick = true;
            this.altıÇiziliToolStripMenuItem.Name = "altıÇiziliToolStripMenuItem";
            this.altıÇiziliToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.altıÇiziliToolStripMenuItem.Text = "Altı Çizili";
            this.altıÇiziliToolStripMenuItem.Click += new System.EventHandler(this.altıÇiziliToolStripMenuItem_Click);
            // 
            // boyutToolStripMenuItem
            // 
            this.boyutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripTextBox1});
            this.boyutToolStripMenuItem.Name = "boyutToolStripMenuItem";
            this.boyutToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.boyutToolStripMenuItem.Text = "Boyut";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuItem2.Text = "8";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuItem3.Text = "10";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuItem4.Text = "12";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem.Click += new System.EventHandler(this.yapıştırToolStripMenuItem_Click);
            // 
            // btnFontSec
            // 
            this.btnFontSec.Location = new System.Drawing.Point(16, 55);
            this.btnFontSec.Margin = new System.Windows.Forms.Padding(4);
            this.btnFontSec.Name = "btnFontSec";
            this.btnFontSec.Size = new System.Drawing.Size(100, 28);
            this.btnFontSec.TabIndex = 1;
            this.btnFontSec.Text = "Font Seç";
            this.btnFontSec.UseVisualStyleBackColor = true;
            this.btnFontSec.Click += new System.EventHandler(this.btnFontSec_Click);
            // 
            // btnSolaYasla
            // 
            this.btnSolaYasla.Location = new System.Drawing.Point(153, 55);
            this.btnSolaYasla.Margin = new System.Windows.Forms.Padding(4);
            this.btnSolaYasla.Name = "btnSolaYasla";
            this.btnSolaYasla.Size = new System.Drawing.Size(100, 28);
            this.btnSolaYasla.TabIndex = 2;
            this.btnSolaYasla.Text = "Sola Yasla";
            this.btnSolaYasla.UseVisualStyleBackColor = true;
            this.btnSolaYasla.Click += new System.EventHandler(this.btnSolaYasla_Click);
            // 
            // btnOrtala
            // 
            this.btnOrtala.Location = new System.Drawing.Point(261, 55);
            this.btnOrtala.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrtala.Name = "btnOrtala";
            this.btnOrtala.Size = new System.Drawing.Size(100, 28);
            this.btnOrtala.TabIndex = 3;
            this.btnOrtala.Text = "Ortala";
            this.btnOrtala.UseVisualStyleBackColor = true;
            this.btnOrtala.Click += new System.EventHandler(this.btnOrtala_Click);
            // 
            // btnSagaYasla
            // 
            this.btnSagaYasla.Location = new System.Drawing.Point(369, 55);
            this.btnSagaYasla.Margin = new System.Windows.Forms.Padding(4);
            this.btnSagaYasla.Name = "btnSagaYasla";
            this.btnSagaYasla.Size = new System.Drawing.Size(100, 28);
            this.btnSagaYasla.TabIndex = 4;
            this.btnSagaYasla.Text = "Sağa Yasla";
            this.btnSagaYasla.UseVisualStyleBackColor = true;
            this.btnSagaYasla.Click += new System.EventHandler(this.btnSagaYasla_Click);
            // 
            // btnRenkDegistir
            // 
            this.btnRenkDegistir.Location = new System.Drawing.Point(531, 55);
            this.btnRenkDegistir.Margin = new System.Windows.Forms.Padding(4);
            this.btnRenkDegistir.Name = "btnRenkDegistir";
            this.btnRenkDegistir.Size = new System.Drawing.Size(100, 28);
            this.btnRenkDegistir.TabIndex = 5;
            this.btnRenkDegistir.Text = "Renk";
            this.btnRenkDegistir.UseVisualStyleBackColor = true;
            this.btnRenkDegistir.Click += new System.EventHandler(this.btnRenkDegistir_Click);
            // 
            // menuDosya
            // 
            this.menuDosya.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuDosya.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemYeni,
            this.menuItemAç,
            this.kaydetToolStripMenuItem});
            this.menuDosya.Location = new System.Drawing.Point(0, 0);
            this.menuDosya.Name = "menuDosya";
            this.menuDosya.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuDosya.Size = new System.Drawing.Size(647, 28);
            this.menuDosya.TabIndex = 6;
            this.menuDosya.Text = "Dosya";
            // 
            // menuItemYeni
            // 
            this.menuItemYeni.Name = "menuItemYeni";
            this.menuItemYeni.Size = new System.Drawing.Size(48, 24);
            this.menuItemYeni.Text = "Yeni";
            this.menuItemYeni.Click += new System.EventHandler(this.menuItemYeni_Click);
            // 
            // menuItemAç
            // 
            this.menuItemAç.Name = "menuItemAç";
            this.menuItemAç.Size = new System.Drawing.Size(38, 24);
            this.menuItemAç.Text = "Aç";
            this.menuItemAç.Click += new System.EventHandler(this.menuItemAç_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 612);
            this.Controls.Add(this.btnRenkDegistir);
            this.Controls.Add(this.btnSagaYasla);
            this.Controls.Add(this.btnOrtala);
            this.Controls.Add(this.btnSolaYasla);
            this.Controls.Add(this.btnFontSec);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuDosya);
            this.MainMenuStrip = this.menuDosya;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuDosya.ResumeLayout(false);
            this.menuDosya.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnFontSec;
        private System.Windows.Forms.Button btnSolaYasla;
        private System.Windows.Forms.Button btnOrtala;
        private System.Windows.Forms.Button btnSagaYasla;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnRenkDegistir;
        private System.Windows.Forms.MenuStrip menuDosya;
        private System.Windows.Forms.ToolStripMenuItem menuItemYeni;
        private System.Windows.Forms.ToolStripMenuItem menuItemAç;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem renkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeşilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diğerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kalınToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altıÇiziliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boyutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
    }
}

