using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PageMaitre : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_deco_Click(object sender, EventArgs e)
    {
        Session["idCo"] = null;
        Response.Redirect("Default.aspx");
    }
}
