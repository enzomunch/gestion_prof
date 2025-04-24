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
            MySqlConnection connexion_clients = new MySqlConnection("database = gestion_prof; server = localhost; user id = root; mdp=");
            MySqlConnection conn_clients = connexion_clients;
            try
            {

                //affichage des infos clients 
                conn_clients.Open();
                MySqlCommand cmd_clients = new MySqlCommand("select * from etudiants ", conn_clients);
                //execution de la requete 
                MySqlDataReader grille_clients = cmd_clients.ExecuteReader();
                //
                while (grille_clients.Read())
                {
                    dataGridViewEtudiant.Rows.Add(grille_clients[1], grille_clients[2], grille_clients[3], grille_clients[4], grille_clients[5], grille_clients[6]);
                }
            }
            catch
            {
                MessageBox.Show("connexion a la base client echoué ", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewEtudiant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

