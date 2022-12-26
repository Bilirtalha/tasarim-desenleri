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
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int sayac = 0;
        SqlConnection Baglanti = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
            Baglanti.ConnectionString = "Server=MYO-LAB-PC2\\SQLEXPRESS;Database=deneme;User Id=Uygulama;Password=xx90xx90;";
            //timer1.Interval = 5000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sayac++;
            Baglanti.Open();
            MessageBox.Show("Bağlantı Açıldı.");
            timer1.Enabled = true;
            timer1.Start();
            
               
            if(timer1.Enabled == false )
            {
                Baglanti.Close();
                MessageBox.Show("Bağlantı Kapandı.");
            }
            else
            {
                return;
            }
            

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
