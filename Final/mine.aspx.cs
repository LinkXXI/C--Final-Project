using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final
{
    public partial class mine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnMap_Click(object sender, EventArgs e)
        {
            Response.Redirect("map.aspx");
        }

        protected void btnMine_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Character playerChar = (Character)Session["Character"];

            int goldEarned = random.Next(1, 10000);
            playerChar.AddGold(goldEarned);
            playerChar.Days++;
            lblMessage.Text = "You earned " + goldEarned + " gold today in the mines.";
        }
    }
}