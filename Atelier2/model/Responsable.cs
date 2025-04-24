using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2.model
{
    public class Responsable
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login)
        {
            this.Login = login;
            this.Pwd = pwd;
        }

        public string Login { get; set; }
        public string Pwd { get; set; }
    }
}
