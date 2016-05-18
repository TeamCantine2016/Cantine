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
using System.Data.SqlClient;

namespace ProjetCantine.Vues
{
    public partial class Form_EncodageFactures : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        db_cantineDataSet ds = new db_cantineDataSet();
        SqlConnection con = new SqlConnection(DbConnection.connectionString);
        public Form_EncodageFactures()
        {
            InitializeComponent();
        }

        private void Form_EncodageFactures_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_cantineDataSet.TA_Remplir_CB_FormatEnvoie' table. You can move, or remove it, as needed.
            this.tA_Remplir_CB_FormatEnvoieTableAdapter.Fill_FormatEnvoi(this.db_cantineDataSet.TA_Remplir_CB_FormatEnvoie);
            // requête du dataset pour remplir le datagridview
            this.tA_Listes_Personnes_query.Fill_Tuteurs(this.db_cantineDataSet.TA_Listes_Personnes);
            // pour adapter la largeur de colonnes
            dGdVw_DetailFamille.AutoResizeColumns();
            // pour élargir la dernière colonne horizontalement pour ne pas avoir une zone grise
            dGdVw_DetailFamille.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGdVw_DetailFamille.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView_Membres.AutoResizeColumns();
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

        public void filtre()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("PS_Filtre_Nom_Tel", con); 

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@nom", SqlDbType.NVarChar);
            cmd.Parameters.Add("@tel", SqlDbType.NVarChar);

            cmd.Parameters["@nom"].Direction = ParameterDirection.Input;
            cmd.Parameters["@tel"].Direction = ParameterDirection.Input;

            cmd.Parameters["@nom"].Value = txtBx_RechNom.Text;
            cmd.Parameters["@tel"].Value = txtBx_RechNumTel.Text;

            DataTable t = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            t.Load(dr);
            con.Close();

            dGdVw_DetailFamille.DataSource = t;

        }

        private void txtBx_RechNom_TextChanged(object sender, EventArgs e)
        {
            filtre();

        }

        private void txtBx_RechNumTel_TextChanged(object sender, EventArgs e)
        {
            filtre();

        }
        private void dGdVw_DetailFamille_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tabDetail.TabPages.Clear();
            int i = dGdVw_DetailFamille.CurrentRow.Index;
            DataGridViewRow r = dGdVw_DetailFamille.Rows[i];
            String query = "WITH Tuteur AS(SELECT prenom, nom, id FROM tbl_relation_tuteur_enfant ";
            query += "INNER JOIN tbl_personne ON tbl_relation_tuteur_enfant.tuteur_id= tbl_personne.id ";
            query += "Where tbl_personne.nom = '" + r.Cells[0].Value.ToString() + "' ),";
            query += "Enfant AS( SELECT prenom, nom, date_naissance, id FROM tbl_relation_tuteur_enfant ";
            query += "INNER JOIN tbl_personne ON tbl_relation_tuteur_enfant.enfant_id= tbl_personne.id) ";
            query += "SELECT DISTINCT Enfant.nom AS 'Nom', Enfant.prenom AS 'Prénom', Enfant.date_naissance AS 'Date de Naissance' ";
            query += "FROM Tuteur, Enfant, tbl_relation_tuteur_enfant ";
            query += "WHERE Tuteur.id = tbl_relation_tuteur_enfant.tuteur_id AND tbl_relation_tuteur_enfant.enfant_id = Enfant.id";

            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            dataGridView_Membres.DataSource = t;

            con.Close();

             
            for (int j = 0; j < dataGridView_Membres.Rows.Count; j++)
            {
               
                string title = dataGridView_Membres.Rows[j].Cells[0].Value.ToString()+ " " +dataGridView_Membres.Rows[j].Cells[1].Value.ToString();

                TabPage myTabPage = new TabPage(title);     // Nouvel onglet et le title pour afficher le nom et le prenom sur l'onglet 
                tabDetail.TabPages.Add(myTabPage);        // J'ajoute l'onglet au tabcontrol
               

                //====Création de datagridView======================================================
                DataGridView dataGridView_historique = new DataGridView();      // Nouveau DataGridView pour afficher l'historique de chaque élève
                DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn() { ReadOnly = false, Name = "Selection" }; // Création d'une colonne pour ajouter des checkbox
                dataGridView_historique.Columns.Add(col); // ajouter les colonnes dans la datagridview
                dataGridView_historique.Size = new System.Drawing.Size(460, 187); // la taille de datagridview          
                dataGridView_historique.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;  // pour afficher tout la ligne dans le datagridview
                //=====================================================================================


                // une requete qui affiche tout les repas avec leur date et prix pris par un élève
                String req = "SELECT type_repas AS 'Type de Repas', date_repas AS 'Date de repas', CONCAT(tbl_prix_repas.prix,' €') AS 'Prix' FROM tbl_personne, tbl_prix_repas, tbl_relation_repas, tbl_repas ";
                req += "WHERE tbl_personne.id = tbl_relation_repas.personne_id  AND tbl_relation_repas.repas_id = tbl_repas.id AND tbl_repas.id=tbl_prix_repas.id ";
                req += "  AND CONCAT(nom,' ',prenom) = '" + title + "' ORDER BY prenom, date_repas";


                con.Open();

                SqlCommand cmd1 = new SqlCommand(req, con);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                DataTable t1 = new DataTable();
                t1.Load(dr1);
                dataGridView_historique.DataSource = t1;

                con.Close();
                myTabPage.Controls.Add(dataGridView_historique);                // J'ajoute le DataGridView à mon onglet fraichement crée avec les données chargés 

            }
           
            
        }
       
    }
}
