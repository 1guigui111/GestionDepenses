using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;

namespace SiteWebV2.App_Code
{
    public class CoBD
    {
        public static List<T_Connexion> GetListConnexion()
        {
            BD_DepenseDataContext bd = new BD_DepenseDataContext();
            //List<T_Connexion> lstConnexion = bd.T_Connexion.ToList();
            Table<T_Connexion> t;
        }
    }
}