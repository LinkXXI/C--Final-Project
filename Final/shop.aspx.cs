using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;

namespace Final
{


    public partial class shop : System.Web.UI.Page
    {
        String item = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            //dynamicly create item page from iterating through select * statement
            SqlCommand command = new SqlCommand();

        }

        protected void btnBuy_Click(object sender, EventArgs e)
        {
            //player current stats
            String p1 = Convert.ToString(((Character)Session["Character"]).CharacterName);
            int pAttack;
            pAttack = ((Character)Session["Character"]).Attack;
            int pHealth;
            pHealth = ((Character)Session["Character"]).Health;
            int pGold;
            pGold = ((Character)Session["Character"]).Gold;

            //item stats
            int itemAttack = Convert.ToInt32(Div2.InnerText);
            int itemHealth = Convert.ToInt32(Div3.InnerText);
            int itemCost = Convert.ToInt32(Div5.InnerText);

            if (pGold >= itemCost)
            {
                pGold -= itemCost;
                ((Character)Session["Character"]).Gold = pGold;
                pAttack += itemAttack;
                ((Character)Session["Character"]).Attack = pAttack;
                pHealth += itemHealth;
                ((Character)Session["Character"]).Health = pHealth;

                messageDiv.Attributes.Remove("hidden");
                messageDiv.Attributes.Add("class", "alert alert-success");
                message.InnerHtml = "You bought " + Div1.InnerText;
            }
            else
            {
                messageDiv.Attributes.Remove("hidden");
                messageDiv.Attributes.Add("class", "alert alert-warning");
                message.InnerHtml = "You dont have enough gold to buy " + Div1.InnerText;
            }

        }

        protected void btnMap_Click(object sender, EventArgs e)
        {
            Response.Redirect("map.aspx");
        }



        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Div1.InnerHtml = GridView1.SelectedRow.Cells[1].Text.ToString();
            Div2.InnerHtml = GridView1.SelectedRow.Cells[2].Text.ToString();
            Div3.InnerHtml = GridView1.SelectedRow.Cells[3].Text.ToString();
            Div4.InnerHtml = GridView1.SelectedRow.Cells[4].Text.ToString();
            Div5.InnerHtml = GridView1.SelectedRow.Cells[5].Text.ToString();


            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                GridView1.Rows[i].BackColor = Color.White;
            }
            GridView1.Rows[GridView1.SelectedIndex].BackColor = Color.Yellow;
        }
    }
}