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
        public string AdSoyad { get; set; }
        public string SinavDosyaYolu { get; set; }
        public TimeSpan SinavSüresi { get; private set; }
        public double SinavSüresiYüzdeOn { get; private set; }
        public int grpHeight = 0;
        public GroupBox groupBox { get; set; }
        public RadioButton radio { get; set; }

        public frmSinavEkrani()
        {
            InitializeComponent();

            //var frmGiris = this.Owner as frmGiris;
            //this.lblAdSoyad.Text = frmGiris.txtAdSoyad.Text;
        }

        public frmSinavEkrani(string adSoyad, string sinavDosyaYolu) : this()
        {
            AdSoyad = adSoyad;
            lblAdSoyad.Text = adSoyad;
            SinavDosyaYolu = sinavDosyaYolu;
        }

        private void frmSinavEkrani_Load(object sender, EventArgs e)
        {
            using (var streamReader = new StreamReader(SinavDosyaYolu))
            {
                lblSinavAdi.Text = streamReader.ReadLine();
                lblSinavAciklama.Text = streamReader.ReadLine();
                lblKalanZaman.Text = (TimeSpan.FromSeconds(int.Parse(streamReader.ReadLine()))).ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SinavSüresi.TotalSeconds == 0)
            {
                timer1.Stop();
            }
            this.lblKalanZaman.Text = SinavSüresi.ToString(@"hh\:mm\:ss");

            if (SinavSüresi.TotalSeconds <= SinavSüresiYüzdeOn)
            {
                lblKalanZaman.ForeColor = Color.Red;
            }
            SinavSüresi = TimeSpan.FromSeconds(SinavSüresi.TotalSeconds - 1);
        }

        public void btnbaslat_Click(object sender, EventArgs e)
        {
           
            btnbaslat.Enabled = false;

            using (var streamReader = new StreamReader(SinavDosyaYolu))
            {
                lblSinavAdi.Text = streamReader.ReadLine();
                lblSinavAciklama.Text = streamReader.ReadLine();
                SinavSüresi = TimeSpan.FromSeconds(int.Parse(streamReader.ReadLine()));
                SinavSüresiYüzdeOn = SinavSüresi.TotalSeconds * 0.1;

                string line = "";

                int soruSayisi = 0;
                int top = -350;
                int left = 0;

                while (!string.IsNullOrWhiteSpace((line = streamReader.ReadLine())))
                {
                    soruSayisi++;
                    var items = line.Split('|');

                    top += (soruSayisi % 2 == 1) ? 350 : 0;
                    left = (soruSayisi % 2 == 1) ? 0 : 286;
                    grpHeight = (soruSayisi % 2 == 1) ? 0 : grpHeight;
                    
                    
                     groupBox = new GroupBox
                    {
                        Location = new Point(left, top),
                        Size = new Size(275, grpHeight),
                        Text = $"{soruSayisi}. Soru"
                    };
                    
                    var lbl = new Label
                    {
                        Text = items[0],
                        MaximumSize = new Size(260, 0),
                        AutoSize = true,
                        Location = new Point(15, 15)
                    };
                    
                    int radioTop = lbl.Location.Y + lbl.PreferredHeight + 15;

                    for (int i = 1; i < items.Length - 1; i++)
                    {
                         radio = new RadioButton
                        {
                            Text = items[i],
                            Location = new Point(20, radioTop),
                            Enabled = true,
                            AutoSize = true,
                            MaximumSize = new Size(200, 0),
                            Tag=soruSayisi
                        };

                        groupBox.Controls.Add(radio);
                        
                       
                        radioTop += 30;
                    
                    }
                    if (grpHeight<=lbl.PreferredHeight+radioTop)
                    {
                        grpHeight = lbl.PreferredHeight + radioTop;
                        groupBox.Height = grpHeight;
                            
                    }
                    else
                    {
                        groupBox.Height = grpHeight;
                    }
                    groupBox.Controls.Add(lbl);

                    pnlSorular.Controls.Add(groupBox);
                    
                    
                };
               

                //timer1.Interval = 1;
            }
            
            timer1.Start();
        }

        private void btnbitir_Click(object sender, EventArgs e)
        {   
           
            var kisiadi = lblAdSoyad.Text.Split(' ');
            StreamWriter cevap = File.CreateText($"C:\\cevaplar\\{lblSinavAdi.Text}-{kisiadi[0]}-{kisiadi[1]}.txt");
            //radio.Checked
            //saveFileDialog1.FileName = ($"C:\\{lblSinavAdi.Text}-{kisiadi[0]}-{kisiadi[1]}.txt");

            btnbitir.Enabled = false;
           
            timer1.Stop();
            pnlSorular.Enabled = false;
            


          
         
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
