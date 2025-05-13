
namespace gestion_prof
{
    partial class admin
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
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.labNom = new System.Windows.Forms.Label();
            this.labPrenom = new System.Windows.Forms.Label();
            this.labMail = new System.Windows.Forms.Label();
            this.labTel = new System.Windows.Forms.Label();
            this.labProf = new System.Windows.Forms.Label();
            this.labClasse = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.cboClasse = new System.Windows.Forms.ComboBox();
            this.cboProf = new System.Windows.Forms.ComboBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(636, 51);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(98, 39);
            this.btnEnregistrer.TabIndex = 0;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(636, 236);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(98, 39);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Visible = false;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(636, 112);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(98, 39);
            this.btnRechercher.TabIndex = 2;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(636, 304);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(98, 39);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Visible = false;
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.Location = new System.Drawing.Point(636, 172);
            this.btnReinitialiser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(98, 39);
            this.btnReinitialiser.TabIndex = 4;
            this.btnReinitialiser.Text = "Reinitialiser";
            this.btnReinitialiser.UseVisualStyleBackColor = true;
            this.btnReinitialiser.Visible = false;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // labNom
            // 
            this.labNom.AutoSize = true;
            this.labNom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNom.Location = new System.Drawing.Point(84, 65);
            this.labNom.Name = "labNom";
            this.labNom.Size = new System.Drawing.Size(54, 16);
            this.labNom.TabIndex = 5;
            this.labNom.Text = "Nom : *";
            this.labNom.Click += new System.EventHandler(this.labNom_Click);
            // 
            // labPrenom
            // 
            this.labPrenom.AutoSize = true;
            this.labPrenom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPrenom.Location = new System.Drawing.Point(63, 112);
            this.labPrenom.Name = "labPrenom";
            this.labPrenom.Size = new System.Drawing.Size(75, 16);
            this.labPrenom.TabIndex = 6;
            this.labPrenom.Text = "Prénom : *";
            // 
            // labMail
            // 
            this.labMail.AutoSize = true;
            this.labMail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMail.Location = new System.Drawing.Point(81, 162);
            this.labMail.Name = "labMail";
            this.labMail.Size = new System.Drawing.Size(56, 16);
            this.labMail.TabIndex = 7;
            this.labMail.Text = "E-mail :";
            // 
            // labTel
            // 
            this.labTel.AutoSize = true;
            this.labTel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTel.Location = new System.Drawing.Point(54, 213);
            this.labTel.Name = "labTel";
            this.labTel.Size = new System.Drawing.Size(84, 16);
            this.labTel.TabIndex = 8;
            this.labTel.Text = "Téléphone :";
            // 
            // labProf
            // 
            this.labProf.AutoSize = true;
            this.labProf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProf.Location = new System.Drawing.Point(55, 327);
            this.labProf.Name = "labProf";
            this.labProf.Size = new System.Drawing.Size(83, 16);
            this.labProf.TabIndex = 9;
            this.labProf.Text = "Professeur :";
            // 
            // labClasse
            // 
            this.labClasse.AutoSize = true;
            this.labClasse.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labClasse.Location = new System.Drawing.Point(80, 269);
            this.labClasse.Name = "labClasse";
            this.labClasse.Size = new System.Drawing.Size(57, 16);
            this.labClasse.TabIndex = 10;
            this.labClasse.Text = "Classe :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(144, 62);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(185, 22);
            this.txtNom.TabIndex = 11;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(144, 109);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(161, 22);
            this.txtPrenom.TabIndex = 12;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(144, 159);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(247, 22);
            this.txtMail.TabIndex = 13;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(144, 210);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(127, 22);
            this.txtTel.TabIndex = 14;
            // 
            // cboClasse
            // 
            this.cboClasse.FormattingEnabled = true;
            this.cboClasse.Location = new System.Drawing.Point(144, 266);
            this.cboClasse.Name = "cboClasse";
            this.cboClasse.Size = new System.Drawing.Size(121, 24);
            this.cboClasse.TabIndex = 15;
            // 
            // cboProf
            // 
            this.cboProf.FormattingEnabled = true;
            this.cboProf.Location = new System.Drawing.Point(144, 324);
            this.cboProf.Name = "cboProf";
            this.cboProf.Size = new System.Drawing.Size(185, 24);
            this.cboProf.TabIndex = 16;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(384, 414);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(98, 39);
            this.btnQuitter.TabIndex = 17;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 14);
            this.label1.TabIndex = 18;
            this.label1.Text = "* = champs obligatoires";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.cboProf);
            this.Controls.Add(this.cboClasse);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.labClasse);
            this.Controls.Add(this.labProf);
            this.Controls.Add(this.labTel);
            this.Controls.Add(this.labMail);
            this.Controls.Add(this.labPrenom);
            this.Controls.Add(this.labNom);
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnEnregistrer);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administrateur";
            this.Load += new System.EventHandler(this.admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.Label labNom;
        private System.Windows.Forms.Label labPrenom;
        private System.Windows.Forms.Label labMail;
        private System.Windows.Forms.Label labTel;
        private System.Windows.Forms.Label labProf;
        private System.Windows.Forms.Label labClasse;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.ComboBox cboClasse;
        private System.Windows.Forms.ComboBox cboProf;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label label1;
    }
}