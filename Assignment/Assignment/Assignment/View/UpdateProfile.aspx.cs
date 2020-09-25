using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment.View
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginSession"] == null)
            {
                Response.Redirect("Home.aspx");
            }
            if (!IsPostBack)
            {
                if (Session["LoginSession"] != null)
                {
                    String UserIDTemp = Session["LoginSession"].ToString();
                    MsUser UserTemp2 = Repository.RepositoryMsUser.SearchUserByID(UserIDTemp);
                    UpdateNama.Text = UserTemp2.UserName;
                    UpdateGender.Text = UserTemp2.UserGender;
                    UpdateEmail.Text = UserTemp2.UserEmail;
                }
            }
            
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            String Name = UpdateNama.Text.ToString();
            String Email = UpdateEmail.Text.ToString();
            String Gender = UpdateGender.Text.ToString();
            String UserIDTemp2 = Session["LoginSession"].ToString(); 
            if (Repository.RepositoryMsUser.SearchUserByEmail(Email) != null)
            {
                LabelEmail.Text = "Email already registered";
            }
            else
            {
                Repository.RepositoryMsUser.UpdateData(UserIDTemp2, Name, Email, Gender);
                Response.Redirect("ViewProfile.aspx");
            }
        }
    }
}