using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment
{
    public partial class HomeMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TokobediaEntities2 db = new TokobediaEntities2();
            
            if (Session["LoginSession"] != null)
            {
                String UserIDTemp = Session["LoginSession"].ToString();
                MsUser UserTemp2 = (from a in db.MsUsers
                                    where a.UserID == UserIDTemp
                                    select a).FirstOrDefault();
                BtnLogin.Visible = false;
                BtnLogout.Visible = true;
                LabelNama.Text = UserTemp2.UserName;
            }
            if(Session["LoginSession"] == null)
            {
                BtnLogout.Visible = false;
            }
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");

        }

        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Cookies["email"].Expires = DateTime.Now.AddMonths(-1);
            Response.Cookies["pass"].Expires = DateTime.Now.AddMonths(-1);
            Response.Redirect("Home.aspx");
        }
    }
}