using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment.View
{
    public partial class UpdateProductType2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["LoginSession"] == null)
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
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            String TypeName = BoxTypeName.Text.ToString();
            String TypeDesc = BoxTypeDesc.Text.ToString();
            if (Repository.RepositoryMsProductType.SearchTypeByName(TypeName) != null)
            {
                LabelUnique.Text = "Product type name already registered";
            }
            else
            {
                Repository.RepositoryMsProductType.UpdateType(Request.QueryString["id"], TypeName, TypeDesc);
                Response.Redirect("ViewProductType.aspx");
            }
        }
    }
}