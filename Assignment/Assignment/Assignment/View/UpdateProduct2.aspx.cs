using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment.View
{
    public partial class UpdateProduct2 : System.Web.UI.Page
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
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(BoxProductPrice.Text.ToString());
            int temp2 = int.Parse(BoxProductStock.Text.ToString());
            if (temp2 < 1)
            {
                LabelPrice.Text = null;
                LabelStock.Text = "Input must be 1 or more";
            }
            else if(temp % 1000 != 0)
            {
                LabelPrice.Text = "Input must be above 1000 and multiply of 1000";
                LabelStock.Text = null;
            }
           else if (temp <= 1000)
            {
                LabelPrice.Text = "Input must be above 1000 and multiply of 1000";
                LabelStock.Text = null;
            }
            else
            {
                String Name = BoxProductName.Text.ToString();
                int Stock = int.Parse(BoxProductStock.Text.ToString());
                int Price = int.Parse(BoxProductPrice.Text.ToString());
                Repository.RepositoryMsProducts.UpdateProduct(Request.QueryString["id"], Name, Price, Stock);
                Response.Redirect("ViewProduct.aspx");
            }
        }
    }
}