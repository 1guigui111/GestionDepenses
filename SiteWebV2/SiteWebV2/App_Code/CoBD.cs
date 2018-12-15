using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Description résumée de Utilitaires
/// </summary>
public class CoBD
{
    public static List<T_Connexion> GetListConnexion()
    {
        DepenseBDDataContext bd = new DepenseBDDataContext();
        List<T_Connexion> lstConnexion = bd.T_Connexion.ToList();
        bd.Dispose();
        return lstConnexion;
    }

    public static T_Connexion GetConnexionByUserName(string p_username, string password)
    {
        DepenseBDDataContext bd = new DepenseBDDataContext();
        try
        {
            T_Connexion co = bd.T_Connexion.Single(f => f.username == p_username && f.pwd == password);
            bd.Dispose();
            return co;
        }
        catch(System.InvalidOperationException ex)
        {
            bd.Dispose();
            return null;
        }
    }

    public static void AjouterGaz(T_FactureGaz newfac)
    {
        DepenseBDDataContext bd = new DepenseBDDataContext();
        bd.T_FactureGaz.InsertOnSubmit(newfac);
        bd.SubmitChanges();
        bd.Dispose();
    }

    public static List<T_FactureGaz> GetListFacGaz()
    {
        DepenseBDDataContext bd = new DepenseBDDataContext();
        List<T_FactureGaz> rtnList = bd.T_FactureGaz.ToList();
        bd.Dispose();
        return rtnList;
    }

    public static T_Connexion GetCoById(int id)
    {
        DepenseBDDataContext bd = new DepenseBDDataContext();
        T_Connexion co = bd.T_Connexion.Single(f => f.idCo == id);
        bd.Dispose();
        return co;
    }

    public static void DeleteFactureById(int id)
    {
        DepenseBDDataContext bd = new DepenseBDDataContext();
        bd.T_FactureGaz.DeleteOnSubmit(bd.T_FactureGaz.Single(f => f.idFac == id));
        bd.SubmitChanges();
        bd.Dispose();
    }
}
