using Atelier2.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier2.view
{
    /// <summary>
    /// Fenêtre d'affichage des absences et de leurs motifs
    /// </summary>
    public partial class FormAbsence: Form
    {
        private Personnel Personnel;
        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FormAbsence(Personnel personnel)
        {
            InitializeComponent();
            this.Personnel = personnel;
            GrpAbscence.Text = Personnel.ToString();
        }
    }
}
