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
                //recuperation de tout les champs de la table agents avec comme restriction le nom de l'agent saisie
                MySqlCommand cmd = new MySqlCommand("select * from connexion where login='" + LOG + "' AND mdp ='" + PASS + "'", connexion_prof);
                //execution de la requete  
                MySqlDataReader recherche_agent = cmd.ExecuteReader();
                //
                //si l'agent est trouver 
                if (recherche_agent.HasRows)
                {
                    this.Hide();
                    frm_central.ShowDialog();
                    connexion_prof.Close();
                }
                else
                {
                    MessageBox.Show("Identifiant ou mot de passe invalide !","Attention !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("connexion a la base echouer");
            }
            
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            
        }
    }
}
