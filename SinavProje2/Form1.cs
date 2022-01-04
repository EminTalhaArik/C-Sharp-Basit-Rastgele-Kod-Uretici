using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavProje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int harfSayisi = 0;
        int rakamSayisi = 0;
        Char[] Alfabe = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'R', 'S', 'T', 'U', 'V', 'Y', 'Z', 'W', 'X' };

        private void button1_Click(object sender, EventArgs e)
        {
            if (rButonSayi.Checked)
            {
                SayiKodUret();
            }
            else if (rButtonHarf.Checked)
            {
                try
                {
                    harfSayisi = Convert.ToInt32(txtHarfSayisi.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen Doğru Giriniz!");
                    return;
                }

                HarfKodUret(harfSayisi);
            }
            else if (rButtonHarfSayi.Checked)
            {
                try
                {
                    rakamSayisi = Convert.ToInt32(txtRakamSayisi.Text);
                    harfSayisi = Convert.ToInt32(txtHarfSayisi.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen Doğru Giriniz!");
                    return;
                }

                lblKod.Text = HarfSayiKodUret(harfSayisi, rakamSayisi);
            }
            else
            {
                MessageBox.Show("Lütfen Bir Seçim Yapınız!");
            }
        }

        Random random = new Random();

        private void SayiKodUret()
        {
            lblKod.Text = "";
            for (int i = 0; i < 6; i++)
            {
                lblKod.Text += random.Next(0, 9);
            }
        }

        private void HarfKodUret(int harfSayisi)
        {
            lblKod.Text = "";
            for (int i = 0; i < harfSayisi; i++)
            {
                lblKod.Text += Alfabe[random.Next(0, Alfabe.Length)];
            }
        }

        private string HarfSayiKodUret(int harfSayisi, int rakamSayisi)
        {
            string harfVeRakam = "";
            for (int i = 0; i < harfSayisi; i++)
            {
                harfVeRakam += Alfabe[random.Next(0, Alfabe.Length)];
            }

            for (int i = 0; i < rakamSayisi; i++)
            {
                harfVeRakam += random.Next(0, 9);
            }

            return harfVeRakam;
        }

        private void rButonSayi_CheckedChanged(object sender, EventArgs e)
        {
            txtHarfSayisi.Enabled = false;
            txtRakamSayisi.Enabled = false;
        }

        private void rButtonHarf_CheckedChanged(object sender, EventArgs e)
        {
            txtHarfSayisi.Enabled = true;
            txtRakamSayisi.Enabled = false;
        }

        private void rButtonHarfSayi_CheckedChanged(object sender, EventArgs e)
        {
            txtHarfSayisi.Enabled = true;
            txtRakamSayisi.Enabled = true;
        }
    }
}
