﻿using ProjetCantine.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCantine.Vues
{
    public partial class Form_HistoriqueFacture : Form
    {
        public Form_HistoriqueFacture()
        {
            InitializeComponent();
        }

        private void Form_HistoriqueFacture_Load(object sender, EventArgs e)
        {
            Ctrl_HistoriqueFacture controle = new Ctrl_HistoriqueFacture();
            controle.afficheHistorique(ref dataGridView_Historique);
        }

        private void button_visualisation_Click(object sender, EventArgs e)
        {

            int id = dataGridView_Historique.CurrentRow.Index;
            string path = dataGridView_Historique.CurrentRow.Cells["Répertoire"].Value.ToString();                

            ApercuFacture facture = new ApercuFacture();
            facture.affichageFacture(path);

        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            // permetre a l'utilisateure de choisir un fichier et de mettre a jour son emplacement dans la db
            OpenFileDialog openFileDialog_fichier = new OpenFileDialog();
            openFileDialog_fichier.InitialDirectory = "c:\\";
            openFileDialog_fichier.Filter = "TOUS (*.*)| *.*| PDF (*.pdf)|*.pdf)";


            if (openFileDialog_fichier.ShowDialog() == DialogResult.OK)
            {
                int id = Convert.ToInt16(dataGridView_Historique.CurrentRow.Cells["IdFacture"].Value.ToString());

                Ctrl_HistoriqueFacture controle = new Ctrl_HistoriqueFacture();
                String donnée = controle.constrRequete(openFileDialog_fichier.FileName);

                Ctrl_HistoriqueFacture controle1 = new Ctrl_HistoriqueFacture();
                controle1.update(donnée, "tbl_historique_facture", id);

                Ctrl_HistoriqueFacture controleAffiche = new Ctrl_HistoriqueFacture();
                controleAffiche.afficheHistorique(ref dataGridView_Historique);

            }
        }
    }
}
