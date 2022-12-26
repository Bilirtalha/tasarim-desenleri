using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgiyarismasi
{
    public partial class Form1 : Form
    {
        SqlConnection Baglanti = new SqlConnection();
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Baglanti.ConnectionString = "Server=(localdb)\\MSSQLLocalDBS;Database=BilgiYarismasi;User Id=deneme;Password=123456;";
           // Baglanti.Open();
            //MessageBox.Show("Bağlantı Açıldı.");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
      
            kisi kisi = new kisi();
            kisi.isim = textBox1.Text;
            kisi.soyisim = textBox2.Text; 
            string sorgu = "SELECT * FROM yarismaci where isim=@isim AND soyisim=@soyisim";
            Baglanti.ConnectionString = "Server = MYO-LAB-PC2\\SQLEXPRESS;Database=BilgiYarismasi;User Id=deneme;Password=123456;";
            cmd = new SqlCommand(sorgu, Baglanti);
            cmd.Parameters.AddWithValue("@isim",kisi.isim);
            cmd.Parameters.AddWithValue("@soyisim",kisi.soyisim );
            Baglanti.Open();
            MessageBox.Show("Bağlantı Açıldı.");
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Kayıtlı yarışmacı yarışma başlıyor");
                tabControl1.SelectedTab = tabPage2;
            }
            else
            {
                MessageBox.Show("Kayıtlı olmayan Yaışmacı ");
                Application.Exit();
            }
            Baglanti.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Baglanti.ConnectionString = "Server = MYO-LAB-PC2\\SQLEXPRESS;Database=BilgiYarismasi;User Id=deneme;Password=123456;";
            Baglanti.Open();
            MessageBox.Show("Bağlantı Açıldı.");
        }
    }
}
