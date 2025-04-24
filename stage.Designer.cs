
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date de Debut :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date de Fin :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(210, 81);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 22);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 60);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "rechercher";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.LightCoral;
            this.btnQuitter.Location = new System.Drawing.Point(691, 472);
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
            this.dataGridViewStage.Location = new System.Drawing.Point(78, 166);
            this.dataGridViewStage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewStage.Name = "dataGridViewStage";
            this.dataGridViewStage.Size = new System.Drawing.Size(715, 268);
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
            this.ClientSize = new System.Drawing.Size(869, 554);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewStage);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "stage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "stage";
            this.Load += new System.EventHandler(this.stage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.DataGridView dataGridViewStage;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEtudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomEtudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomTuteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStageDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStageFin;
    }
}