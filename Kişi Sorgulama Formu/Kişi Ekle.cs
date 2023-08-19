using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kişi_Sorgulama_Formu
{
    public partial class Kişi_Ekle : Form
    {
        public Kişi_Ekle()
        {
            InitializeComponent();
        }

        private void Kişi_Ekle_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e) //isim
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e) //yaş
        {
            
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e) //cinsiyet
        {
            
        }

        private void button1_Click(object sender, EventArgs e) //ekle
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-OOC;Initial Catalog=Kişi_Sorgulama;Integrated Security=True");
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Patient_Table (Patient_Name,Patient_Age,Patient_Gender) values (@p1,@p2,@p3)", baglanti);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);
            cmd.Parameters.AddWithValue("@p3", textBox3.Text);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read() && textBox1 == null && textBox2 == null && textBox3 == null)
            {
                MessageBox.Show("Başarıyla Kaydedildi");

            }
            else
            {
                MessageBox.Show("Hata!!");

            }
        }
    }
}
