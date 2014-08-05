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

                Character playerChar = new Character();
                playerChar.Attack = attack;
                playerChar.Class = lstClassSelect.SelectedItem.Value;
                playerChar.Health = health;
                playerChar.Name = txtCharName.Text;

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