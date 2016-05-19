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
using System.Globalization;

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

            groupBox1_selectperiode.Enabled = true;

            int i = dGdVw_DetailFamille.CurrentRow.Index;
            DataGridViewRow r = dGdVw_DetailFamille.Rows[i];
            String query = "WITH Tuteur AS(SELECT prenom, nom, id FROM tbl_relation_tuteur_enfant ";
            query += "INNER JOIN tbl_personne ON tbl_relation_tuteur_enfant.tuteur_id= tbl_personne.id ";
            query += "Where tbl_personne.nom = '" + r.Cells[1].Value.ToString() + "' ),";
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


            String req = "SELECT max(tbl_facture.fin_periode) AS 'fin_periode' FROM tbl_relation_facture INNER JOIN tbl_facture ON tbl_relation_facture.facture_id = tbl_facture.id ";
            req += "WHERE(tbl_relation_facture.tuteur_id = "+ r.Cells[0].Value.ToString() +")";
            con.Open();
            SqlCommand cmd1 = new SqlCommand(req, con);

            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                try
                {
                    label_dateCloture.Text = dr1["fin_periode"].ToString().Substring(0,10);
                }
                catch(Exception)
                {
                    MessageBox.Show("Aucune facture encodée pour cette personne");
                    label_dateCloture.Text = " ";
                }
                    
            }
            dr1.Close();
            con.Close();

            // Si la label pour afficher la date de clôture est vide ça veut dire que cette personne n'a pas encore de facture dans la db
            if (label_dateCloture.Text != " ")
            {
                dateTimePicker_debut.MinDate = Convert.ToDateTime(label_dateCloture.Text); // on initialise la date min de datetimepicker à la date de la derniere facture(impossible de selectionner les date d'avant)
                dateTimePicker_debut.MinDate = dateTimePicker_debut.MinDate.AddDays(1); // on ajoute un jour à la datetimepicker pour commencer une nouvelle facture
               // dateTimePicker_debut.MaxDate <= dateTimePicker_fin.MinDate;
               // DateTimePicker.(dateTimePicker_debut.MaxDate,dateTimePicker_fin.MinDate);
            }
            else
            {
                dateTimePicker_debut.MinDate = Convert.ToDateTime("01-01-1970");
            }
            
            
         }

        private void button_visualiser_Click(object sender, EventArgs e)
        {
            

            int k = dGdVw_DetailFamille.CurrentRow.Index;
            DataGridViewRow r = dGdVw_DetailFamille.Rows[k];
            
            groupBox_recap.Text = "Récap pour : " + r.Cells[1].Value.ToString() + " " + r.Cells[2].Value.ToString() ;

            tabDetail.TabPages.Clear();

            for (int i = 0; i < dataGridView_Membres.Rows.Count; i++)
            {
                string title = dataGridView_Membres.Rows[i].Cells[0].Value.ToString() + " " + dataGridView_Membres.Rows[i].Cells[1].Value.ToString();

                TabPage myTabPage = new TabPage(title);     // Nouvel onglet et le title pour afficher le nom et le prenom sur l'onglet 
                tabDetail.TabPages.Add(myTabPage);        // J'ajoute l'onglet au tabcontrol



                //====Création de datagridView======================================================
                DataGridView dataGridView_historique = new DataGridView();      // Nouveau DataGridView pour afficher l'historique de chaque élève
                dataGridView_historique.ReadOnly = true; // juste la lecture dans le datagrid sans modification
                dataGridView_historique.Size = new System.Drawing.Size(460, 187); // la taille de datagridview          
                dataGridView_historique.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;  // pour afficher tout la ligne dans le datagridview
                //=====================================================================================


                // une requete qui affiche tout les repas avec leur date et prix pris par un élève
                String query = "SELECT type_repas AS 'Type de Repas', date_repas AS 'Date de repas', CONCAT(tbl_prix_repas.prix,' €') AS 'Prix' FROM tbl_personne, tbl_prix_repas, tbl_relation_repas, tbl_repas ";
                query += "WHERE tbl_personne.id = tbl_relation_repas.personne_id  AND tbl_relation_repas.repas_id = tbl_repas.id AND tbl_repas.id=tbl_prix_repas.id ";
                query += "  AND CONCAT(nom,' ',prenom) = '" + title + "' AND date_repas BETWEEN' " + dateTimePicker_debut.Text + "' AND '" + dateTimePicker_fin.Text + "' ORDER BY prenom ";


                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable t = new DataTable();
                t.Load(dr);
                dataGridView_historique.DataSource = t;

                con.Close();
                myTabPage.Controls.Add(dataGridView_historique);                // J'ajoute le DataGridView à mon onglet fraichement crée avec les données chargés 


                //con.Open();

                //SqlCommand cmd1 = new SqlCommand("PS_Calcul_Repas", con);

                //cmd1.CommandType = CommandType.StoredProcedure;

                //cmd1.Parameters.Add("@typerepas", SqlDbType.NVarChar);
                //cmd1.Parameters.Add("@dateD", SqlDbType.NVarChar);
                //cmd1.Parameters.Add("@dateF", SqlDbType.NVarChar);
                //cmd1.Parameters.Add("@nom", SqlDbType.NVarChar);

                //cmd1.Parameters["@typerepas"].Value = "Aucun";
                //cmd1.Parameters["@nom"].Value = dGdVw_DetailFamille.Rows[k].Cells[1].Value.ToString();
                //cmd1.Parameters["@dateD"].Value = dateTimePicker_debut.Text;
                //cmd1.Parameters["@dateF"].Value = dateTimePicker_debut.Text;


                //SqlDataReader dr1 = cmd1.ExecuteReader();
                //while (dr1.Read())
                //{
                //    label_aucun.Text = dr1["Type_Repas"].ToString();
                //}
                //dr1.Close();
                //con.Close();

                //================================ AUCUN===================================================================================
                string req1 = " SELECT count(type_repas)AS 'Type_Repas' FROM tbl_personne, tbl_prix_repas, tbl_relation_repas, tbl_repas ";
                req1 += " WHERE tbl_personne.id = tbl_relation_repas.personne_id  AND tbl_relation_repas.repas_id = tbl_repas.id AND tbl_repas.id = tbl_prix_repas.id ";
                req1 += " AND type_repas = 'Aucun'  AND  tbl_personne.nom = '" + r.Cells[1].Value.ToString() + "' AND date_repas BETWEEN  '" + dateTimePicker_debut.Text + "' AND '" + dateTimePicker_fin.Text + "' ";

                con.Open();
                SqlCommand cmd1 = new SqlCommand(req1, con);

                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    label_aucun.Text = dr1["Type_Repas"].ToString();
                }
                dr1.Close();
                con.Close();


                //================================ CHAUD1===================================================================================

                string req2 = " SELECT count(type_repas)AS 'Type_Repas' FROM tbl_personne, tbl_prix_repas, tbl_relation_repas, tbl_repas ";
                req2 += " WHERE tbl_personne.id = tbl_relation_repas.personne_id  AND tbl_relation_repas.repas_id = tbl_repas.id AND tbl_repas.id = tbl_prix_repas.id ";
                req2 += " AND type_repas = 'Chaud 1'  AND  tbl_personne.nom = '" + r.Cells[1].Value.ToString() + "' AND date_repas BETWEEN  '" + dateTimePicker_debut.Text + "' AND '" + dateTimePicker_fin.Text + "' ";

                con.Open();
                SqlCommand cmd2 = new SqlCommand(req2, con);

                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    label_chaud1.Text = dr2["Type_Repas"].ToString();
                }
                dr2.Close();
                con.Close();

                //================================ CHAUD2===================================================================================

                string req3 = " SELECT count(type_repas)AS 'Type_Repas' FROM tbl_personne, tbl_prix_repas, tbl_relation_repas, tbl_repas ";
                req3 += " WHERE tbl_personne.id = tbl_relation_repas.personne_id  AND tbl_relation_repas.repas_id = tbl_repas.id AND tbl_repas.id = tbl_prix_repas.id ";
                req3 += " AND type_repas = 'Chaud 2'  AND  tbl_personne.nom = '" +r.Cells[1].Value.ToString() + "' AND date_repas BETWEEN  '" + dateTimePicker_debut.Text + "' AND '" + dateTimePicker_fin.Text + "' ";

                con.Open();
                SqlCommand cmd3 = new SqlCommand(req3, con);

                SqlDataReader dr3 = cmd3.ExecuteReader();
                while (dr3.Read())
                {
                    label_chaud2.Text = dr3["Type_Repas"].ToString();
                }
                dr1.Close();
                con.Close();
                //================================ FROID===================================================================================

                string req4 = " SELECT count(type_repas)AS 'Type_Repas' FROM tbl_personne, tbl_prix_repas, tbl_relation_repas, tbl_repas ";
                req4 += " WHERE tbl_personne.id = tbl_relation_repas.personne_id  AND tbl_relation_repas.repas_id = tbl_repas.id AND tbl_repas.id = tbl_prix_repas.id ";
                req4 += " AND type_repas = 'Froid'  AND  tbl_personne.nom = '" + r.Cells[1].Value.ToString() + "' AND date_repas BETWEEN  '" + dateTimePicker_debut.Text + "' AND '" + dateTimePicker_fin.Text + "' ";

                con.Open();
                SqlCommand cmd4 = new SqlCommand(req4, con);

                SqlDataReader dr4 = cmd4.ExecuteReader();
                while (dr4.Read())
                {
                    label_froid.Text = dr4["Type_Repas"].ToString();
                }
                dr4.Close();
                con.Close();

                //================================ TOTAL PRIX===================================================================================

                string req5 = " SELECT SUM(prix)AS 'Prix' FROM tbl_personne, tbl_prix_repas, tbl_relation_repas, tbl_repas ";
                req5 += " WHERE tbl_personne.id = tbl_relation_repas.personne_id  AND tbl_relation_repas.repas_id = tbl_repas.id AND tbl_repas.id = tbl_prix_repas.id ";
                req5 += " AND  tbl_personne.nom = '" + r.Cells[1].Value.ToString() + "' AND date_repas BETWEEN  '" + dateTimePicker_debut.Text + "' AND '" + dateTimePicker_fin.Text + "' ";

                con.Open();
                SqlCommand cmd5 = new SqlCommand(req5, con);

                SqlDataReader dr5 = cmd5.ExecuteReader();
                while (dr5.Read())
                {
                    label_prix.Text = dr5["Prix"].ToString() + " €";
                }
                dr5.Close();
                con.Close();



            }
        }

        private void dateTimePicker_debut_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_fin.MinDate = dateTimePicker_debut.Value; //  on sécurise afin que la date de fin ne puisse être inférieure à la date de début
        }
    }
}
