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
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try // need try-catch to catch SqlExceptions
            {
                characterSource.Select(DataSourceSelectArguments.Empty);
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
            }
            else
            {
                LabelMsg.ForeColor = Color.Red;
                LabelMsg.Text = "Error: This character could not be loaded.";
            }
        }
    }
}