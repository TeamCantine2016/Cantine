using ProjetCantine.Vues;
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

        Form_GestionEleve form_GestionEleve;
        Form_VisualisationFamille form_VisuFamille;
        Form_GestionUtilisateur form_GestionUtilisateur;
        Form_ParamRepasPrix form_ParamRepasPrix;
        Form_EncodageRepas form_EncodageRepas;
        Form_HistoriqueFacture form_HistoriqueFacture;
        Form_EncodageFactures form_EncodageFactures;
        Form_RecapRepasFamilleMois form_RecapRepasFamilleMois;
        Form_GestionEtablissement form_GestionEtablissement;


        private void gestionDesÉlèvesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (form_GestionEleve == null)
            {
                form_GestionEleve = new Form_GestionEleve();
                form_GestionEleve.MdiParent = this;
                form_GestionEleve.Show();
                form_GestionEleve.WindowState = FormWindowState.Maximized;
            }
            else form_GestionEleve.Activate();

        }

              private void visualisationDesFamillesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_VisuFamille == null)
            {
                form_VisuFamille = new Form_VisualisationFamille();
                form_VisuFamille.MdiParent = this;
                form_VisuFamille.Show();
                form_VisuFamille.WindowState = FormWindowState.Maximized;
            }
            else form_VisuFamille.Activate();
        }

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

        private void paramétrageDesRepasEtPrixToolStripMenuItem_Click(object sender, EventArgs e)
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
            this.Close();
        }

        private void configurationDuMenuDeLaSemaineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void encodageRepasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void historiqueDesFacturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_HistoriqueFacture == null)
            {
                form_HistoriqueFacture = new Form_HistoriqueFacture();
                form_HistoriqueFacture.MdiParent = this;
                form_HistoriqueFacture.Show();
                form_HistoriqueFacture.WindowState = FormWindowState.Maximized;
            }
            else form_HistoriqueFacture.Activate();
        }

        private void générationDesFacturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_EncodageFactures == null)
            {
                form_EncodageFactures = new Form_EncodageFactures();
                form_EncodageFactures.MdiParent = this;
                form_EncodageFactures.Show();
                form_EncodageFactures.WindowState = FormWindowState.Maximized;
            }
            else form_EncodageFactures.Activate();
        }

        private void repasParFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_RecapRepasFamilleMois == null)
            {
                form_RecapRepasFamilleMois = new Form_RecapRepasFamilleMois();
                form_RecapRepasFamilleMois.MdiParent = this;
                form_RecapRepasFamilleMois.Show();
                form_RecapRepasFamilleMois.WindowState = FormWindowState.Maximized;
            }
            else form_RecapRepasFamilleMois.Activate();
        }

        private void gestionÉtablissementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_GestionEtablissement == null)
            {
                form_GestionEtablissement = new Form_GestionEtablissement();
                form_GestionEtablissement.MdiParent = this;
                form_GestionEtablissement.Show();
                form_GestionEtablissement.WindowState = FormWindowState.Maximized;
            }
            else form_GestionEtablissement.Activate();

        }

        private void encodageDesRepasParÉlèveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_EncodageRepas == null)
            {
                form_EncodageRepas = new Form_EncodageRepas();
                form_EncodageRepas.MdiParent = this;
                form_EncodageRepas.Show();
                form_EncodageRepas.WindowState = FormWindowState.Maximized;
            }
            else form_EncodageRepas.Activate();
        }
    }

}
