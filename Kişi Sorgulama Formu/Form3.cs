using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Kişi_Sorgulama_Formu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }
        public string Username;
        public string Password;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-OOC;Initial Catalog=Kişi_Sorgulama;Integrated Security=True");
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) // kullanıcı
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e) // şifre
        {
           
        }
        public static string kullanıcı;
        public static string sifre;

        private void button1_Click_1(object sender, EventArgs e) //kaydet
        {
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("update User_login set Username = @p1 ,Password = @p2 where Username = @p3 and Password = @p4", baglanti);
            cmd2.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd2.Parameters.AddWithValue("@p2", textBox2.Text);
            cmd2.Parameters.AddWithValue("@p3", Username);
            cmd2.Parameters.AddWithValue("@p4", Password);
            cmd2.ExecuteNonQuery();
            baglanti.Close();
        }
        int i = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                i++;
                textBox2.PasswordChar = '*';
            }
            else
            {
                i--;
                textBox2.PasswordChar = '\0';
            }
        }
    }
}
