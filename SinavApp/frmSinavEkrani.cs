using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavApp
{
    public partial class frmSinavEkrani : Form
    {

        public frmSinavEkrani()
        {

            InitializeComponent();
        }
        public string AdSoyad { get; set; }
        public string Sinavyolu { get; set; }

        private void frmSinavEkrani_Load(object sender, EventArgs e)
        {
            lblAdSoyad.Text = AdSoyad;

            var frmGiris = this.Owner as frmGiris;
            using (var stReader = new StreamReader(Sinavyolu))
            {
                lblSinavAdi.Text = stReader.ReadLine();
                lblSinavAciklama.Text = stReader.ReadLine();
            }
            //    do
            //{

            //} while (stReader.ReadLine() != null);

        }
    }
}
