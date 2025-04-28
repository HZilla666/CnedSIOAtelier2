namespace Atelier2.view
{
    partial class FormPersonnel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrpPersonnel = new System.Windows.Forms.GroupBox();
            this.DGVPersonnel = new System.Windows.Forms.DataGridView();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.GrpAjouterPersonnel = new System.Windows.Forms.GroupBox();
            this.LblService = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.TxtBoxMail = new System.Windows.Forms.TextBox();
            this.TxtBoxTel = new System.Windows.Forms.TextBox();
            this.TxtBoxSurname = new System.Windows.Forms.TextBox();
            this.LblSurname = new System.Windows.Forms.Label();
            this.LblMail = new System.Windows.Forms.Label();
            this.Lbltel = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.CmbService = new System.Windows.Forms.ComboBox();
            this.BtnShowAbsence = new System.Windows.Forms.Button();
            this.GrpPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersonnel)).BeginInit();
            this.GrpAjouterPersonnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpPersonnel
            // 
            this.GrpPersonnel.Controls.Add(this.DGVPersonnel);
            this.GrpPersonnel.Controls.Add(this.BtnSupprimer);
            this.GrpPersonnel.Controls.Add(this.BtnModifier);
            this.GrpPersonnel.Location = new System.Drawing.Point(13, 13);
            this.GrpPersonnel.Name = "GrpPersonnel";
            this.GrpPersonnel.Size = new System.Drawing.Size(492, 238);
            this.GrpPersonnel.TabIndex = 0;
            this.GrpPersonnel.TabStop = false;
            this.GrpPersonnel.Text = "personnel";
            // 
            // DGVPersonnel
            // 
            this.DGVPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPersonnel.Location = new System.Drawing.Point(10, 20);
            this.DGVPersonnel.Name = "DGVPersonnel";
            this.DGVPersonnel.Size = new System.Drawing.Size(460, 183);
            this.DGVPersonnel.TabIndex = 3;
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Location = new System.Drawing.Point(128, 209);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(116, 23);
            this.BtnSupprimer.TabIndex = 2;
            this.BtnSupprimer.Text = "supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.Location = new System.Drawing.Point(6, 209);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(116, 23);
            this.BtnModifier.TabIndex = 0;
            this.BtnModifier.Text = "modifier";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // GrpAjouterPersonnel
            // 
            this.GrpAjouterPersonnel.Controls.Add(this.LblService);
            this.GrpAjouterPersonnel.Controls.Add(this.BtnCancel);
            this.GrpAjouterPersonnel.Controls.Add(this.BtnSave);
            this.GrpAjouterPersonnel.Controls.Add(this.TxtBoxName);
            this.GrpAjouterPersonnel.Controls.Add(this.TxtBoxMail);
            this.GrpAjouterPersonnel.Controls.Add(this.TxtBoxTel);
            this.GrpAjouterPersonnel.Controls.Add(this.TxtBoxSurname);
            this.GrpAjouterPersonnel.Controls.Add(this.LblSurname);
            this.GrpAjouterPersonnel.Controls.Add(this.LblMail);
            this.GrpAjouterPersonnel.Controls.Add(this.Lbltel);
            this.GrpAjouterPersonnel.Controls.Add(this.LblName);
            this.GrpAjouterPersonnel.Controls.Add(this.CmbService);
            this.GrpAjouterPersonnel.Location = new System.Drawing.Point(13, 258);
            this.GrpAjouterPersonnel.Name = "GrpAjouterPersonnel";
            this.GrpAjouterPersonnel.Size = new System.Drawing.Size(492, 129);
            this.GrpAjouterPersonnel.TabIndex = 1;
            this.GrpAjouterPersonnel.TabStop = false;
            this.GrpAjouterPersonnel.Text = "Ajouter un personnel";
            // 
            // LblService
            // 
            this.LblService.AutoSize = true;
            this.LblService.Location = new System.Drawing.Point(217, 72);
            this.LblService.Name = "LblService";
            this.LblService.Size = new System.Drawing.Size(41, 13);
            this.LblService.TabIndex = 9;
            this.LblService.Text = "service";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(128, 98);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(116, 23);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "annuler";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(6, 98);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(116, 25);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "enregistrer";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(56, 20);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(155, 20);
            this.TxtBoxName.TabIndex = 8;
            // 
            // TxtBoxMail
            // 
            this.TxtBoxMail.Location = new System.Drawing.Point(271, 20);
            this.TxtBoxMail.Name = "TxtBoxMail";
            this.TxtBoxMail.Size = new System.Drawing.Size(166, 20);
            this.TxtBoxMail.TabIndex = 7;
            // 
            // TxtBoxTel
            // 
            this.TxtBoxTel.Location = new System.Drawing.Point(271, 46);
            this.TxtBoxTel.Name = "TxtBoxTel";
            this.TxtBoxTel.Size = new System.Drawing.Size(166, 20);
            this.TxtBoxTel.TabIndex = 6;
            // 
            // TxtBoxSurname
            // 
            this.TxtBoxSurname.Location = new System.Drawing.Point(56, 44);
            this.TxtBoxSurname.Name = "TxtBoxSurname";
            this.TxtBoxSurname.Size = new System.Drawing.Size(155, 20);
            this.TxtBoxSurname.TabIndex = 5;
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Location = new System.Drawing.Point(7, 44);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(42, 13);
            this.LblSurname.TabIndex = 4;
            this.LblSurname.Text = "prenom";
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Location = new System.Drawing.Point(217, 20);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(25, 13);
            this.LblMail.TabIndex = 3;
            this.LblMail.Text = "mail";
            // 
            // Lbltel
            // 
            this.Lbltel.AutoSize = true;
            this.Lbltel.Location = new System.Drawing.Point(217, 44);
            this.Lbltel.Name = "Lbltel";
            this.Lbltel.Size = new System.Drawing.Size(18, 13);
            this.Lbltel.TabIndex = 2;
            this.Lbltel.Text = "tel";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(7, 20);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(27, 13);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "nom";
            // 
            // CmbService
            // 
            this.CmbService.FormattingEnabled = true;
            this.CmbService.Location = new System.Drawing.Point(271, 72);
            this.CmbService.Name = "CmbService";
            this.CmbService.Size = new System.Drawing.Size(166, 21);
            this.CmbService.TabIndex = 0;
            // 
            // BtnShowAbsence
            // 
            this.BtnShowAbsence.Location = new System.Drawing.Point(12, 393);
            this.BtnShowAbsence.Name = "BtnShowAbsence";
            this.BtnShowAbsence.Size = new System.Drawing.Size(153, 23);
            this.BtnShowAbsence.TabIndex = 3;
            this.BtnShowAbsence.Text = "afficher les absence";
            this.BtnShowAbsence.UseVisualStyleBackColor = true;
            this.BtnShowAbsence.Click += new System.EventHandler(this.BtnShowAbsence_Click);
            // 
            // FormPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.BtnShowAbsence);
            this.Controls.Add(this.GrpAjouterPersonnel);
            this.Controls.Add(this.GrpPersonnel);
            this.Name = "FormPersonnel";
            this.Text = "FormAcceuil";
            this.GrpPersonnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersonnel)).EndInit();
            this.GrpAjouterPersonnel.ResumeLayout(false);
            this.GrpAjouterPersonnel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpPersonnel;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.GroupBox GrpAjouterPersonnel;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.Label Lbltel;
        private System.Windows.Forms.TextBox TxtBoxName;
        private System.Windows.Forms.TextBox TxtBoxMail;
        private System.Windows.Forms.TextBox TxtBoxTel;
        private System.Windows.Forms.TextBox TxtBoxSurname;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnShowAbsence;
        private System.Windows.Forms.DataGridView DGVPersonnel;
        private System.Windows.Forms.Label LblService;
        private System.Windows.Forms.ComboBox CmbService;
    }
}