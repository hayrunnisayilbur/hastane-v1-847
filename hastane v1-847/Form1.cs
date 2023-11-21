using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_v1_847
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hasta hasta1 = new Hasta();

            hasta1.ad = "hayrunnisa"; //txtAd.text;
            hasta1.soyad = "yılbur";
            hasta1.tcno = "63502432106";
            hasta1.tel = "05427657936";
            hasta1.kronikHastalik = false;
            hasta1.kanGrup = "A+";
            hasta1.dtarih = new DateTime(2008, 2, 14);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hasta hasta1 = null;

            hasta1 = new Hasta();

            hasta1.ad = txtAd.Text;
            hasta1.soyad = txtSoyad.Text;
            hasta1.dtarih = DateTimePicker1.Value;
            hasta1.kronikHastalik = rbVar.Checked;
            hasta1.kanGrup = cmbKan.Text;
        }
    }
}                                                                                                              
