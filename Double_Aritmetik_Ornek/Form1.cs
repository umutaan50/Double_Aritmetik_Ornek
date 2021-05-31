using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Double_Aritmetik_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2, toplam, çarpım, bölüm, çıkarım;
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);

            toplam = sayı1 + sayı2;
            lbltoplam.Text = toplam.ToString();
            çarpım = sayı1 * sayı2; bölüm = sayı1 / sayı2; çıkarım = sayı1 - sayı2;
            lblbölüm.Text = bölüm.ToString(); lblçarpım.Text = çarpım.ToString(); lblçıkarım.Text = çıkarım.ToString();
            



        }
    }
}
