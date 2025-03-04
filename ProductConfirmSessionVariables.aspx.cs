using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionVariable5834255
{
    public partial class ProductConfirmSessionVariables : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Retrieve the session variables
            ddlCategory.SelectedValue = Session["ddlCategory"].ToString();
            ddlSupplier.SelectedValue = Session["ddlSupplier"].ToString();
            lblProduct.Text = Session["strProduct"].ToString();
            txtDescription.Text = Session["strDescription"].ToString();
            lblImage.Text = Session["strImage"].ToString();
            decimal decPrice = Convert.ToDecimal(Session["decPrice"].ToString());
            lblPrice.Text = decPrice.ToString("c");
            lblNumberInStock.Text = Session["bytNumberInStock"].ToString();
            lblNumberOnOrder.Text = Session["bytNumberOnOrder"].ToString();
            lblReorderLevel.Text = Session["bytReorderLevel"].ToString();
            //Compute and display the value in stock and the value on order
            byte bytNumberInStock = Convert.ToByte(Session["bytNumberInStock"].ToString());
            byte bytNumberOnOrder = Convert.ToByte(Session["bytNumberOnOrder"].ToString());
            decimal decValueInStock = decPrice * bytNumberInStock;
            decimal decValueOnOrder = decPrice * bytNumberOnOrder;
            lblValueInStock.Text = " (Value: " + decValueInStock.ToString("c") + ")";
            lblValueOnOrder.Text = " (Value: " + decValueOnOrder.ToString("c") + ")";
            if (!IsPostBack)
            {
                ddlCategory.Enabled = false;
                ddlSupplier.Enabled = false;
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductEnterSessionVariables.aspx");
        }
    }
}