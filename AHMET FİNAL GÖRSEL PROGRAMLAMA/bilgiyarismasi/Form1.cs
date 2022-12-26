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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Baglanti.ConnectionString = "Server=MYO-LAB-PC3\\SQLEXPRESS;Database=test;User Id=deneme;Password=123456;";
            Baglanti.Open();
            MessageBox.Show("Bağlantı Açıldı.");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
