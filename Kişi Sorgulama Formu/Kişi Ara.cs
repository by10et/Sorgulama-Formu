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
    public partial class Kişi_Ara : Form
    {
        public Kişi_Ara()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-OOC;Initial Catalog=Kişi_Sorgulama;Integrated Security=True");
        private void Kişi_Ara_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e) //ara
        {

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * From Patient_Table where Patient_Gender=@p1", baglanti);
            cmd.Parameters.AddWithValue("@p1", textBox3.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * From Patient_Table where Patient_Age=@p1", baglanti);
            cmd.Parameters.AddWithValue("@p1", textBox2.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * From Patient_Table where Patient_Name=@p1", baglanti);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
