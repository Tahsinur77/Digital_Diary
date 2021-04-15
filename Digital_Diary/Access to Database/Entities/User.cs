using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary.Access_to_Database.Entities
{
    class User
    {
        public string Name { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public string Email { set; get; }
        public string Gender { set; get; }
        public string DateofBirth { set; get; }
        public string BloodGroup { set; get; }
    }
}
