using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final
{
    public partial class NestedMasterPage1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.PreRender += new EventHandler(NestedMasterPage1_PreRender);
        }

        void NestedMasterPage1_PreRender(object sender, EventArgs e)
        {
            lblCharData.Text = ((Character)Session["Character"]).ToString();
        }
    }
}