using Digital_Diary.Access_to_Database;
using Digital_Diary.Access_to_Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary.Codes
{
    class RegistrationServices
    {

        UserDataAccess userDataAccess;

        public RegistrationServices()
        {
            this.userDataAccess = new UserDataAccess();
        }
       
        public int Add(string name,string userName,string password, string email,string gender,string dateofBirth,string bloodGroup)
        {
            User user = new User()
            {
                Name = name,
                UserName = userName,
                Password = password,
                Email = email,
                Gender = gender,
                DateofBirth = dateofBirth,
                BloodGroup = bloodGroup
            };
            this.userDataAccess= new UserDataAccess();
            return this.userDataAccess.AddUser(user);
        } 
        public int Search(string userName,string password)
        {
            User user = new User();
           this.userDataAccess = new UserDataAccess();
           user = this.userDataAccess.SearchUser(userName, password);

            if (user.UserName == userName && user.Password == password)
            {
                return 1;
            }
            else return -1;
        }
        public bool CheckingUserName(string userName)
        {
            User user = new User();
            this.userDataAccess = new UserDataAccess();
            user = this.userDataAccess.UserNameCheck(userName);

            if (user.UserName == userName)
            {
                return true;
            }
            else return false;
        }
    }
}
