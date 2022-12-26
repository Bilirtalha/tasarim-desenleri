using System;
using System.Windows.Forms;
using yarışmauygulaması.Models;

namespace yarışmauygulaması
{
    public partial class Form1 : Form
    {
        private QuestionProcess questionProcess;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.questionProcess = new QuestionProcess();
            dataGridView1.DataSource = questionProcess.Questions;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
