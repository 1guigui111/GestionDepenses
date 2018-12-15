using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Acceuil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["idCo"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        loadListeFactures();
    }

    private void loadListeFactures()
    {
        tab_data.Rows.Clear();
        List<T_FactureGaz> listFac = CoBD.GetListFacGaz();
        //Titres du tableau
        TableHeaderRow thr = new TableHeaderRow();
        TableHeaderCell thc_Date = new TableHeaderCell();
        thc_Date.Text = "Date";
        thr.Cells.Add(thc_Date);
        TableHeaderCell thc_autonomie = new TableHeaderCell();
        thc_autonomie.Text = "L / 100";
        thr.Cells.Add(thc_autonomie);
        TableHeaderCell thc_supprimer = new TableHeaderCell();
        thc_supprimer.Text = "Supprimer";
        thr.Cells.Add(thc_supprimer);
        tab_data.Rows.Add(thr);

        foreach (T_FactureGaz t_Facture in listFac)
        {
            TableRow tr = new TableRow();
            TableCell tc_date = new TableCell();
            tc_date.Text = string.Format("{0:d}", t_Facture.ddate);
            tr.Cells.Add(tc_date);
            TableCell tc_autonomie = new TableCell();
            tc_autonomie.Text = string.Format("{0:0.00}", Utilitaires.GetAutonomie((float)t_Facture.nbKilo, (float)t_Facture.litre));
            tr.Cells.Add(tc_autonomie);
            TableCell tc_supprimer = new TableCell();
            LinkButton btn_supp = new LinkButton();
            btn_supp.ID = "btn_supp-" + t_Facture.idFac;
            btn_supp.CssClass = "far fa-times-circle";
            btn_supp.Click += btnSupp_OnClick;
            tc_supprimer.Controls.Add(btn_supp);
            tr.Cells.Add(tc_supprimer);
            tab_data.Rows.Add(tr);
        }
    }

    private void btnSupp_OnClick(Object sender, EventArgs e)
    {
        CoBD.DeleteFactureById(int.Parse(((LinkButton)sender).ID.Split('-')[1]));
        loadListeFactures();
    }

}