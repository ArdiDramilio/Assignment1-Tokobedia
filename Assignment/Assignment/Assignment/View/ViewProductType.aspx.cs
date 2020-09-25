using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment.View
{
    public partial class ViewProductType : System.Web.UI.Page
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
                else
                {
                    FetchFromDB();
                    LabelProductTypeID.Visible = false;
                    BoxDeleteType.Visible = false;
                    LabelDelete.Visible = false;
                    BtnDelete.Visible = false;
                    LabelDelete.Visible = true;
                }
            }
        }
        public void FetchFromDB()
        {
            GridView1.DataSource = Repository.RepositoryMsProductType.FetchData().ToList();
            GridView1.DataBind();
        }

        protected void BtnDeleteProductType_Click(object sender, EventArgs e)
        {
            LabelProductTypeID.Visible = true;
            BoxDeleteType.Visible = true;
            LabelDelete.Visible = true;
            BtnDelete.Visible = true;
        }

        protected void BtnInsertProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProductType.aspx");
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            String ID = BoxDeleteType.Text.ToString();
            if (Repository.RepositoryMsProducts.SearchProductByTypeID(ID) != null)
            {
                LabelDelete.Text = "Cannot delete";
            }
            else if (Repository.RepositoryMsProductType.SearchTypeByID(ID) == null)
            {
                LabelDelete.Text = "Product type not found";
            }
            else
            {
                Repository.RepositoryMsProductType.DeleteType(ID);
                Response.Redirect("ViewProductType.aspx");
            }
        }

        protected void BtnUpdateProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProductType.aspx");
        }
    }
}