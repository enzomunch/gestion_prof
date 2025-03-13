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
                //conexion a la base de donnée
                MySqlConnection connexion_prof= new MySqlConnection("Server=localhost;Database=gestion_prof;User Id=root;Password=;");
                connexion_prof.Open();
                this.Hide();
                frm_central.ShowDialog();
                connexion_prof.Close();
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
