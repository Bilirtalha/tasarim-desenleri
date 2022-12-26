using System.Collections.Generic;
using System.Data.SqlClient;

namespace yarışmauygulaması.Models
{
    public class QuestionProcess
    {
        SqlConnection Sql = new SqlConnection();
        public List<Question> Questions = new List<Question>();
        
        public QuestionProcess()
        {
            this.Sql.ConnectionString = "Server=MYO-LAB-PC1\\SQLEXPRESS;Database=yarisma;User Id=mehmet;Password=1234;";
            this.Sql.Open();
            SqlCommand verioku = new SqlCommand("select * from Question",Sql);
            SqlDataReader oku = verioku.ExecuteReader();

            while (oku.Read())
            {
                var question = new Question();
                question.Id = int.Parse(oku["Id"].ToString());
                question.QuestionName = oku["QuestionName"].ToString();
                question.QuestionAnswer = oku["QuestionAnswer"].ToString();
                question.QuestionChoices = oku["QuestionChoices"].ToString();
                question.QuestionChoicesArray = oku["QuestionChoices"].ToString().Split(',');
                Questions.Add(question);
            }
            CloseSql();
        }
        private void Opensql()
        {
            Sql.Open();
        }
        private void CloseSql()
        {
            Sql.Close();
        }
    }
}
