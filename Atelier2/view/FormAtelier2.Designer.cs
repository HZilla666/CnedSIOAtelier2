namespace Atelier2.view
{
    partial class FormAtelier2
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.TxtPwd = new System.Windows.Forms.TextBox();
            this.BtnConection = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(12, 12);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(182, 20);
            this.TxtLogin.TabIndex = 0;
            this.TxtLogin.Text = "identifiant";
            // 
            // TxtPwd
            // 
            this.TxtPwd.Location = new System.Drawing.Point(12, 38);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.Size = new System.Drawing.Size(182, 20);
            this.TxtPwd.TabIndex = 1;
            this.TxtPwd.Text = "mot de passe";
            // 
            // BtnConection
            // 
            this.BtnConection.Location = new System.Drawing.Point(243, 21);
            this.BtnConection.Name = "BtnConection";
            this.BtnConection.Size = new System.Drawing.Size(83, 23);
            this.BtnConection.TabIndex = 2;
            this.BtnConection.Text = "se connecter";
            this.BtnConection.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 95);
            this.listBox1.TabIndex = 3;
            // 
            // FormAtelier2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 541);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnConection);
            this.Controls.Add(this.TxtPwd);
            this.Controls.Add(this.TxtLogin);
            this.Name = "FormAtelier2";
            this.Text = "FormAtelier2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.TextBox TxtPwd;
        private System.Windows.Forms.Button BtnConection;
        private System.Windows.Forms.ListBox listBox1;
    }
}

