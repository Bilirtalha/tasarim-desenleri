using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
          
            //string ConnectionString = "Server = MYO-LAB-PC2\\SQLEXPRESS;Database=Deneme;User Id=Talha;Password=x; connection timeout=30;";
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = ConnectionString;
            //conn.Open();
            //MessageBox.Show("Baðlantý Açýldý.");


            //SqlCommand command = new SqlCommand("Select * from Kitaplar", conn);
            //SqlDataReader reader = command.ExecuteReader();

            //while (reader.Read())
            //{
            //    richTextBox1.Text += reader.GetValue(reader.GetOrdinal("KitapAd")).ToString()+ "\n";
            //}
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
            
        private void button6_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Server=MYO-LAB-PC2\\SQLEXPRESS;Database=BilgiYarismasi;User Id=Uygulama;Password=xx90xx90;";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();


            Random rnd = new Random();
            int Sayi = rnd.Next(1,5);






            SqlCommand command = new SqlCommand("Select * from Sorular", conn);
            SqlDataReader reader = command.ExecuteReader();
            List <string> Sorular = new List<string>();
            while (reader.Read())
            {
                Sorular.Add(reader.GetValue(1).ToString()); 
            }
            if(Sayi == 1)
            {
                richTextBox2.Text = Sorular[0];
            }
            if (Sayi == 2)
            {
                richTextBox2.Text = Sorular[1];
            }
            if (Sayi == 3)
            {
                richTextBox2.Text = Sorular[2];
            }
            if (Sayi == 4)
            {
                richTextBox2.Text = Sorular[3];
            }
            if (Sayi == 5)
            {
                richTextBox2.Text = Sorular[4];
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text= ("Deneme");
        }
    }
}