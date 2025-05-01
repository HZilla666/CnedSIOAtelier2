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
        /// <param name="personnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="motif"></param>
        public Absence(Personnel personnel, DateTime datedebut, DateTime datefin,Motif motif)
        {
            this.Personnel = personnel;
            this.DateDebut = datedebut;
            this.DateFin = datefin;
            this.Motif = motif;
        }

        /// <summary>
        /// Identifiant unique du personnel concerné par l'absence.
        /// </summary>
        public Personnel Personnel { get; set; }

        /// <summary>
        /// Date de début de l'absence (au format string, à convertir idéalement en DateTime).
        /// </summary>
        public DateTime DateDebut { get; set; }

        /// <summary>
        /// Date de fin de l'absence (au format string, à convertir idéalement en DateTime).
        /// </summary>
        public DateTime DateFin { get; set; }

        /// <summary>
        /// Motif de l'absence, représenté par un objet de type Motif.
        /// </summary>
        public Motif Motif { get; set; }
    }
}
