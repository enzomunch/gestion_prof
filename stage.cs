using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gestion_prof
{
    public partial class stage : Form
    {
        public stage()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void stage_Load(object sender, EventArgs e)
        {
            MySqlConnection connexion_stages = new MySqlConnection("database = gestion_prof; server = localhost; user id = root; mdp=");
            try
            {
                // Requête pour récupérer la liste des stages
                connexion_stages.Open();
                MySqlCommand cmd_stages = new MySqlCommand("SELECT nomEtudiant,prenomEtudiant,nomTuteur,dateStageDebut,dateStageFin FROM etudiants INNER JOIN stages ON stages.numEtudiant = etudiants.numEtudiant INNER JOIN tuteurs ON stages.numTuteur = tuteurs.numTuteur", connexion_stages);
                // Execution de la requete 
                MySqlDataReader grille_stages = cmd_stages.ExecuteReader();
                //
                while (grille_stages.Read())
                {
                    dataGridViewStage.Rows.Add(
                        grille_stages[0],
                        grille_stages[1],
                        grille_stages[2],
                        grille_stages[3],
                        grille_stages[4]);
                }
            }
            catch
            {
                MessageBox.Show("Connexion à la base client echoué.", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
