using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final
{
    public partial class Forest : System.Web.UI.Page
    {
        String pName;
        int pAttack;
        int pHealth;
        int pDamage;
        int pGold;

        int mlevel;
        String mName;
        int mAttack;
        int mHealth;
        int mDamage;
        int mGold;

        protected void Page_Load(object sender, EventArgs e)
        {
            Div1.InnerHtml = GridView1.Rows[0].Cells[0].Text.ToString();
            Div2.InnerHtml = GridView1.Rows[0].Cells[1].Text.ToString();
            Div3.InnerHtml = GridView1.Rows[0].Cells[2].Text.ToString();
            Div4.InnerHtml = GridView1.Rows[0].Cells[3].Text.ToString();
            Div5.InnerHtml = GridView1.Rows[0].Cells[4].Text.ToString();

            //player stats
            
            pName = ((Character)Session["Character"]).CharacterName;
            pAttack = ((Character)Session["Character"]).Attack;
            pHealth = ((Character)Session["Character"]).Health;
            pDamage = ((Character)Session["Character"]).DamageTaken;
            pGold = ((Character)Session["Character"]).Gold;

            pHealth -= pDamage; 

            //monster stats
            mlevel = Convert.ToInt32(Div1.InnerHtml);
            mName = Convert.ToString(Div2.InnerHtml);
            ((Character)Session["Monster"]).CharacterName = mName;
            mAttack = Convert.ToInt32(Div3.InnerText);
           // ((Character)Session["Monster"]).Attack = mAttack;
            mHealth = Convert.ToInt32(Div4.InnerText);
           // mDamage = ((Character)Session["Monster"]).DamageTaken;
          //  ((Character)Session["Monster"]).Health = mHealth;
            mGold = Convert.ToInt32(Div5.InnerText);
           // ((Character)Session["Monster"]).Gold = mGold;

            player.InnerHtml = pName + ":    Attack: " + pAttack + " Health: " + pHealth;

        }

        protected void Attack_Click(object sender, EventArgs e)
        {
            if (pHealth > 0)
            {
                if (mHealth > 0)
                {
                    mDamage += pAttack;
                    mDamage = ((Character)Session["Monster"]).DamageTaken;
                    mHealth = mHealth - mDamage;

                    pDamage += mAttack;
                    pDamage = ((Character)Session["Character"]).DamageTaken;
                    pHealth = pHealth - pDamage;

                    player.InnerHtml = pName + ":    Attack: " + pAttack + " Health: " + pHealth;
                    monster.InnerHtml = mName + ":    Attack: " + mAttack + " Health: " + mHealth;

                }
                player.InnerHtml = "YOU WIN!";
            }
            player.InnerHtml = "YOU LOSE!";
        }

        protected void Run_Click(object sender, EventArgs e)
        {
            Response.Redirect("map.aspx");
        }
    }
}