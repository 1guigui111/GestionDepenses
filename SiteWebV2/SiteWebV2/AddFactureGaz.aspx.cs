using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddFactureGaz : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_appliquer_Click(object sender, EventArgs e)
    {
        if(tbx_cout.Text != "" && tbx_nbKilo.Text != "" && tbx_calender.Text != null)
        {
            T_FactureGaz newfac = new T_FactureGaz();
            newfac.nbKilo = decimal.Parse(tbx_nbKilo.Text);
            newfac.cout = float.Parse(tbx_cout.Text);
            newfac.ddate = DateTime.Parse(tbx_calender.Text);
            newfac.idCo = int.Parse(Session["idCo"].ToString());
            SiteWebV2.CoBD.AjouterGaz(newfac);
            Response.Redirect("Test2.aspx");
        }
    }
}