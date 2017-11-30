using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Eklebtn_Click(object sender, EventArgs e)
        {
           
            GetFilm(EsaretinBedeli);
            GetFilm(Idiots3);
            GetFilm(TheGoodFather);
            GetFilm(FightClub);
            GetFilm(Inception);
            GetFilm(OlaganSupheliler);

        }
        public void GetFilm(RadioButton rdButton)
        {
            if (rdButton.Checked)
            {
                if (treeView1.Nodes.Count > 0)
                {
                    for (int i = 0; i < treeView1.Nodes.Count; i++)
                    {
                        if ((rdButton.Text.ToString()) == (treeView1.Nodes[i].Text.ToString()))
                        {
                            
                            return ;
                        }
                       
                    }
                    treeView1.Nodes.Add(rdButton.Text.ToString());




                }
                else
                {
                    treeView1.Nodes.Add(rdButton.Text.ToString());
                }
                btntur.Enabled = true;
            }
            

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            btntur.Enabled = false;
        }
        public static int sira = 0;
        private void treeView1_SelectedNode(object sender, TreeViewEventArgs e)
        {
            sira=treeView1.SelectedNode.Index;
            
        }

        private void btntur_Click(object sender, EventArgs e)
        {
            AddTur(Dram);
            AddTur(Komedi);
            AddTur(Aksiyon);
            AddTur(Gerilim);
            AddTur(Bilim);
            AddTur(Fantastik);
        }
        public void AddTur(CheckBox cbox)
        {
            if (cbox.Checked)
            {

                treeView1.Nodes[sira].Nodes.Add(cbox.Text);
                cbox.Checked= false;
            }
        }
    }
}
