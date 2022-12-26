using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    
    public partial class Form1 : Form
    {
        private SqlConnection Sql = new SqlConnection();
        int sayac = 0;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sql.Open();
            MessageBox.Show("Oturum Basladı");
            timer1.Enabled = true;
            button1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if(sayac == 2)
            {
                Sql.Close();
                
                MessageBox.Show("Oturum Kapandı");
                timer1.Enabled = false;
                button1.Enabled = true;
            }
            else
            {
                if(progressBar1.Value <= progressBar1.Maximum)
                {
                    progressBar1.Value += 5;
                }
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sql.ConnectionString = "Server=MYO-LAB-PC1\\SQLEXPRESS;Database=yarisma;User Id=mehmet;Password=1234;";
            timer1.Interval = 5000;
            progressBar1.Maximum = 10;
        }
    }
}
