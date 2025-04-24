using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Atelier2.model
{
    /// <summary>
    /// Classe métier interne pour les personnels
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="service"></param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, Service service)
        {
            this.IdPersonnel = idpersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.Service = service;
        }

        /// <summary>
        /// Identifiant unique du personnel.
        /// </summary>
        public int IdPersonnel { get; }

        /// <summary>
        /// Nom de famille du personnel.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Prénom du personnel.
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Numéro de téléphone du personnel.
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// Adresse mail professionnelle ou personnelle du personnel.
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Service auquel appartient le personnel.
        /// </summary>
        public Service Service { get; set; }
    }
}
