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
            this.GrpAjouterPersonnel = new System.Windows.Forms.GroupBox();
            this.LblMotif = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxmotif = new System.Windows.Forms.TextBox();
            this.TxtBoxSurname = new System.Windows.Forms.TextBox();
            this.LblDatedefin = new System.Windows.Forms.Label();
            this.LblDateDeDebut = new System.Windows.Forms.Label();
            this.GrpAbscence = new System.Windows.Forms.GroupBox();
            this.DGVPersonnel = new System.Windows.Forms.DataGridView();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.GrpAjouterPersonnel.SuspendLayout();
            this.GrpAbscence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersonnel)).BeginInit();
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
            // 
            // GrpAjouterPersonnel
            // 
            this.GrpAjouterPersonnel.Controls.Add(this.LblMotif);
            this.GrpAjouterPersonnel.Controls.Add(this.BtnCancel);
            this.GrpAjouterPersonnel.Controls.Add(this.BtnSave);
            this.GrpAjouterPersonnel.Controls.Add(this.TxtBoxName);
            this.GrpAjouterPersonnel.Controls.Add(this.TextBoxmotif);
            this.GrpAjouterPersonnel.Controls.Add(this.TxtBoxSurname);
            this.GrpAjouterPersonnel.Controls.Add(this.LblDatedefin);
            this.GrpAjouterPersonnel.Controls.Add(this.LblDateDeDebut);
            this.GrpAjouterPersonnel.Location = new System.Drawing.Point(155, 269);
            this.GrpAjouterPersonnel.Name = "GrpAjouterPersonnel";
            this.GrpAjouterPersonnel.Size = new System.Drawing.Size(492, 129);
            this.GrpAjouterPersonnel.TabIndex = 5;
            this.GrpAjouterPersonnel.TabStop = false;
            this.GrpAjouterPersonnel.Text = "Ajouter un personnel";
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
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(6, 98);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(116, 25);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "engegistrer";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(86, 20);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(155, 20);
            this.TxtBoxName.TabIndex = 8;
            // 
            // TextBoxmotif
            // 
            this.TextBoxmotif.Location = new System.Drawing.Point(86, 72);
            this.TextBoxmotif.Name = "TextBoxmotif";
            this.TextBoxmotif.Size = new System.Drawing.Size(166, 20);
            this.TextBoxmotif.TabIndex = 6;
            // 
            // TxtBoxSurname
            // 
            this.TxtBoxSurname.Location = new System.Drawing.Point(86, 46);
            this.TxtBoxSurname.Name = "TxtBoxSurname";
            this.TxtBoxSurname.Size = new System.Drawing.Size(155, 20);
            this.TxtBoxSurname.TabIndex = 5;
            // 
            // LblDatedefin
            // 
            this.LblDatedefin.AutoSize = true;
            this.LblDatedefin.Location = new System.Drawing.Point(7, 44);
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
            // GrpAbscence
            // 
            this.GrpAbscence.Controls.Add(this.DGVPersonnel);
            this.GrpAbscence.Controls.Add(this.BtnSupprimer);
            this.GrpAbscence.Controls.Add(this.BtnModifier);
            this.GrpAbscence.Location = new System.Drawing.Point(155, 24);
            this.GrpAbscence.Name = "GrpAbscence";
            this.GrpAbscence.Size = new System.Drawing.Size(492, 238);
            this.GrpAbscence.TabIndex = 4;
            this.GrpAbscence.TabStop = false;
            this.GrpAbscence.Text = "absence";
            // 
            // DGVPersonnel
            // 
            this.DGVPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPersonnel.Location = new System.Drawing.Point(6, 20);
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
            // 
            // BtnModifier
            // 
            this.BtnModifier.Location = new System.Drawing.Point(6, 209);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(116, 23);
            this.BtnModifier.TabIndex = 0;
            this.BtnModifier.Text = "modifier";
            this.BtnModifier.UseVisualStyleBackColor = true;
            // 
            // FormAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.GrpAjouterPersonnel);
            this.Controls.Add(this.GrpAbscence);
            this.Name = "FormAbsence";
            this.Text = "FormAbsence";
            this.GrpAjouterPersonnel.ResumeLayout(false);
            this.GrpAjouterPersonnel.PerformLayout();
            this.GrpAbscence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersonnel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.GroupBox GrpAjouterPersonnel;
        private System.Windows.Forms.Label LblMotif;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtBoxName;
        private System.Windows.Forms.TextBox TextBoxmotif;
        private System.Windows.Forms.TextBox TxtBoxSurname;
        private System.Windows.Forms.Label LblDatedefin;
        private System.Windows.Forms.Label LblDateDeDebut;
        private System.Windows.Forms.GroupBox GrpAbscence;
        private System.Windows.Forms.DataGridView DGVPersonnel;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnModifier;
    }
}