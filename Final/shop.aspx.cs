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
        String item;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Character"] == null)
            {
                Response.Redirect("/index.aspx?NoCharacter=true");
            }
            //dynamicly create item page from iterating through select * statement
            SqlCommand command = new SqlCommand();

        }

        protected void btnBuy_Click(object sender, EventArgs e)
        {
           
           shopList.InnerHtml = "YOU BOUGHT A " + item;
        }

        protected void btnMap_Click(object sender, EventArgs e)
        {
            Response.Redirect("map.aspx");
        }
        


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           item = GridView1.SelectedDataKey.Value.ToString();
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                GridView1.Rows[i].BackColor = Color.White;
            }
            GridView1.Rows[GridView1.SelectedIndex].BackColor = Color.Yellow;
        }
    }
}