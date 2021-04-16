using Digital_Diary.Access_to_Database.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary.Access_to_Database
{
    class UserDataAccess:DataAccess
    {

        public int AddUser(User user)
        {
            string sql = "INSERT INTO Users(Name,UserName,Password,Email,Gender,DateofBirth,BloodGroup) VALUES('" + user.Name + "','" + user.UserName + "','" + user.Password + "','" +user.Email+ "','" +user.Gender + "','" + user.DateofBirth + "','" + user.BloodGroup + "')";
            return this.ExecuteQuery(sql);
        }
        public User SearchUser(string userName,string password)
        {
            string sql = "Select * from Users where UserName " + " = userName and Password " + " = password";
            SqlDataReader reader = this.GetData(sql);
            User user = new User();
            if (reader.Read())
            {
                user.UserName = reader["UserName"].ToString();
                user.Password = reader["Password"].ToString();
            }
            return user;
        }
    }
}
