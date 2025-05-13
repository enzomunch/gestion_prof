using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace gestion_prof
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
       
            // test des champs remplis
            if (txtPrenom.Text != "" && txtNom.Text != "" && cboClasse.Text != "" && cboProf.Text != "")
            {               
                //connexion a la table
                MySqlConnection connexion = new MySqlConnection("database=gestion_prof; server=localhost; user id =root; mdp=");
                try
                {
                    MessageBox.Show("lancement de la requete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //ouverture base 
                    connexion.Open();

                    //affectation des variables
                    string nom = txtNom.Text;
                    string prenom = txtPrenom.Text;
                    string email = txtMail.Text;
                    string tel = txtTel.Text;
                    string classe = cboClasse.SelectedValue.ToString();
                    string prof = cboProf.SelectedValue.ToString();

                    //mise en forme de la requete
                    MySqlCommand insertion = new MySqlCommand("INSERT into etudiants values (NULL, '" + nom + "','" + prenom + "','" + email + "','" + tel + "','" + prof + "','" + classe + "')", connexion);
                    //execution de la requete 
                    insertion.ExecuteNonQuery();
                    //message de reussite
                    MessageBox.Show("Etudiant ajouter avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //fermeture de la base 
                    connexion.Close();
                    //mise a blanc des champs
                    txtNom.Clear();
                    txtPrenom.Clear();
                    txtMail.Clear();
                    txtTel.Clear();
                }
                catch
                {
                    MessageBox.Show("Connexion à la base échoué !", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
      
            }
            else
            {
                MessageBox.Show("Vous devez remplir tout les champs obligatoires !", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void admin_Load(object sender, EventArgs e)
        {
            //remplir professeur           
            MySqlConnection connexionProf = new MySqlConnection("database=gestion_prof;server=localhost;user id=root;pwd=");       
            try
            {
                //liste agent
                connexionProf.Open();
                MySqlCommand cmdProf = new MySqlCommand("select * from professeurs", connexionProf);
                //execution de la requete
                MySqlDataReader listProf = cmdProf.ExecuteReader();
                //
                //mise en table 
                DataTable tabProf = new DataTable();
                //remplir combo agents 
                tabProf.Load(listProf);
                //affectation des données a la liste deroulante
                cboProf.DataSource = tabProf;
                //pour le traitement
                cboProf.ValueMember = "numProf";
                //pour l'affichage
                cboProf.DisplayMember = "nomProf";
                connexionProf.Close();
            }
            catch
            {
                //affichage du message de non connexion
                MessageBox.Show("connexion a la base echoué", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //remplir classe          
            MySqlConnection connexionClasse = new MySqlConnection("database=gestion_prof;server=localhost;user id=root;pwd=");
            try
            {
                //liste agent
                connexionClasse.Open();
                MySqlCommand cmdClasse = new MySqlCommand("select * from classes", connexionClasse);
                //execution de la requete
                MySqlDataReader listClasse = cmdClasse.ExecuteReader();
                //
                //mise en table 
                DataTable tabClasse = new DataTable();
                //remplir combo agents 
                tabClasse.Load(listClasse);
                //affectation des données a la liste deroulante
                cboClasse.DataSource = tabClasse;
                //pour le traitement
                cboClasse.ValueMember = "numClasse";
                //pour l'affichage
                cboClasse.DisplayMember = "nomClasse";
                connexionClasse.Close();
            }
            catch
            {
                //affichage du message de non connexion
                MessageBox.Show("connexion a la base echoué", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "" && txtPrenom.Text != "" )
            {
                btnEnregistrer.Visible = false;
                btnModifier.Visible = true;
                btnReinitialiser.Visible = true;
                btnSupprimer.Visible = true;


                MySqlConnection connexion = new MySqlConnection("database=gestion_prof; server=localhost; user id =root; mdp=");
                connexion.Open();
                //memorisation de la requete de recherche
                MySqlCommand cmd = new MySqlCommand("SELECT nomEtudiant, prenomEtudiant, mailEtudiant, telEtudiant, nomProf, nomClasse from etudiants INNER JOIN professeurs ON professeurs.numProf = etudiants.numProf INNER JOIN classes ON classes.numClasse = etudiants.numClasse WHERE nomEtudiant LIKE '%" + txtNom.Text + "%' AND prenomEtudiant LIKE '%" + txtPrenom.Text + "%'", connexion);
                // execution de la requete
                MySqlDataReader recherche = cmd.ExecuteReader();

                //test si il a trouver l'étudiant
                if (recherche.HasRows)
                {
                    //lecture de l'enregistrement 
                    recherche.Read();
                    //
                    // affectation des champs dans les zones textes
                    txtNom.Text = recherche.GetValue(0).ToString();
                    txtPrenom.Text = recherche.GetValue(1).ToString();
                    txtMail.Text = recherche.GetValue(2).ToString();
                    txtTel.Text = recherche.GetValue(3).ToString();
                    cboProf.Text = recherche.GetValue(4).ToString();
                    cboClasse.Text = recherche.GetValue(5).ToString();

                    //femeture
                    connexion.Close();


                }
                else
                {
                    MessageBox.Show("Etudiant non trouvé ", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNom.Clear();
                    txtPrenom.Clear();
                    txtMail.Clear();
                    txtTel.Clear();
                    //fermeture
                    connexion.Close();
                }


            }
            else
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            btnModifier.Visible = false;
            btnSupprimer.Visible = false;
            btnReinitialiser.Visible = false;
            btnEnregistrer.Visible = true;
            txtNom.Clear();
            txtPrenom.Clear();
            txtMail.Clear();
            txtTel.Clear();
        }

        private void labNom_Click(object sender, EventArgs e)
        {

        }
    }
}
