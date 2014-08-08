using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.SqlClient;
using System.Configuration;

namespace Final
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString);
            conn.Open();
            SqlCommand command = new SqlCommand(((Character)Session["Character"]).SqlUpdate, conn);
            command.ExecuteNonQuery();
        }

        protected void Application_End(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString);
            conn.Open();
            SqlCommand command = new SqlCommand(((Character)Session["Character"]).SqlUpdate, conn);
            command.ExecuteNonQuery();
        }
    }
}