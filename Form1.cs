using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();
        Random r2 = new Random();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)      // Veri Şifreleyici
        {
            string veri = "";
            veri = textBox1.Text;
            char[] veriler = veri.ToCharArray();
            foreach (char eleman in veriler)
            {
                textBox2.Text += Convert.ToChar(eleman + 5).ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)      // Şifreli Veri Çözücü
        {
            string sifre = "";
            sifre = textBox4.Text;
            char[] sifreler = sifre.ToCharArray();
            foreach (char eleman2 in sifreler)
            {
                textBox3.Text += Convert.ToChar(eleman2 - 5).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)      // Veri Şifreleyici temizleme
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)      // Şifre Çözücü temizleme
        {
            textBox3.Clear();
            textBox4.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)      //Şifre Üretici
        {
            if (label8.Text == "")
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 10; i++)
                {
                    int pass = r.Next(65, 90);
                    char karakter = Convert.ToChar(pass);
                    sb.Append(karakter);
                }

                label8.Text += Convert.ToString(sb);
                    
            }

            else
            {

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 10; i++)                   
                {                                                                               
                    int pass = r.Next(65, 90);                 
                    char karakter = Convert.ToChar(pass);      
                    sb.Append(karakter);
                }

                label8.Text += Environment.NewLine + sb;


            }
        }

        private void button6_Click(object sender, EventArgs e)      // Şifre Üretici temizleme
        {
            label8.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] sayi = new int[6];
            int sayici = 0;
            int rastgele = 0;

            while (sayici < 6)
            {
                rastgele = r2.Next(1, 50);
                if (Array.IndexOf(sayi, rastgele) == -1)
                {
                    sayi[sayici++] = rastgele;
                }

            }
            Array.Sort(sayi);

            label5.Text = sayi[0].ToString();
            label6.Text = sayi[1].ToString();
            label16.Text = sayi[2].ToString();
            label7.Text = sayi[3].ToString();
            label20.Text = sayi[4].ToString();
            label19.Text = sayi[5].ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label5.Text = "-";
            label6.Text = "-";
            label7.Text = "-";
            label20.Text = "-";
            label19.Text = "-";
            label16.Text = "-";
        }
    }

}