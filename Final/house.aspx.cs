using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Character"] == null)
            {
                Response.Redirect("/index.aspx?NoCharacter=true");
            }
            lblName.Text = ((Character)Session["Character"]).CharacterName;
        }

        protected void btnSleep_Click(object sender, EventArgs e)
        {
            Character playerChar = (Character)Session["Character"];
            lblMessage.Text = "You have rested and restored " + playerChar.DamageTaken + " health.";
            playerChar.DamageTaken = 0;
            playerChar.Days++;
            
        }

        protected void btnMap_Click(object sender, EventArgs e)
        {
            Response.Redirect("map.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            saveSource.UpdateCommand = ((Character)Session["Character"]).SqlUpdate;
            saveSource.Update();
        }
    }
}