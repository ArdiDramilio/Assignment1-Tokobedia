using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Factory
{
    public class FactoryMsUser
    {
        public  static MsUser InitUser(String Nama, String Email, String Password, String Gender,Int64 ID)
        {
            
            MsUser UserBaru = new MsUser();
            UserBaru.UserName = Nama;
            UserBaru.UserEmail = Email;
            UserBaru.UserPassword = Password;
            UserBaru.UserGender = Gender;
            UserBaru.RoleID = "RL003";
            UserBaru.UserID = "US"+ID;
            UserBaru.UserStatus = "Active";

            return UserBaru;
        }
      
    }
    
}