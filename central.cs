﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_prof
{
    public partial class central : Form
    {
        Form frm_etudiant = new etudiant();
        Form frm_suivi_stage = new stage();
        Form frm_document = new documents();
        Form frm_admin = new admin();
        public central()
        {
            InitializeComponent();
        }

        private void etudiantSuperviséToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_etudiant.ShowDialog();
        }

        private void suiviDeStageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_suivi_stage.ShowDialog();
        }

        private void documentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_document.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            frm_admin.ShowDialog();
        }

        private void central_Load(object sender, EventArgs e)
        {
            if (Globals.keyProf == 13)
            {
                adminToolStripMenuItem.Visible = true;
            }
        }
    }
}
