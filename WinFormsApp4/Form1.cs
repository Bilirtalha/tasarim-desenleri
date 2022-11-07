using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        Market market = new Market();
        public Form1()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("./kategoriler.txt");
            MessageBox.Show(sr.ReadToEnd());
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = market.urunler;

        }

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarketUrun marketurun = new MarketUrun();
            marketurun.ID = market.MaxUrunID;
            market.MaxUrunID += 1;
            marketurun.Name = textBox2.Text;
            marketurun.Kategori = comboBox1.SelectedItem.ToString();
            marketurun.Barkod = "MRKT" + marketurun.Kategori + RandomString(5);
            marketurun.Fiyat = Convert.ToDouble(textBox1.Text);
            market.urunler.Add(marketurun);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = market.urunler;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
