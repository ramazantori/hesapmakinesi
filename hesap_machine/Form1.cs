using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_machine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

            Random rnd = new Random();
            int x = rnd.Next(0, 255);
            int y = rnd.Next(0, 255);
            int z = rnd.Next(0, 255);

            this.BackColor = Color.FromArgb(x, y, z);
        }

        public double sayi1;
        public double sayi2;
        public double sonuc;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Hababam_Sinifi dortislem = new Hababam_Sinifi();

        private void bttn_arti_Click(object sender, EventArgs e)
        {
           

            try
            {
                sayi1 = double.Parse(text_sayi1.Text);
                sayi2 = double.Parse(text_sayi2.Text);

                sonuc = Hababam_Sinifi.toplama(sayi1,sayi2);
                text_sonuc.Text = sonuc.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen önce sayı giriniz!!! Daha sonra yapmak istediğiniz işlemi seçiniz!!!");
                text_sayi1.Clear();
                text_sayi2.Clear();
                text_sonuc.Clear();

            }
            text_sayi1.Focus();
        }

        private void bttn_eksi_Click(object sender, EventArgs e)
        {
            

           
            try
            {
                sayi1 = double.Parse(text_sayi1.Text);
                sayi2 = double.Parse(text_sayi2.Text);

                sonuc = dortislem.cikarma(sayi1, sayi2);
                text_sonuc.Text = sonuc.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen önce sayı giriniz!!! Daha sonra yapmak istediğiniz işlemi seçiniz!!!");
                text_sayi1.Clear();
                text_sayi2.Clear();
                text_sonuc.Clear();

            }
            text_sayi1.Focus();
        }

        private void bttn_carpi_Click(object sender, EventArgs e)
        {
        

            try
            {
                sayi1 = double.Parse(text_sayi1.Text);
                sayi2 = double.Parse(text_sayi2.Text);

                sonuc = dortislem.carpma(sayi1, sayi2);
                text_sonuc.Text = sonuc.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen önce sayı giriniz!!! Daha sonra yapmak istediğiniz işlemi seçiniz!!!");
                text_sayi1.Clear();
                text_sayi2.Clear();
                text_sonuc.Clear();

            }
            text_sayi1.Focus();
        }

        private void bttn_böl_Click(object sender, EventArgs e)
        {
          

            try
            {
                sayi1 = double.Parse(text_sayi1.Text);
                sayi2 = double.Parse(text_sayi2.Text);

                sonuc = dortislem.bölme(sayi1, sayi2);
                text_sonuc.Text = sonuc.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen önce sayı giriniz!!! Daha sonra yapmak istediğiniz işlemi seçiniz!!!");
                text_sayi1.Clear();
                text_sayi2.Clear();
                text_sonuc.Clear();

            }
            text_sayi1.Focus();
        }

        private void bttn_temizle_Click(object sender, EventArgs e)
        {
            text_sayi1.Clear();
            text_sayi2.Clear();
            text_sonuc.Clear();
            text_sayi1.Focus();
        }

        private void bttn_cikis_Click(object sender, EventArgs e)
        {
            if (text_sayi1.Text == "")
            {
                Application.Exit();


            }
            else if (text_sayi2.Text=="")
            {
                Application.Exit();
            }
            else if (text_sonuc.Text=="")
            {
                Application.Exit();
            }
            else
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("İşlem devam ediyor yinede çıkmak istermisiniz", "", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    return;
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 255);
            int y = rnd.Next(0, 255);
            int z = rnd.Next(0, 255);

            Random rnd2 = new Random();
            int x2 = rnd.Next(0, 255);
            int y2 = rnd.Next(0, 255);
            int z2 = rnd.Next(0, 255);

            bttn_eksi.BackColor = Color.FromArgb(x2, y2, z2);
            bttn_arti.BackColor = Color.FromArgb(x2, y2, z2);
            bttn_carpi.BackColor = Color.FromArgb(x2, y2, z2);
            bttn_böl.BackColor = Color.FromArgb(x2, y2, z2);

            lbl_sayi1.BackColor = Color.FromArgb(x, y, z);
            lbl_sayi2.BackColor = Color.FromArgb(x, y, z);
            lbl_sonuc.BackColor = Color.FromArgb(x, y, z);
            

        }
    }
}
