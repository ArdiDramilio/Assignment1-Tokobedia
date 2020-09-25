using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment.View
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginSession"] == null)
            {
                Response.Redirect("Home.aspx");
            }
            if (Session["LoginSession"] != null)
            {
                String UserIDTemp = Session["LoginSession"].ToString();
                MsUser UserTemp2 = Repository.RepositoryMsUser.SearchUserByID(UserIDTemp);
                LabelName.Text = UserTemp2.UserName;
                LabelGender.Text = UserTemp2.UserGender;
                LabelEmail.Text = UserTemp2.UserEmail;
            }
        }

        protected void BtnUpdateProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProfile.aspx");
        }

        protected void BtnUpdatePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdatePassword.aspx");
        }
    }
}