using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment.View
{
    public partial class InsertProductType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
            }
        }

        protected void BtnInsertProductType_Click(object sender, EventArgs e)
        {
            String Type = BoxProductType.Text.ToString();
            String Desc = BoxDesc.Text.ToString();
            if(Repository.RepositoryMsProductType.SearchTypeByName(Type) != null)
            {
                LabelUnique.Text = "Product type name is already";
            }
            else
            {
                int ID = Repository.RepositoryMsProductType.CountData();
                Repository.RepositoryMsProductType.InsertType(ID+1, Type, Desc);
                Response.Redirect("ViewProductType.aspx");
            }
        }
    }
}