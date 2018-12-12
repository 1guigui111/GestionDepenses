using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;

namespace SiteWebV2
{
    public class CoBD
    {
        public static List<T_Connexion> GetListConnexion()
        {
            BD_DepenseDataContext bd = new BD_DepenseDataContext();
<<<<<<< HEAD
            //List<T_Connexion> lstConnexion = bd.T_Connexion.ToList();
            Table<T_Connexion> t;
            return null;
=======
            List<T_Connexion> lstConnexion = bd.T_Connexion.ToList();
            bd.Dispose();
            return lstConnexion;
        }

        public static T_Connexion GetConnexionByUserName(string p_username)
        {
            try
            {
                BD_DepenseDataContext bd = new BD_DepenseDataContext();
                T_Connexion co = bd.T_Connexion.Single(f => f.username == p_username);
                bd.Dispose();
                return co;
            }
            catch(System.InvalidOperationException ex)
            {
                
            }
            return null;
            
>>>>>>> 20890dd58785f01b25fa2903ebd5bda5a4035512
        }
    }
}