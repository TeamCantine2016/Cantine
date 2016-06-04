using ProjetCantine.Controller;
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

        string typeEnvoie = "Tous";
        string typePayement = "Tous";

        private void Form_HistoriqueFacture_Load(object sender, EventArgs e)
        {
            // initialisation
            Ctrl_HistoriqueFacture controle = new Ctrl_HistoriqueFacture();
            controle.afficheHistorique(ref dataGridView_Historique, typeEnvoie, typePayement, dateTimePicker_debut.Value.ToString("yyyyMMdd"), dateTimePicker_fin.Value.ToString("yyyyMMdd"), checkBox_AfficherDate.Checked, textBox_Nom.Text);
            // si il n'y a rien dans la dtg on désative les boutons
            if (dataGridView_Historique.Rows.Count == 0)
            {
                button_visualisation.Enabled = false;
                button_modifier.Enabled = false;
            }
            // par défaut on utilise pas les dates
            label_dateGénération.Enabled = false;
            label_début.Enabled = false;
            label_fin.Enabled = false;
            label_dateDeFin.Enabled = false;
            dateTimePicker_debut.Enabled = false;
            dateTimePicker_fin.Enabled = false;
        }

        private void button_visualisation_Click(object sender, EventArgs e)
        {
            //récuperer l'id de la facture dans la dtgv
            int id = Convert.ToInt16(dataGridView_Historique.CurrentRow.Cells["IdFacture"].Value.ToString());
            //rechercher le chemin de la facture dans la db en fct de l'id        
            Ctrl_HistoriqueFacture controle = new Ctrl_HistoriqueFacture();
            String path = controle.pathfacture(id);
            //demander d'afficher le fichier en fct du chemin renseigner
            ApercuFacture facture = new ApercuFacture();
            facture.affichageFacture(path, false);

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

                Ctrl_HistoriqueFacture controleAffichage = new Ctrl_HistoriqueFacture();
                controleAffichage.afficheHistorique(ref dataGridView_Historique, typeEnvoie, typePayement, dateTimePicker_debut.Value.ToString("yyyyMMdd"), dateTimePicker_fin.Value.ToString("yyyyMMdd"), checkBox_AfficherDate.Checked, textBox_Nom.Text);

            }
        }
        

        private void radioButto_Envoyer_CheckedChanged(object senderEnvoyer, EventArgs e)
        {
            // les événements des radiobutton sont liés donc avec le tag , on détermine lequel à été valider
            // la variable typeEnvoie permet d'initialisé la variable global si d'autre événement sont lancé
            typeEnvoie = ((RadioButton)senderEnvoyer).Tag.ToString();
            // affiche en fct de ce qui à été choisi
            Ctrl_HistoriqueFacture controle = new Ctrl_HistoriqueFacture();
            controle.afficheHistorique(ref dataGridView_Historique, typeEnvoie, typePayement, dateTimePicker_debut.Value.ToString("yyyyMMdd"), dateTimePicker_fin.Value.ToString("yyyyMMdd"), checkBox_AfficherDate.Checked, textBox_Nom.Text);
        }

        private void radioButton_payer_CheckedChanged(object senderPayer, EventArgs e)
        {
            // les événements des radiobutton sont liés donc avec le tag , on détermine lequel à été valider
            // la variable typePayement permet d'initialisé la variable global si d'autre événement sont lancé
            typePayement = ((RadioButton)senderPayer).Tag.ToString();
            // affiche en fct de ce qui à été choisi
            Ctrl_HistoriqueFacture controle = new Ctrl_HistoriqueFacture();
            controle.afficheHistorique(ref dataGridView_Historique, typeEnvoie, typePayement, dateTimePicker_debut.Value.ToString("yyyyMMdd"), dateTimePicker_fin.Value.ToString("yyyyMMdd"), checkBox_AfficherDate.Checked, textBox_Nom.Text);
        }

        private void textBox_Nom_TextChanged(object sender, EventArgs e)
        {
            // affiche en fct de ce qui à été choisi
            Ctrl_HistoriqueFacture controle = new Ctrl_HistoriqueFacture();
            controle.afficheHistorique(ref dataGridView_Historique, typeEnvoie, typePayement, dateTimePicker_debut.Value.ToString("yyyyMMdd"), dateTimePicker_fin.Value.ToString("yyyyMMdd"), checkBox_AfficherDate.Checked, textBox_Nom.Text);
        }

        private void dateTimePicker_debut_ValueChanged(object sender, EventArgs e)
        {
            // affiche en fct de ce qui à été choisi
            Ctrl_HistoriqueFacture controle = new Ctrl_HistoriqueFacture();
            controle.afficheHistorique(ref dataGridView_Historique, typeEnvoie, typePayement, dateTimePicker_debut.Value.ToString("yyyyMMdd"), dateTimePicker_fin.Value.ToString("yyyyMMdd"), checkBox_AfficherDate.Checked, textBox_Nom.Text);
        }

        private void checkBox_AfficherDate_CheckedChanged(object sender, EventArgs e)
        {
            // activé ou pas le choix des dates 
            if (checkBox_AfficherDate.Checked)
            {
                label_dateGénération.Enabled = true;
                label_début.Enabled = true;
                label_fin.Enabled = true;
                label_dateDeFin.Enabled = true;
                dateTimePicker_debut.Enabled = true;
                dateTimePicker_fin.Enabled = true;
            }
            else
            {
                label_dateGénération.Enabled = false;
                label_début.Enabled = false;
                label_fin.Enabled = false;
                label_dateDeFin.Enabled = false;
                dateTimePicker_debut.Enabled = false;
                dateTimePicker_fin.Enabled = false;

            }

            // affiche en fct de ce qui à été choisi
            Ctrl_HistoriqueFacture controle = new Ctrl_HistoriqueFacture();
            controle.afficheHistorique(ref dataGridView_Historique, typeEnvoie, typePayement, dateTimePicker_debut.Value.ToString("yyyyMMdd"), dateTimePicker_fin.Value.ToString("yyyyMMdd"), checkBox_AfficherDate.Checked, textBox_Nom.Text);

        }
    }
}
