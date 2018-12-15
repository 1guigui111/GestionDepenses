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
        if(Session["idCo"] == null)
        {
            Response.Redirect("Default.aspx");
        }
    }

    protected void btn_appliquer_Click(object sender, EventArgs e)
    {
        if(tbx_litre.Text != "" && tbx_nbKilo.Text != "" && tbx_cout.Text != "" && tbx_calender.Text != null)
        {
            T_FactureGaz newfac = new T_FactureGaz();
            newfac.nbKilo = float.Parse(tbx_nbKilo.Text);
            newfac.litre = float.Parse(tbx_litre.Text);
            newfac.cout = decimal.Parse(tbx_cout.Text);
            newfac.ddate = DateTime.Parse(tbx_calender.Text);
            newfac.idCo = int.Parse(Session["idCo"].ToString());
            CoBD.AjouterGaz(newfac);
            Response.Redirect("Acceuil.aspx");
        }
    }
}