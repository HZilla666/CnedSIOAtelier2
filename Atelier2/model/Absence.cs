using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les absences
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="motif"></param>
        public Absence(int idpersonnel, string datedebut, string datefin,Motif motif)
        {
            this.IdPersonnel = idpersonnel;
            this.DateDebut = datedebut;
            this.DateFin = datefin;
            this.Motif = motif;
        }

        /// <summary>
        /// Identifiant unique du personnel concerné par l'absence.
        /// </summary>
        public int IdPersonnel { get; set; }

        /// <summary>
        /// Date de début de l'absence (au format string, à convertir idéalement en DateTime).
        /// </summary>
        public string DateDebut { get; set; }

        /// <summary>
        /// Date de fin de l'absence (au format string, à convertir idéalement en DateTime).
        /// </summary>
        public string DateFin { get; set; }

        /// <summary>
        /// Motif de l'absence, représenté par un objet de type Motif.
        /// </summary>
        public Motif Motif { get; set; }
    }
}
