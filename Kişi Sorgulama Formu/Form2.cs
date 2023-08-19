using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kişi_Sorgulama_Formu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string Username2;
        public string Password2;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //şifre değiş
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) //kişi ara
        {
            Kişi_Ara ka = new Kişi_Ara();
            ka.Show();
        }

        private void button2_Click(object sender, EventArgs e) //kişi ekle
        {
            Kişi_Ekle ke = new Kişi_Ekle();
            ke.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
