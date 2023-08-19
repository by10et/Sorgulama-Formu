using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Kişi_Sorgulama_Formu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-OOC;Initial Catalog=Kişi_Sorgulama;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //kullanıcı
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) //şifre
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * From User_login where UserName=@p1 and Password=@p2", baglanti);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader rdr = cmd.ExecuteReader();


            if (rdr.Read())
            {

                MessageBox.Show("Başarıyla Giriş Yapıldı");
                Form2 fr2 = new Form2();
                fr2.Username2 = textBox1.Text;
                fr2.Password2 = textBox2.Text;
                fr2.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalo Şifre veya Kullanıcı Adı", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }

            private void pictureBox1_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox2_Click(object sender, EventArgs e)
            {

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

