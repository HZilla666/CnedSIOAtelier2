using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2.model
{
    /// <summary>
    /// Classe métier interne pour le responsable
    /// </summary>
    public class Responsable
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login,string pwd)
        {
            this.Login = login;
            this.Pwd = pwd;
        }

        /// <summary>
        /// Identifiant de connexion de l'utilisateur.
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Mot de passe associé au compte de l'utilisateur.
        /// </summary>
        public string Pwd { get; set; }

    }
}
