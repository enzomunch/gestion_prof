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

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            MySqlConnection connexion = new MySqlConnection("database=gestion_prof; server=localhost; user id =root; mdp=");
            connexion.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT nomEtudiant, prenomEtudiant, mailEtudiant, telEtudiant, nomProf, nomClasse from etudiants INNER JOIN professeurs ON professeurs.numProf = etudiants.numProf INNER JOIN classes ON classes.numClasse = etudiants.numClasse WHERE nomEtudiant LIKE '%" + textNom.Text + "%'"
, connexion);

            MySqlDataReader recherche = cmd.ExecuteReader();

            dataGridViewEtudiant.Rows.Clear();

            if (recherche.HasRows)
            {
                while (recherche.Read())
                {
                    dataGridViewEtudiant.Rows.Add(
                        recherche[0],
                        recherche[1],
                        recherche[2],
                        recherche[3],
                        recherche[4],
                        recherche[5]);
                }
            }
            else
            {
                MessageBox.Show("Etudiant non trouvé ", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //  Toujours fermer le reader et la connexion
            recherche.Close();
            connexion.Close();
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
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
                dataGridViewEtudiant.Rows.Clear();
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
    }
}

