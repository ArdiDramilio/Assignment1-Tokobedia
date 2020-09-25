using Assignment.Factory;
using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Repository
{
    public class RepositoryMsUser
    {
        static TokobediaEntities2 TokobeEntities = new TokobediaEntities2();

        public static void RegisData(String Nama, String Email, String Password, String Gender ,Int64 ID)
        { 
            TokobeEntities.MsUsers.Add(FactoryMsUser.InitUser(Nama,Email,Password,Gender,ID));
            TokobeEntities.SaveChanges();
        }
        public static void UpdateData(String ID,String Nama,String Email,String Gender)
        {
            MsUser User = SearchUserByID(ID);
            User.UserName = Nama;
            User.UserEmail = Email;
            User.UserGender = Gender;
            TokobeEntities.SaveChanges();
        }
        public static void UpdatePass(String ID,String Pass)
        {
            MsUser User = SearchUserByID(ID);
            User.UserPassword = Pass;
            TokobeEntities.SaveChanges();
        }
       public static void UpdateRole(String ID,String Role)
        {
            MsUser User = SearchUserByID(ID);
            User.RoleID = Role;
            TokobeEntities.SaveChanges();
        }
        public static void UpdateStatus(String ID, String Status)
        {
            MsUser User = SearchUserByID(ID);
            User.UserStatus = Status;
            TokobeEntities.SaveChanges();
        }
        public static MsUser SearchUserByID(String ID)
        {
            return (from a in TokobeEntities.MsUsers
                                where a.UserID == ID
                                select a).FirstOrDefault();
            
        }
        public static MsUser SearchUserByEmail(String Email)
        {
            return (from x in TokobeEntities.MsUsers
                               where x.UserEmail == Email
                               select x).FirstOrDefault();
        }
        public static int CountData()
        {
            return (from y in TokobeEntities.MsUsers
                  where y.UserName != null
                  select y).Count();
        }
        public static bool CheckOldPassByID(String ID,String Pass)
        {
            MsUser User =  SearchUserByID(ID);
            if (User.UserPassword != Pass)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool IsAdmin(String ID)
        {
            MsUser User = SearchUserByID(ID);
            if (User.RoleID=="RL001") return true;
            else return false;
        }
        public static bool IsMember(String ID)
        {
            MsUser User = SearchUserByID(ID);
            if (User.RoleID == "RL003") return true;
            else return false;
        }
        public static bool IsGuest(String ID)
        {
            MsUser User = SearchUserByID(ID);
            if (User.RoleID == "RL002") return true;
            else return false;
        }
        public static List<DatTemp2> FetchUser()
        {
            TokobediaEntities2 db2 = new TokobediaEntities2();
            return (from x in db2.MsUsers
                            join y in db2.MsRoles
                            on x.RoleID equals y.RoleID
                            select new DatTemp2
                            {
                                UserID = x.UserID,
                                UserName = x.UserName,
                                UserGender = x.UserGender,
                                UserRole = y.RoleName,
                                UserStatus = x.UserStatus
                            }).ToList();
        }
        public static bool IsBlocked(String ID)
        {
            MsUser User = SearchUserByID(ID);
            if (User.UserStatus == "Blocked") return true;
            else return false;

        }
    }
    
   
}