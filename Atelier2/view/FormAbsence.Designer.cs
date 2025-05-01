namespace Atelier2.view
{
    partial class FormAbsence
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.GrpAjouterAbsence = new System.Windows.Forms.GroupBox();
            this.CmbMotif = new System.Windows.Forms.ComboBox();
            this.LblMotif = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LblDatedefin = new System.Windows.Forms.Label();
            this.LblDateDeDebut = new System.Windows.Forms.Label();
            this.GrpAbsence = new System.Windows.Forms.GroupBox();
            this.DGVAbsences = new System.Windows.Forms.DataGridView();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.DtpStart = new System.Windows.Forms.DateTimePicker();
            this.DtpEnd = new System.Windows.Forms.DateTimePicker();
            this.GrpAjouterAbsence.SuspendLayout();
            this.GrpAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(154, 404);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(153, 23);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.Text = "retour au personnel";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // GrpAjouterAbsence
            // 
            this.GrpAjouterAbsence.Controls.Add(this.DtpEnd);
            this.GrpAjouterAbsence.Controls.Add(this.DtpStart);
            this.GrpAjouterAbsence.Controls.Add(this.CmbMotif);
            this.GrpAjouterAbsence.Controls.Add(this.LblMotif);
            this.GrpAjouterAbsence.Controls.Add(this.BtnCancel);
            this.GrpAjouterAbsence.Controls.Add(this.BtnSave);
            this.GrpAjouterAbsence.Controls.Add(this.LblDatedefin);
            this.GrpAjouterAbsence.Controls.Add(this.LblDateDeDebut);
            this.GrpAjouterAbsence.Location = new System.Drawing.Point(155, 269);
            this.GrpAjouterAbsence.Name = "GrpAjouterAbsence";
            this.GrpAjouterAbsence.Size = new System.Drawing.Size(492, 129);
            this.GrpAjouterAbsence.TabIndex = 5;
            this.GrpAjouterAbsence.TabStop = false;
            this.GrpAjouterAbsence.Text = "Ajouter une absence";
            // 
            // CmbMotif
            // 
            this.CmbMotif.FormattingEnabled = true;
            this.CmbMotif.Location = new System.Drawing.Point(86, 71);
            this.CmbMotif.Name = "CmbMotif";
            this.CmbMotif.Size = new System.Drawing.Size(155, 21);
            this.CmbMotif.TabIndex = 10;
            // 
            // LblMotif
            // 
            this.LblMotif.AutoSize = true;
            this.LblMotif.Location = new System.Drawing.Point(7, 72);
            this.LblMotif.Name = "LblMotif";
            this.LblMotif.Size = new System.Drawing.Size(29, 13);
            this.LblMotif.TabIndex = 9;
            this.LblMotif.Text = "motif";
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
            this.BtnSave.Text = "engegistrer";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LblDatedefin
            // 
            this.LblDatedefin.AutoSize = true;
            this.LblDatedefin.Location = new System.Drawing.Point(7, 46);
            this.LblDatedefin.Name = "LblDatedefin";
            this.LblDatedefin.Size = new System.Drawing.Size(57, 13);
            this.LblDatedefin.TabIndex = 4;
            this.LblDatedefin.Text = "date de fin";
            // 
            // LblDateDeDebut
            // 
            this.LblDateDeDebut.AutoSize = true;
            this.LblDateDeDebut.Location = new System.Drawing.Point(7, 20);
            this.LblDateDeDebut.Name = "LblDateDeDebut";
            this.LblDateDeDebut.Size = new System.Drawing.Size(73, 13);
            this.LblDateDeDebut.TabIndex = 1;
            this.LblDateDeDebut.Text = "date de debut";
            // 
            // GrpAbsence
            // 
            this.GrpAbsence.Controls.Add(this.DGVAbsences);
            this.GrpAbsence.Controls.Add(this.BtnSupprimer);
            this.GrpAbsence.Controls.Add(this.BtnModifier);
            this.GrpAbsence.Location = new System.Drawing.Point(155, 24);
            this.GrpAbsence.Name = "GrpAbsence";
            this.GrpAbsence.Size = new System.Drawing.Size(492, 238);
            this.GrpAbsence.TabIndex = 4;
            this.GrpAbsence.TabStop = false;
            this.GrpAbsence.Text = "absence";
            // 
            // DGVAbsences
            // 
            this.DGVAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAbsences.Location = new System.Drawing.Point(6, 20);
            this.DGVAbsences.Name = "DGVAbsences";
            this.DGVAbsences.Size = new System.Drawing.Size(460, 183);
            this.DGVAbsences.TabIndex = 3;
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
            // DtpStart
            // 
            this.DtpStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.DtpStart.Location = new System.Drawing.Point(86, 19);
            this.DtpStart.Name = "DtpStart";
            this.DtpStart.Size = new System.Drawing.Size(198, 20);
            this.DtpStart.TabIndex = 11;
            this.DtpStart.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // DtpEnd
            // 
            this.DtpEnd.CustomFormat = "";
            this.DtpEnd.Location = new System.Drawing.Point(86, 45);
            this.DtpEnd.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.DtpEnd.Name = "DtpEnd";
            this.DtpEnd.Size = new System.Drawing.Size(198, 20);
            this.DtpEnd.TabIndex = 12;
            // 
            // FormAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.GrpAjouterAbsence);
            this.Controls.Add(this.GrpAbsence);
            this.Name = "FormAbsence";
            this.Text = "FormAbsence";
            this.GrpAjouterAbsence.ResumeLayout(false);
            this.GrpAjouterAbsence.PerformLayout();
            this.GrpAbsence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAbsences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.GroupBox GrpAjouterAbsence;
        private System.Windows.Forms.Label LblMotif;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LblDatedefin;
        private System.Windows.Forms.Label LblDateDeDebut;
        private System.Windows.Forms.GroupBox GrpAbsence;
        private System.Windows.Forms.DataGridView DGVAbsences;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.ComboBox CmbMotif;
        private System.Windows.Forms.DateTimePicker DtpEnd;
        private System.Windows.Forms.DateTimePicker DtpStart;
    }
}