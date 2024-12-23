using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RolandGarross
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void btnOgrenciIslemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Show();
        }

        private void btnEgitmenİslemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Egitmen egitmen = new Egitmen();
            egitmen.Show();

        }

        private void programIslemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kurlar dersProgrami = new Kurlar();
            dersProgrami.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DersProgramı dersProgramı= new DersProgramı();
            dersProgramı.Show();
           
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
