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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection sConnection = new SqlConnection();

        public Form1()
        {
            sConnection.ConnectionString = "Server=MYO-LAB-PC1\\SQLEXPRESS;Database=Deneme;User Id=mehmet;Password=1234";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sConnection.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.sConnection.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
    
        }
    }
}
