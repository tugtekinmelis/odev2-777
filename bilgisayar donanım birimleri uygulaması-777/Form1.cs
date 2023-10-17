using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgisayar_donanım_birimleri_uygulaması_777
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {

            string secim;
            secim = listBox1.SelectedItems.ToString();

            if (secim == "mouse" || secim == "yazıcı" || secim == "kamera" || secim == "tarayıcı")
            {
                MessageBox.Show("BU PARÇA BİR GİRİŞ BİRİMİDİR");
            } if (secim == "yazıcı" || secim == "hoparlör" || secim == "projeksiyon")
            {
                MessageBox.Show("BU PARÇA BİR ÇIKIŞ BİRİMİDİR");
            }
        }
    }
}
