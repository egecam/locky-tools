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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        Form1 form1 = new Form1();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            form1.Show();
            this.Hide();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            

        }
    }
}
