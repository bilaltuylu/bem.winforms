using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //pictureBox1.Image();
        }

        private int selectedRowIndex = -1;
        private bool isUpdate;

        private void btnEkle_Click(object sender, EventArgs e)
        {

           

         var kisi = new ListViewItem (new[] {"", $"{ txtAd.Text}",$" {txtSoyad.Text}",$" {txtKimlikNo.Text}",$"{txtUzmanlik.Text}" });

            if (progressBar1.Value != 100)
            {
                MessageBox.Show("Lüüüütfeenn Alanları Doldurunuzz!!");
                return;
            }
            string key = Guid.NewGuid().ToString();
            ımageList1.Images.Add(key,pictureBox1.Image);
            //  kisi.ImageIndex = ımageList1.Images.Count - 1;
            kisi.ImageKey = key;

            if (isUpdate)
            {
               listView1.Items[selectedRowIndex]=kisi;
            }
            else
            {
                listView1.Items.Add(kisi);
            }

            txtAd.Text = "";
            txtSoyad.Text = "";
            txtKimlikNo.Text = "";
            txtUzmanlik.Text = "";
            pictureBox1.Image = null;
            isUpdate = false;
            progressBar1.Value = 0;

            

        }

        //private void lstKisi_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (lstKisi.SelectedItem is null)
        //    {
        //        return;
        //    }

        //    Kisi gelenKisi = lstKisi.SelectedItem as Kisi;

        //    txtAd.Text = gelenKisi.Ad;
        //    txtSoyad.Text = gelenKisi.Soyad;
        //    txtKimlikNo.Text = gelenKisi.TcKimlikNo;
        //    txtUzmanlik.Text = gelenKisi.Uzmanlik;

        //    isUpdate = true;
        //}

        //private void chkAktif_CheckedChanged(object sender, EventArgs e)
        //{
          
        //}

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            var gelenkisi = sender as ListView;
            if (listView1.SelectedItems is null)
            {
                return;
            }

            var lv = gelenkisi.SelectedItems[0];




            txtAd.Text = lv.SubItems[1].Text;
            txtSoyad.Text = lv.SubItems[2].Text;
            txtKimlikNo.Text = lv.SubItems[3].Text;
            txtUzmanlik.Text = lv.SubItems[4].Text;

            //pictureBox1.Image = ımageList1.Images[lv.ImageIndex];
            pictureBox1.Image = ımageList1.Images[lv.ImageKey];
            progressBar1.Value += 20;
            isUpdate = true;
            selectedRowIndex = gelenkisi.SelectedIndices[0];
            
        }

        private void btnResim_Click(object sender, EventArgs e)
        {

         
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                var img = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = img;
                progressBar1.Value += 20;
            }
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            TextBoxChangerogress(sender);
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            TextBoxChangerogress(sender);
        }

        private void txtKimlikNo_TextChanged(object sender, EventArgs e)
        {
            TextBoxChangerogress(sender);
        }

        private void txtUzmanlik_TextChanged(object sender, EventArgs e)
        {
            TextBoxChangerogress(sender);
        }
        private void TextBoxChangerogress(object sender)
        {
            TextBox txt = sender as TextBox;
            if (txt.Tag == null)
            {
                progressBar1.Value += 20;
                txt.Tag = "girildi";
            }
            if (txt.Text == "")
            {
                progressBar1.Value -= 20;
                txt.Tag = null;
            }
        }
    }
}
