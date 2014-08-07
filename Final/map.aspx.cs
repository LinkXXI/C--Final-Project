﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Character"] == null)
            {
                Response.Redirect("/index.aspx");
            }
            else {
                string message = (string)(Session["message"]);
                if (message != null)
                {
                    LabelMsg.Text = message;
                    Session["message"] = null;
                }
            }
        }

        protected void btnHouse_Click(object sender, EventArgs e)
        {
            Response.Redirect("house.aspx");
        }
    }
}