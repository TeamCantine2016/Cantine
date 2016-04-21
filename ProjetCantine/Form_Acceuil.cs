using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCantine
{
    public partial class Form_Acceuil : Form
    {
        public Form_Acceuil()
        {
            InitializeComponent();
        }
        Form_GestionUtilisateur form_GestionUtilisateur;
        Form_ParamRepasPrix form_ParamRepasPrix;
        //Form_Connexion form_Connexion;
        

        private void gestionDesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_GestionUtilisateur == null)
            {
                form_GestionUtilisateur = new Form_GestionUtilisateur();
                form_GestionUtilisateur.MdiParent = this;
                form_GestionUtilisateur.Show();
                form_GestionUtilisateur.WindowState = FormWindowState.Maximized;
            }
            else form_GestionUtilisateur.Activate();

        }

        private void paramétrageDesPrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_ParamRepasPrix == null)
            {
                form_ParamRepasPrix = new Form_ParamRepasPrix();
                form_ParamRepasPrix.MdiParent = this;
                form_ParamRepasPrix.Show();
                form_ParamRepasPrix.WindowState = FormWindowState.Maximized;
            }
            else form_ParamRepasPrix.Activate();
        }

        private void déconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
