using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment.View
{
    public partial class UpdatePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginSession"] == null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void BtnUpdatePassword_Click(object sender, EventArgs e)
        {
            String Pass = UpdateOldPassword.Text.ToString();
            String NewPass = UpdateNewPassword.Text.ToString();
            String UserIDTemp = Session["LoginSession"].ToString();
            if (Repository.RepositoryMsUser.CheckOldPassByID(UserIDTemp,Pass) == false)
            {
                LabelMatchPass.Text = "Wrong Old Password";
            }
            else
            {
                Repository.RepositoryMsUser.UpdatePass(UserIDTemp, NewPass);
                Response.Redirect("ViewProfile.aspx");
            }
        }
    }
}