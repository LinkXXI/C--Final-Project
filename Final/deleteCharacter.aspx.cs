using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Final
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                DataView dV = new DataView();
                dV = (DataView)deleteCharacterSource.Select(DataSourceSelectArguments.Empty);
                DataTable dt = dV.ToTable();
                if (dt.Rows.Count == 0)
                {
                    error.Attributes.Remove("hidden");
                    error.Attributes["class"] = "alert alert-warning";
                    lblMessage.Text = "No character with name " + txtCharName.Text + "found, unable to delete.";
                }
                else
                {
                    deleteCharacterSource.Delete();
                    Response.Redirect("index.aspx?Deleted=true&CharacterName=" + txtCharName.Text);
                }
            }
        }
    }
}