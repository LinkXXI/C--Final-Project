using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Final
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                int attack = 0;
                int health = 0;
                int damageTaken = 0;
                int days = 0;
                int enemyLevel = 0;

                switch (lstClassSelect.SelectedItem.Value)
                {
                    case "Warrior":
                        health = 100;
                        attack = 50;
                        break;
                    case "Wizard":
                        health = 50;
                        attack = 100;
                        break;
                }

                Character playerChar = new Character();
                playerChar.CharacterName = txtCharName.Text;
                playerChar.Class = lstClassSelect.SelectedItem.Value;
                playerChar.Attack = attack;
                playerChar.Health = health;
                playerChar.DamageTaken = damageTaken;
                playerChar.Days = days;
                playerChar.EnemyLevel = enemyLevel;
                playerChar.Gold = 1000;

                Session.Add("Character", playerChar);

                SqlCommand command = new SqlCommand();

                characterSource.InsertCommand = playerChar.SqlInsert;

                try // need try-catch to catch SqlExceptions
                {
                    characterSource.Insert();

                    string message = "Character successfully created.";
                    Session["message"] = message;
                    Response.Redirect("map.aspx");
                }
                catch (SqlException ex)
                {
                    // unsuccessful, display msg

                    //LabelMsg.Text = "Error: " + ex.Message;
                    LabelMsg.Text = "Error: This character already exists, please choose a new name.";
                }

            }
        }
    }
}