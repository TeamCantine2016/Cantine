using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetCantine.Models;

namespace ProjetCantine.Vues
{
    public partial class Form_EncodageFactures : Form
    {

        public Form_EncodageFactures()
        {
            InitializeComponent();
        }

        private void Form_EncodageFactures_Load(object sender, EventArgs e)
        {
            // requête du dataset pour remplir le datagridview
            this.tA_Listes_Personnes_query.Fill_Tuteurs(this.db_cantineDataSet.TA_Listes_Personnes);
            // pour adapter la largeur de colonnes
            dGdVw_DetailFamille.AutoResizeColumns();
            // pour élargir la dernière colonne horizontalement pour ne pas avoir une zone grise
            dGdVw_DetailFamille.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void tblhistoriquefactureBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dGdVw_DetailFamille_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btApercu_Click(object sender, EventArgs e)
        {
            ApercuFacture facture = new ApercuFacture();
            String msgRetour = facture.facture();

            // teste si le fichier a bien été creer           
            if (msgRetour.LastIndexOf(".pdf") == -1)
            {
                MessageBox.Show(msgRetour);
            }
            else
            {
                MessageBox.Show("La création à bien été éffectué à l'adresse: " + msgRetour);
                facture.affichageFacture(msgRetour);
            }
        }
    }
}
