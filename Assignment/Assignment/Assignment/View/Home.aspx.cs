using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment.View
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BtnViewProfile.Visible = false;
            BtnViewUser.Visible = false;
            BtnInsertProduct.Visible = false;
            BtnUpdateProduct.Visible = false;
            BtnViewProductType.Visible = false;
            BtnInsertProductType.Visible = false;
            BtnUpdateProductType.Visible = false;
            
            if (Session["LoginSession"] != null)
            {
                String ID = Session["LoginSession"].ToString();
                if (Repository.RepositoryMsUser.IsMember(ID) == true)
                {
                    BtnViewProfile.Visible = true;
                }
                else
                {
                    BtnViewProfile.Visible = false;
                }
                if(Repository.RepositoryMsUser.IsAdmin(ID) == true)
                {
                    GridView1.Visible = false;
                    BtnViewUser.Visible = true;
                    BtnInsertProduct.Visible = true;
                    BtnUpdateProduct.Visible = true;
                    BtnViewProductType.Visible = true;
                    BtnInsertProductType.Visible = true;
                    BtnUpdateProductType.Visible = true;
                }
            }
            
            GridView1.DataSource = Repository.RepositoryMsProducts.FetchDataRandom().ToList();
            GridView1.DataBind();
        }
        protected void BtnViewProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProduct.aspx");
        }

        protected void BtnViewProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProfile.aspx");
        }

        protected void BtnViewUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewUser.aspx");
        }

        protected void BtnViewProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProductType.aspx");
        }

        protected void BtnInsertProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProductType.aspx");
        }

        protected void BtnInsertProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProduct.aspx");
        }

        protected void BtnUpdateProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProductType.aspx");
        }

        protected void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProduct.aspx");
        }
    }
}