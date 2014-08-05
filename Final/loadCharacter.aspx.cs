using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;

namespace Final
{
    public partial class WebForm4 : System.Web.UI.Page
    {

        DataView dv;
        DataTable dt;
        DataSet ds;

        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try // need try-catch to catch SqlExceptions
            {
                // this fires the characterSource_Selected event below
                // store what is returned by SELECT into a DataView. More in the characterSource_Selected event
                dv = (DataView)characterSource.Select(DataSourceSelectArguments.Empty);

            }
            catch (SqlException ex)
            {
                // unsuccessful, display msg

                //LabelMsg.Text = "Error: " + ex.Message;
                LabelMsg.Text = "Error: This character could not be loaded.";
            }
        }

        protected void characterSource_Selected(object sender, SqlDataSourceStatusEventArgs e)
        {
            if (e.AffectedRows > 0)
            {
                LabelMsg.ForeColor = Color.Green;
                LabelMsg.Text = "Character successfully loaded.";
                // create character object with attributes from db
                dt = dv.ToTable();
                ds = new DataSet();
                ds.Tables.Add(dt);

                DataRow dRow = ds.Tables[0].Rows[1];
                string characterName = dRow.ItemArray.GetValue(1).ToString();
                string characterClass = dRow.ItemArray.GetValue(2).ToString();
                int attack = (int)dRow.ItemArray.GetValue(3);
                int health = (int)dRow.ItemArray.GetValue(4);
                int damage = (int)dRow.ItemArray.GetValue(5);
                int days = (int)dRow.ItemArray.GetValue(6);
                int enemyLevel = (int)dRow.ItemArray.GetValue(7);

                Character playerChar = new Character();
                playerChar.Name = characterName;
                playerChar.Class = characterClass;
                playerChar.Attack = attack;
                playerChar.Health = health;
                playerChar.DamageTaken = damage;
                //playerChar.Days = days;
                //playerChar.EnemyLevel = health;

                Session.Add("Character", playerChar);
            }
        }
    }
}