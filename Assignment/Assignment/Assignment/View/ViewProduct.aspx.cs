using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment.View
{
    public partial class ViewProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BtnDeleteProduct.Visible = false;
            BtnInsertProduct.Visible = false;
            BtnUpdateProduct.Visible = false;
            LabelDelete.Visible = false;
            LabelBox.Visible = false;
            BoxID.Visible = false;
            BtnSubmit.Visible = false;
            FetchFromDB();
            TokobediaEntities2 db = new TokobediaEntities2();
            if (Session["LoginSession"] != null)
            {
                String Temp = Session["LoginSession"].ToString();
                MsUser UserTemp2 = Repository.RepositoryMsUser.SearchUserByID(Temp);
                if(Repository.RepositoryMsUser.IsAdmin(Temp) == true)   
                {
                    BtnDeleteProduct.Visible = true;
                    BtnInsertProduct.Visible = true;
                    BtnUpdateProduct.Visible = true;
                    LabelDelete.Visible = true;   
                }
            }
        }

        protected void BtnInsertProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProduct.aspx");
        }
        public void FetchFromDB()
        {
            GridView1.DataSource = Repository.RepositoryMsProducts.FetchDataProduct().ToList();
            GridView1.DataBind();
           
        }

        protected void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProduct.aspx");
        }

        protected void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            LabelDelete.Visible = true;
            LabelBox.Visible = true;
            BoxID.Visible = true;
            BtnSubmit.Visible = true;
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            String ID = BoxID.Text.ToString();
            if(Repository.RepositoryDetailTrans.SearchDetailByID(ID) != null)
            {
                LabelDelete.Text = "Cannot Delete";
            }
            else if(Repository.RepositoryMsProducts.SearchProductByID(ID) == null)
            {
                LabelDelete.Text = "Product id not found";
            }
            else
            {
                Repository.RepositoryMsProducts.DeleteProduct(ID);
                Response.Redirect("ViewProduct.aspx");
            }
        }
    }
}