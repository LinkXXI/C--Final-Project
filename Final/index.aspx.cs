using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Deleted"] == "true")
            {
                lblMessage.Text = Request.QueryString["CharacterName"] + " successfully deleted.";
            }
            if (Request.QueryString["NoCharacter"] == "true")
            {
                lblMessage.Text = "You must create or load a character to play!";
            }
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            Response.Redirect("/loadCharacter.aspx");
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("/newCharacter.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Response.Redirect("/deleteCharacter.aspx");
        }
    }
}