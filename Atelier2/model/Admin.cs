using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations d'authentification
    /// </summary>
    public class Admin
    {
        /// <summary>
        /// Getter sur la chaine login
        /// </summary>
        public string Login { get; }
        /// <summary>
        /// Getter sur la chaine mot de passe
        /// </summary>
        public string Pwd { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Admin(string login, string pwd)
        {
            this.Login = login;
            this.Pwd = pwd;
        }
    }
}
