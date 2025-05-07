
namespace gestion_prof
{
    partial class etudiant
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
            this.labelNom = new System.Windows.Forms.Label();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.textNom = new System.Windows.Forms.TextBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.dataGridViewEtudiant = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(97, 62);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(61, 24);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom :";
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(286, 62);
            this.buttonRechercher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(87, 28);
            this.buttonRechercher.TabIndex = 2;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(164, 65);
            this.textNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(116, 22);
            this.textNom.TabIndex = 3;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.LightCoral;
            this.btnQuitter.Location = new System.Drawing.Point(786, 591);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(87, 28);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // dataGridViewEtudiant
            // 
            this.dataGridViewEtudiant.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridViewEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEtudiant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.prenom,
            this.email,
            this.telephone,
            this.professeur,
            this.classe});
            this.dataGridViewEtudiant.GridColor = System.Drawing.Color.YellowGreen;
            this.dataGridViewEtudiant.Location = new System.Drawing.Point(87, 147);
            this.dataGridViewEtudiant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewEtudiant.Name = "dataGridViewEtudiant";
            this.dataGridViewEtudiant.Size = new System.Drawing.Size(814, 411);
            this.dataGridViewEtudiant.TabIndex = 7;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.Width = 150;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prénom";
            this.prenom.Name = "prenom";
            this.prenom.Width = 120;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.Width = 200;
            // 
            // telephone
            // 
            this.telephone.HeaderText = "Téléphone";
            this.telephone.Name = "telephone";
            // 
            // professeur
            // 
            this.professeur.HeaderText = "Professeur";
            this.professeur.Name = "professeur";
            // 
            // classe
            // 
            this.classe.HeaderText = "Classe";
            this.classe.Name = "classe";
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.Location = new System.Drawing.Point(379, 62);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(95, 28);
            this.btnReinitialiser.TabIndex = 8;
            this.btnReinitialiser.Text = "Réinitialiser";
            this.btnReinitialiser.UseVisualStyleBackColor = true;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // etudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(989, 662);
            this.ControlBox = false;
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.dataGridViewEtudiant);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.labelNom);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "etudiant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Etudiant";
            this.Load += new System.EventHandler(this.etudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtudiant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.DataGridView dataGridViewEtudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn professeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn classe;
        private System.Windows.Forms.Button btnReinitialiser;
    }
}