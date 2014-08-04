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

        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("/newCharacter.aspx");
        }

        protected void btn_Click(object sender, EventArgs e)
        {

        }
    }
}