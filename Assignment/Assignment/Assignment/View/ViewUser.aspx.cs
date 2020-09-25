using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment.View
{
    public partial class ViewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidatorUserID.Text = null;
            if (Session["LoginSession"] == null)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                String Temp = Session["LoginSession"].ToString();
                if (Repository.RepositoryMsUser.IsAdmin(Temp) == false)
                {
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    FetchFromDB();
                    LabelUserID.Visible = false;
                    LabelNewUserRole.Visible = false;
                    IDChangeRole.Visible = false;
                    IDNewRole.Visible = false;
                    BtnSubmitUpdateRole.Visible = false;
                    BtnToggle.Visible = false;
                }
            }
            
        }
        public void FetchFromDB()
        {
            GridView1.DataSource = Repository.RepositoryMsUser.FetchUser().ToList();
            GridView1.DataBind();
        }

        protected void BtnChangeRole_Click(object sender, EventArgs e)
        {
                LabelUserID.Visible = true;
                LabelNewUserRole.Visible = true;
                IDChangeRole.Visible = true;
                IDNewRole.Visible = true;
                BtnSubmitUpdateRole.Visible = true;
        }

        protected void BtnSubmitUpdateRole_Click(object sender, EventArgs e)
        {
            String ID = IDChangeRole.Text.ToString();
            String RoleBaru = IDNewRole.Text.ToString();
            MsUser UserTemp = Repository.RepositoryMsUser.SearchUserByID(ID);
            if(UserTemp == null)
            {
                ValidatorUserID.Text = "User ID not found";
            }
            else if(UserTemp.UserID == Session["LoginSession"].ToString())
            {
                ValidatorUserID.Text = "Administrator that is logged in cannot change role and status";
            }
            else
            {
                if(RoleBaru == "Admin")
                {
                    String RoleID = "RL001";
                    Repository.RepositoryMsUser.UpdateRole(ID, RoleID);
                    Response.Redirect("ViewUser.aspx");
                }
                else if(RoleBaru == "Member")
                {
                    String RoleID = "RL003";
                    Repository.RepositoryMsUser.UpdateRole(ID, RoleID);
                    Response.Redirect("ViewUser.aspx");
                }
                else
                {
                    ValidatorUserID.Text = "Role not found";
                }
                
            }
        }

        protected void BtnChangeStatus_Click(object sender, EventArgs e)
        {
            IDChangeRole.Visible = true;
            LabelUserID.Visible = true;
            BtnToggle.Visible = true;
        }

        protected void BtnToggle_Click(object sender, EventArgs e)
        {
            String ID = IDChangeRole.Text.ToString();
            MsUser UserTemp = Repository.RepositoryMsUser.SearchUserByID(ID);
            if (UserTemp == null)
            {
                ValidatorUserID.Text = "User ID not found";
            }
            else if (UserTemp.UserID == Session["LoginSession"].ToString())
            {
                ValidatorUserID.Text = "Administrator that is logged in cannot change role and status";
            }
            else
            {
                if(UserTemp.UserStatus == "Active")
                {
                    Repository.RepositoryMsUser.UpdateStatus(ID, "Blocked");
                    Response.Redirect("ViewUser.aspx");
                }
                if (UserTemp.UserStatus == "Blocked")
                {
                    Repository.RepositoryMsUser.UpdateStatus(ID, "Active");
                    Response.Redirect("ViewUser.aspx");
                }
            }
        }
    }
}