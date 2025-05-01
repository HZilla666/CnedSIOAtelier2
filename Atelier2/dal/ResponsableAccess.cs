using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atelier2.model;

namespace Atelier2.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant le responsable
    /// </summary>
    public class ResponsableAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public ResponsableAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Controle si l'utillisateur a le droit de se connecter (login et pwd)
        /// </summary>
        /// <param name="admin">objet contenant les identifiants</param>
        /// <returns>vrai si les identifiants de connexion sont bons </returns>
        public Boolean ControleAutentification(Admin admin)
        {
            if (access.Manager != null)
            {
                string req = "select * from responsable r ";
                req += "where r.login=@login and pwd=SHA2(@pwd, 256);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@login", admin.Login);
                parameters.Add("@pwd", admin.Pwd);
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        return (records.Count > 0);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return false;
        }

    }
}
