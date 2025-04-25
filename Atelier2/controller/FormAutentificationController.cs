using System;
using Atelier2.dal;
using Atelier2.model;

namespace Atelier2.controller
{
    /// <summary>
    /// Contrôleur de FormAutentification
    /// </summary>
    public class FormAutentificationController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Responsable
        /// </summary>
        private readonly ResponsableAccess responsableAccess;

        /// <summary>
        /// Récupère l'acces aux données
        /// </summary>
        public FormAutentificationController()
        {
            responsableAccess = new ResponsableAccess();
        }

        /// <summary>
        /// Vérifie l'autentification
        /// </summary>
        /// <param name="admin">objet contenant les informations de connexion</param>
        /// <returns> vrai si les informations de connexion sont correctes</returns>
        public Boolean ControleAutentification(Admin admin)
        {
            return responsableAccess.ControleAutentification(admin);
        }
    }
}
