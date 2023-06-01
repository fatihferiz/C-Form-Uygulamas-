using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//*************MÜHENDİSİNEVİ*****************

namespace formuygulamaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //BU KISIMDA TOPLAMA İŞLEMİ YAPILMAKTADIR
        private void toplamabutonu_Click(object sender, EventArgs e)
        {

            int sayi1, sayi2;
            int sonuc;

            sayi1 =Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            //toplam işlemi
            sonuc = sayi1 + sayi2;
            textBox3.Text = sonuc.ToString();

        }

    }
}
