using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_connexion_Click(object sender, EventArgs e)
    {
        T_Connexion co = SiteWebV2.CoBD.GetConnexionByUserName(tbx_username.Text, tbx_password.Text);
        if(co != null)
        {
            ajouterSession(co);
            Response.Redirect("Acceuil.aspx");
        }
    }

    private void ajouterSession(T_Connexion co)
    {
        Session["idCo"] = co.idCo;
    }
}