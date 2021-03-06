﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetCantine.Controller;

namespace ProjetCantine
{
    public partial class Form_VisualisationFamille : Form
    {
        public Form_VisualisationFamille()
        {
            InitializeComponent();           
        }

        private void Form_VisualisationFamille_Load(object sender, EventArgs e)
        {
            // création de l'objet de contrôle pour comuniquer avec le contrôleur
            Ctrl_VisualisationFamille controle = new Ctrl_VisualisationFamille();
            // appelle méthode qui affiche les tuteurs
            controle.afficheListeTuteurs(ref dataGridView_Famille, ref textBox_NomRech, ref textBox_TéléphoneRech);
        }
               
        private void dataGridView_Famille_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            // création de l'objet de contrôle pour comuniquer avec le contrôleur
            Ctrl_VisualisationFamille controle = new Ctrl_VisualisationFamille();

            //Affichage des données contenues dans la dataGridView_Famille dans les textbox en fonction du choix de la ligne que l'utilisateur aura selectionné
            int id = dataGridView_Famille.CurrentRow.Index;
            DataGridViewRow ligne = dataGridView_Famille.Rows[id];
            textBox_Nom.Text = ligne.Cells[1].Value.ToString();
            textBox_Téléphone.Text = ligne.Cells[2].Value.ToString();
            textBox_Adresse.Text = ligne.Cells[3].Value.ToString() + ", " + ligne.Cells[4].Value.ToString() + ", " + ligne.Cells[6].Value.ToString().Substring(0, 1) + "-" + ligne.Cells[5].Value.ToString();
            textBox_Email.Text = ligne.Cells[7].Value.ToString();

            // Partie pour l'affichage des enfants en fonction de la ligne selectionné dans la dataGridView_Famille
            int codeClient = Convert.ToInt16(ligne.Cells[0].Value.ToString());

            // appelle méthode qui affiche les enfants de la famille et renvoie le nombre d'enfants dans la textbox concernée
            textBox_nbEnfant.Text = controle.afficheListeEnfantSelonSelection(ref dataGridView_Membre, codeClient);

        }
               
        private void button_Reset_Click(object sender, EventArgs e) // les deux boutons reset sont directement orientés vers cette fonction
        {
            string type = ((Button)sender).Tag.ToString();
            switch (type)
            {
                case "nom":
                    textBox_NomRech.Text = "";
                    break;
                case "tel":
                    textBox_TéléphoneRech.Text = "";
                    break;
                default:
                    break;
            }
        }
    }
}
