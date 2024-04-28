using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.uite_uygulama_9
{
    public partial class Form1 : Form
    {
        int[,] dizi;
        int satirSayisi;
        int sutunSayisi;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rastgeleMin = int.Parse(txtRAsgeleEndusukSayı.Text);
            int rastgeleMax = int.Parse(txtRasgeleEnbuyukSAyısı.Text);
            satirSayisi = int.Parse(txtDiziSatirSayisi.Text);
            sutunSayisi = int.Parse(txtDiziSutunSayısı.Text);
            dizi = new int[satirSayisi, sutunSayisi];
            Random rastgele = new Random();
            for (int x = 0; x < satirSayisi; x++)
            {
                for (int y = 0; y < sutunSayisi; y++)
                {
                    dizi[x, y] = rastgele.Next(rastgeleMin, rastgeleMax);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < satirSayisi; x++)
            {
                for (int y = 0; y < sutunSayisi; y++)
                {
                   listBox1.Items.Add(x +","+y + "=>"+dizi[x, y]);
                }
            }
        }
    }
}
