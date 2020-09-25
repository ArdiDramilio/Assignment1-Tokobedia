using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment.View
{
    public partial class UpdateProductType : System.Web.UI.Page
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
                }
            }
        }
        public void FetchFromDB()
        {
            GridView1.DataSource = Repository.RepositoryMsProductType.FetchData().ToList();
            GridView1.DataBind();
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (Repository.RepositoryMsProductType.SearchTypeByID(BoxTypeID.Text.ToString()) == null)
            {
                LabelID.Text = "Product type id cannot found";
            }
            else
            {
                Response.Redirect("UpdateProductType2.aspx?id=" + BoxTypeID.Text.ToString());
            }
        }
    }
}