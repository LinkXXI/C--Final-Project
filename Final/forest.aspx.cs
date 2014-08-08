using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Final;

namespace Final
{
    public partial class Forest : System.Web.UI.Page
    {

        /*String pName;
        int pAttack;
        int pHealth;
        int pDamage;
        int pGold;

        int mlevel;
        String mName;
        int mAttack;
        int mHealth;
        int mDamage;
        int mGold;*/

        Character playerChar;
        Monster currentMonster;

        protected void Page_Load(object sender, EventArgs e)
        {
            playerChar = (Character)Session["Character"];
            lblMaxLevel.Text = playerChar.EnemyLevel.ToString();
            if (Session["Monster"] == null)
            {

                DataView dv = new DataView();
                dv = (DataView)monsterSource.Select(DataSourceSelectArguments.Empty);
                DataTable dt = new DataTable();
                dt = dv.ToTable();
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);

                DataRow dr = ds.Tables[0].Rows[0];

                currentMonster = new Monster();
                currentMonster.Level = (int)dr.ItemArray.GetValue(0);
                currentMonster.Name = (string)dr.ItemArray.GetValue(1);
                currentMonster.Attack = (int)dr.ItemArray.GetValue(2);
                currentMonster.Health = (int)dr.ItemArray.GetValue(3);
                currentMonster.goldReward = (int)dr.ItemArray.GetValue(4);
                //currentMonster.imgURL = (string)dr.ItemArray.GetValue(5);

                currentMonster.imgURL = "img/monsters/" + (int)dr.ItemArray.GetValue(0) + "monster.jpg";

                Session["Monster"] = currentMonster;
            }
            else
            {
                currentMonster = (Monster)Session["Monster"];
            }

            imgEnemy.ImageUrl = currentMonster.imgURL;

            lblCharacterInfo.Text = playerChar.CharacterName + " the " + playerChar.Class + ": " + playerChar.CurrentHealth + "/" + playerChar.Health
                + "<br />" + "Attack: " + playerChar.Attack;
            lblEnemyName.Text = currentMonster.Name;
            lblEnemyStats.Text = "Health: " + (currentMonster.Health - currentMonster.DamageTaken) + "/" + currentMonster.Health;

        }

        protected void btnAttack_Click(object sender, EventArgs e)
        {
            Character playerChar = (Character)Session["Character"];
            if (playerChar.CurrentHealth > 0)
            {
                Monster monster = (Monster)Session["Monster"];
                if (monster.CurrentHealth > 0)
                {
                    monster.DamageTaken += playerChar.Attack;

                    playerChar.DamageTaken += monster.Attack;

                    lblCharacterInfo.Text = playerChar.CharacterName + ":    Attack: " + playerChar.Attack + " Health: " + playerChar.CurrentHealth;
                    lblEnemyStats.Text = monster.Name + ":    Attack: " + monster.Attack + " Health: " + monster.CurrentHealth;

                }
                lblCharacterInfo.Text = "YOU WIN!";
            }
            lblCharacterInfo.Text = "YOU LOSE!";
        }

        protected void btnRun_Click(object sender, EventArgs e)
        {
            Response.Redirect("map.aspx");
        }
    }
}