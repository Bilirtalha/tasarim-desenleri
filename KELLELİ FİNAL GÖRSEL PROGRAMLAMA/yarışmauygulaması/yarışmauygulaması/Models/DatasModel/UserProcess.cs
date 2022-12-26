using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace yarışmauygulaması.Models.DatasModel
{
    public class UserProcess
    {
        public List<User> Users = new List<User>();
        private SqlConnection Sql = new SqlConnection();
        public UserProcess()
        {
                this.Sql.ConnectionString = "Server=MYO-LAB-PC1\\SQLEXPRESS;Database=yarisma;User Id=mehmet;Password=1234;";
                this.Sql.Open();
                SqlCommand verioku = new SqlCommand("select * from Question", Sql);
                SqlDataReader oku = verioku.ExecuteReader();

                while (oku.Read())
                {
                    var question = new User();
                    question.Id = int.Parse(oku["Id"].ToString());
                    question.Name = oku["Name"].ToString();
                    question.LastName = oku["LastName"].ToString();
                    question.ApplicationDate = DateTime.Parse(oku["ApplicationName"].ToString());
                    question.JokerNames = oku["JokerNames"].ToString();
                    Users.Add(question);
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