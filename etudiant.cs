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
    public partial class etudiant : Form
    {
        public etudiant()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void etudiant_Load(object sender, EventArgs e)
        {
            MySqlConnection connexion_etudiants = new MySqlConnection("database = gestion_prof; server = localhost; user id = root; mdp=");
            try
            {
                // Requête pour récupérer la liste des étudiants
                connexion_etudiants.Open();
                MySqlCommand cmd_etudiants = new MySqlCommand("SELECT nomEtudiant, prenomEtudiant, mailEtudiant, telEtudiant, nomProf, nomClasse from etudiants INNER JOIN professeurs ON professeurs.numProf = etudiants.numProf INNER JOIN classes ON classes.numClasse = etudiants.numClasse", connexion_etudiants);
                // Execution de la requete 
                MySqlDataReader grille_etudiants = cmd_etudiants.ExecuteReader();
                //
                while (grille_etudiants.Read())
                {
                    dataGridViewEtudiant.Rows.Add(
                        grille_etudiants[0],
                        grille_etudiants[1],
                        grille_etudiants[2],
                        grille_etudiants[3],
                        grille_etudiants[4],
                        grille_etudiants[5]);
                }
            }
            catch
            {
                MessageBox.Show("Connexion à la base client echoué.", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewEtudiant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

