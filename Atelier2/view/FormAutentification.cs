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
    /// Fenêtre d'authentification (seul le responsable peut accéder à l'application)
    /// </summary>
    public partial class FormAutentification: Form
    {
        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FormAutentification()
        {
            InitializeComponent();
        }
    }
}
