using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace örnek_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection();
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            Baglanti.ConnectionString = "Server=MYO-LAB-PC3\\SQLEXPRESS;Database=test;User Id=deneme;Password=123456;";
            Baglanti.Open();
            MessageBox.Show("Bağlantı Açıldı.");
           timer1.Enabled= true;
            if (timer1.Enabled == true )
            {
                timer1.Start();
                timer1.Interval = 1000000;
                Baglanti.Close();
                MessageBox.Show("Bağlantı Kapandı.");
                timer1.Stop();

            }

            

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;  // Sayaç artırılıyor
            if (sayac == 10)  //Sayaç girilen sayıya eşit olduğu  kontrol ediliyor.
            {
                timer1.Enabled = false;  // Sayaç tamamlandığında timer durduruluyor.
            }
        }
    }
}
