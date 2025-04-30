using Atelier2.controller;
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
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifAbsence = false;
        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        private BindingSource bdgAbsence = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des profils
        /// </summary>
        private BindingSource bdgMotif = new BindingSource();
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FormAbsenceController controller;
        /// <summary>
        /// Personnel transmis par le formulaire Personnel
        /// </summary>
        private Personnel Personnel;
        /// <summary>
        /// Date de début avant modification
        /// </summary>
        private DateTime oldDateDebut;

        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FormAbsence(Personnel personnel)
        {
            InitializeComponent();
            this.Personnel = personnel;
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FormAbsenceController();
            GrpAbsence.Text = "Absence pour " + Personnel.Prenom + " " + Personnel.Nom;
            DtpStart.Format = DateTimePickerFormat.Custom;
            DtpStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            DtpEnd.Format = DateTimePickerFormat.Custom;
            DtpEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            RemplirListeAbsences();
            RemplirListeMotifs();
            EnCourseModifAbsence(false);
        }

        /// <summary>
        /// Affiche les absences
        /// </summary>

        private void RemplirListeAbsences()
        {
            List<Absence> lesAbsences = controller.GetLesAbsences(this.Personnel);
            bdgAbsence.DataSource = lesAbsences;
            DGVAbsences.DataSource = bdgAbsence;
            DGVAbsences.Columns["personnel"].Visible = false;
            DGVAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affiche les motifs
        /// </summary>
        private void RemplirListeMotifs()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            bdgMotif.DataSource = lesMotifs;
            CmbMotif.DataSource = bdgMotif;
        }

        /// <summary>
        ///  Demande de modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (DGVAbsences.SelectedRows.Count > 0)
            {
                EnCourseModifAbsence(true);
                Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                this.oldDateDebut = absence.DateDebut;
                DtpStart.Value = absence.DateDebut;
                DtpEnd.Value = absence.DateFin;
                CmbMotif.SelectedIndex = CmbMotif.FindStringExact(absence.Motif.Libelle);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (DGVAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + absence.Personnel.IdPersonnel + " " + absence.DateDebut + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    RemplirListeAbsences();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'un absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (DtpStart.Value <= DtpEnd.Value && CmbMotif.SelectedIndex != -1)
            {
                Motif motif = (Motif)bdgMotif.List[bdgMotif.Position];
                if (enCoursDeModifAbsence)
                {
                    Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                    absence.Personnel = this.Personnel;
                    absence.DateDebut = DtpStart.Value;
                    absence.DateFin = DtpEnd.Value;
                    absence.Motif = motif;
                    controller.UpdateAbsence(absence, this.oldDateDebut);
                }
                else
                {
                    Absence absence = new Absence(this.Personnel, DtpStart.Value, DtpEnd.Value, motif);
                    controller.AddAbsence(absence);
                }
                RemplirListeAbsences();
                EnCourseModifAbsence(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        /// <summary>
        /// Annule la demande d'ajout ou de modification d'un absence
        /// Vide les zones de saisie du absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCourseModifAbsence(false);
            }
        }



        

        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'un absence
        /// </summary>
        /// <param name="modif"></param>
        private void EnCourseModifAbsence(Boolean modif)
        {
            enCoursDeModifAbsence = modif;
            GrpAbsence.Enabled = !modif;
            if (modif)
            {
                GrpAbsence.Text = "modifier un absence";
            }
            else
            {
                GrpAjouterAbsence.Text = "ajouter un absence";
                DtpStart.Value= DateTime.Today;
                DtpEnd.Value = DateTime.Today;

            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
