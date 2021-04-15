using Digital_Diary.Access_to_Database.Entities;
using System;
using System.Collections.Generic;
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
    }
}
