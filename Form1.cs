using System.Windows.Forms;

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
            this.Hide();
            frm_central.ShowDialog();
            
        }
    }
}
