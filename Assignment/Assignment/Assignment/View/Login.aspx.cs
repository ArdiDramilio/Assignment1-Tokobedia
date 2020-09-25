using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["email"] != null && Request.Cookies["pass"] != null)
                {
                    EmailLogin.Text = Request.Cookies["email"].Value;
                    PasswordLogin.Attributes["value"] = Request.Cookies["pass"].Value;
                    RememberMe.Checked = true;
                }
                else
                {
                    RememberMe.Checked = false;
                }
            }
            if (Session["LoginSession"] != null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            String Email = EmailLogin.Text.ToString();
            String Pass = PasswordLogin.Text.ToString();
            MsUser UserTemp = Repository.RepositoryMsUser.SearchUserByEmail(Email);

            if (UserTemp == null)
            {
                LabelLoginEmail.Text = "Email not registered";
                LabelLoginPassword.Text = null;
            }
            else
            {
                if (UserTemp.UserPassword != Pass)
                {
                    LabelLoginPassword.Text = "Wrong Password";
                    LabelLoginEmail.Text = null;
                }
                else
                {
                    if (Repository.RepositoryMsUser.IsBlocked(UserTemp.UserID) == true)
                    {
                        LabelBlocked.Text = "You not permitted to log in";
                    }
                    else
                    {
                        Session["LoginSession"] = UserTemp.UserID.ToString();
                        if (RememberMe.Checked == true)
                        {
                            Response.Cookies["email"].Value = EmailLogin.Text.ToString();
                            Response.Cookies["pass"].Value = PasswordLogin.Text.ToString();
                            Response.Cookies["email"].Expires = DateTime.Now.AddMonths(3);
                            Response.Cookies["pass"].Expires = DateTime.Now.AddMonths(3);
                        }
                        else if (RememberMe.Checked == false)
                        {
                            if (Request.Cookies["email"] != null && Request.Cookies["pass"] != null)
                            {
                                if (Request.Cookies["email"].Value == EmailLogin.Text.ToString() && Request.Cookies["pass"].Value == PasswordLogin.Text.ToString())
                                {
                                    Response.Cookies["email"].Value = null;
                                    Response.Cookies["pass"].Value = null;
                                }
                            }
                        }
                        Response.Redirect("Home.aspx");
                    }
                   
                }

            }
        }
        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}