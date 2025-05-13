
namespace gestion_prof
{
    partial class stage
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
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.dataGridViewStage = new System.Windows.Forms.DataGridView();
            this.nomEtudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomEtudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomTuteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStageDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStageFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateDebut.Location = new System.Drawing.Point(64, 38);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(0, 24);
            this.labelDateDebut.TabIndex = 0;
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFin.Location = new System.Drawing.Point(87, 78);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(0, 24);
            this.labelDateFin.TabIndex = 1;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.LightCoral;
            this.btnQuitter.Location = new System.Drawing.Point(665, 409);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(87, 28);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // dataGridViewStage
            // 
            this.dataGridViewStage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomEtudiant,
            this.prenomEtudiant,
            this.nomTuteur,
            this.dateStageDebut,
            this.dateStageFin});
            this.dataGridViewStage.Location = new System.Drawing.Point(70, 49);
            this.dataGridViewStage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewStage.Name = "dataGridViewStage";
            this.dataGridViewStage.Size = new System.Drawing.Size(715, 328);
            this.dataGridViewStage.TabIndex = 7;
            // 
            // nomEtudiant
            // 
            this.nomEtudiant.HeaderText = "Nom Etudiant";
            this.nomEtudiant.Name = "nomEtudiant";
            this.nomEtudiant.Width = 150;
            // 
            // prenomEtudiant
            // 
            this.prenomEtudiant.HeaderText = "Prénom Etudiant";
            this.prenomEtudiant.Name = "prenomEtudiant";
            this.prenomEtudiant.Width = 130;
            // 
            // nomTuteur
            // 
            this.nomTuteur.HeaderText = "Nom Tuteur";
            this.nomTuteur.Name = "nomTuteur";
            this.nomTuteur.Width = 150;
            // 
            // dateStageDebut
            // 
            this.dateStageDebut.HeaderText = "Date de début";
            this.dateStageDebut.MaxInputLength = 10;
            this.dateStageDebut.Name = "dateStageDebut";
            this.dateStageDebut.Width = 120;
            // 
            // dateStageFin
            // 
            this.dateStageFin.HeaderText = "Date Fin";
            this.dateStageFin.Name = "dateStageFin";
            this.dateStageFin.Width = 120;
            // 
            // stage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(862, 478);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewStage);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.labelDateFin);
            this.Controls.Add(this.labelDateDebut);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "stage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stage";
            this.Load += new System.EventHandler(this.stage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDateDebut;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.DataGridView dataGridViewStage;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEtudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomEtudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomTuteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStageDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStageFin;
    }
}