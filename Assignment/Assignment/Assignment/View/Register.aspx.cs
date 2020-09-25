using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginSession"] != null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void BtnInsertRegister(object sender, EventArgs e)
        {
            String Name = RegisNama.Text.ToString();
            String Email = RegisEmail.Text.ToString();
            String Password = RegisPassword.Text.ToString();
            String Gender = RegisGender.Text.ToString();
            int ID = Repository.RepositoryMsUser.CountData();
            if (Repository.RepositoryMsUser.SearchUserByEmail(Email) == null)
            {
                Repository.RepositoryMsUser.RegisData(Name, Email, Password, Gender,ID+1);
                Response.Redirect("Home.aspx");
            }
            else
            {
                LabelEmail.Text = "Email Already Registered";
            }
            
        }


    }
}