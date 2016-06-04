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
        public Form_Acceuil(string nom, string prenom, string droits, Form_Connexion form)
        {
            InitializeComponent();
            label_Nom.Text = nom + " " + prenom;
            label_Rang.Text = droits;
            this.form_connexion = form;

            if (label_Rang.Text != "admin")
            {
                gestionDesUtilisateursToolStripMenuItem.Visible = false; // le seul menu non accesible aux super_user
                if (label_Rang.Text == "user")
                {
                    administrationToolStripMenuItem.Visible = false;

                    gestionÉtablissementToolStripMenuItem.Visible = false;
                    gestionDesÉlèvesToolStripMenuItem.Visible = false;
                    visualisationDesFamillesToolStripMenuItem.Visible = false;

                    paramétrageDesRepasEtPrixToolStripMenuItem.Visible = false;
                    // encodageDesRepasParÉlèveToolStripMenuItem.Visible = false; TOUS

                    facturationToolStripMenuItem.Visible = false;
                    //générationDesFacturesToolStripMenuItem.Visible = false;
                    //historiqueDesFacturesToolStripMenuItem.Visible = false;

                    //toolStripMenuItem2.Visible = false; Tous


                }

            }

        }
        //Form_Acceuil form_acceuil;
        bool flag = false;
        Form_Connexion form_connexion;
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

        private void Form_Acceuil_FormClosing(object sender, FormClosingEventArgs e) // confirmation fermeture avec la croix
        {
            if(flag == false )
            {

          //  DialogResult dialog = MessageBox.Show("Voulez-vous vraiment fermer l'application / vous déconnecter ?", "Fermeture session", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No);
                if (MessageBox.Show("Voulez-vous vraiment fermer l'application ", "Fermeture application", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    //Application.Exit();
                    e.Cancel = true;
                }
            }
        }

        private void déconnecterToolStripMenuItem1_Click(object sender, EventArgs e) // déconnecter
        {
            flag = true;
            if (MessageBox.Show("Voulez-vous vraiment vous déconnecter ?", "Fermeture session", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                form_connexion.Show();
            }
            flag = false;     
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e) //bouton quitter
        {
            Application.Exit();
        }
    }

}
