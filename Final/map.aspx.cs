using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Character"] == null)
            {
                Response.Redirect("/index.aspx?NoCharacter=true");
            }
            if (Request.QueryString["Loaded"] == "true")
            {
                LabelMsg.Text = Request.QueryString["Message"];
            }
        }

        protected void btnHouse_Click(object sender, EventArgs e)
        {
            Response.Redirect("house.aspx");
        }

        protected void btnMine_Click(object sender, EventArgs e)
        {
            Response.Redirect("mine.aspx");
        }

        protected void btnShop_Click(object sender, EventArgs e)
        {
            Response.Redirect("shop.aspx");
        }
    }
}