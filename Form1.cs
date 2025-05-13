using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace gestion_prof
{
   
    public partial class Form1 : Form
    {
        Form frm_central = new central();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnQuitter_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnValider_Click(object sender, System.EventArgs e)
        {
            try
            {
                //declaration des variables 
                string LOG = txtId.Text;
                string PASS = txtMdp.Text;

                //conexion a la base de donnée
                MySqlConnection connexion_prof= new MySqlConnection("Server=localhost;Database=gestion_prof;User Id=root;Password=;");
                connexion_prof.Open();

                //recuperation le numéro du prof qui se connecte
                MySqlCommand cmd = new MySqlCommand("select numProf from connexion where login='" + LOG + "' AND mdp ='" + PASS + "'", connexion_prof);
                // Exécution de la requête
                MySqlDataReader reader = cmd.ExecuteReader();

                Globals.keyProf = -1; // Valeur par défaut si non trouvé

                if (reader.Read()) // S'il y a un résultat
                {
                    Globals.keyProf = reader.GetInt32(0); // Récupération du numProf
                    this.Hide();
                    frm_central.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Identifiant ou mot de passe invalide !", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                reader.Close();
                connexion_prof.Close();
            }
            catch
            {
                MessageBox.Show("Connexion à la base échouée");
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            txtMdp.UseSystemPasswordChar = true;
        }

        private void chkAffMdp_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkAffMdp.Checked)
            {
                txtMdp.UseSystemPasswordChar = false;
            }
            else
            {
                txtMdp.UseSystemPasswordChar = true;
            }
        }
    }
}
