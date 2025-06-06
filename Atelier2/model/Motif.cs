﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2.model
{
    /// <summary>
    /// Classe métier interne pour les motifs
    /// </summary>
    public class Motif
    {
        /// <summary>
        /// Identifiant unique du motif.
        /// </summary>
        public int IdMotif { get; }

        /// <summary>
        /// Libellé descriptif du motif (exemple : "Maladie", "Congé", etc.).
        /// </summary>
        public string Libelle { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            this.IdMotif = idmotif;
            this.Libelle = libelle;
        }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>libellé du motif</returns>
        public override string ToString()
        {
            return this.Libelle;
        }
    }
}

