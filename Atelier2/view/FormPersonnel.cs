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
    /// Fenêtre d'affichage des personnels et de leurs services
    /// </summary>
    public partial class FormPersonnel: Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifPersonnel = false;
        /// <summary>
        /// Objet pour gérer la liste des personnels
        /// </summary>
        private BindingSource bdgPersonnels = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des services
        /// </summary>
        private BindingSource bdgServices = new BindingSource();
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FormPersonnelController controller;

        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FormPersonnel()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FormPersonnelController();
            RemplirListePersonnels();
            RemplirListeServices();
            EnCourseModifPersonnel(false);
        }


        /// <summary>
        /// Affiche les personnels
        /// </summary>
        private void RemplirListePersonnels()
        {
            List<Personnel> lesPersonnels = controller.GetLesPersonnels();
            bdgPersonnels.DataSource = lesPersonnels;
            DGVPersonnel.DataSource = bdgPersonnels;
            DGVPersonnel.Columns["idpersonnel"].Visible = false;
            DGVPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affiche les services
        /// </summary>
        private void RemplirListeServices()
        {
            List<Service> lesServices = controller.GetLesServices();
            bdgServices.DataSource = lesServices;
            CmbService.DataSource = bdgServices;
        }

        /// <summary>
        ///  Demande de modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (DGVPersonnel.SelectedRows.Count > 0)
            {
                EnCourseModifPersonnel(true);
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                TxtBoxName.Text = personnel.Nom;
                TxtBoxSurname.Text = personnel.Prenom;
                TxtBoxTel.Text = personnel.Tel;
                TxtBoxMail.Text = personnel.Mail;
                CmbService.SelectedIndex = CmbService.FindStringExact(personnel.Service.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (DGVPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnels();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }


        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!TxtBoxName.Text.Equals("") && !TxtBoxSurname.Text.Equals("") && !TxtBoxTel.Text.Equals("") && !TxtBoxMail.Text.Equals("") && CmbService.SelectedIndex != -1)
            {
                Service service = (Service)bdgServices.List[bdgServices.Position];
                if (enCoursDeModifPersonnel)
                {
                    Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                    personnel.Nom = TxtBoxName.Text;
                    personnel.Prenom = TxtBoxSurname.Text;
                    personnel.Tel = TxtBoxTel.Text;
                    personnel.Mail = TxtBoxMail.Text;
                    personnel.Service = service;
                    controller.UpdatePersonnel(personnel);
                }
                else
                {
                    Personnel personnel = new Personnel(0, TxtBoxName.Text, TxtBoxSurname.Text, TxtBoxTel.Text, TxtBoxMail.Text, service);
                    controller.AddPersonnel(personnel);
                }
                RemplirListePersonnels();
                EnCourseModifPersonnel(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        /// <summary>
        /// Annule la demande d'ajout ou de modification d'un personnel
        /// Vide les zones de saisie du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCourseModifPersonnel(false);
            }
        }

        /// <summary>
        /// Demande d'accès aux absences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowAbsence_Click(object sender, EventArgs e)
        {
            Personnel selectedPersonnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
            FormAbsence formAbsence = new FormAbsence(selectedPersonnel);
            formAbsence.ShowDialog();
        }

        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'un personnel
        /// </summary>
        /// <param name="modif"></param>
        private void EnCourseModifPersonnel(Boolean modif)
        {
            enCoursDeModifPersonnel = modif;
            GrpPersonnel.Enabled = !modif;
            if (modif)
            {
                GrpAjouterPersonnel.Text = "modifier un personnel";
            }
            else
            {
                GrpPersonnel.Text = "ajouter un personnel";
                TxtBoxName.Text = "";
                TxtBoxSurname.Text = "";
                TxtBoxTel.Text = "";
                TxtBoxMail.Text = "";
            }
        }
    }
}
