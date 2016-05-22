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

        public void filtre(object sender, EventArgs e) // les deux textBox sont directement orientés vers cette fonction
        {
            // création de l'objet pour filtrer dataGridView
            DbConnection objetFiltre = new DbConnection();
            // appelle la méthode liée à la procédure stockée
            objetFiltre.filtreParNomParTel(ref dGdVw_DetailFamille, ref txtBx_RechNom, ref txtBx_RechNumTel);
        }

        private void dGdVw_DetailFamille_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            groupBox1_selectperiode.Enabled = true;

            int indexLigne = dGdVw_DetailFamille.CurrentRow.Index;
            
            // création objet pour remplir datagridview
            DbConnection objetTableau = new DbConnection();
            // appelle méthode qui affiche les tuteurs
            objetTableau.afficheListeEnfantSelonSelection_Factures(ref dataGridView_Membres, ref dGdVw_DetailFamille, indexLigne);


            /* cette ligne sera supprimé lorsque la prochaine requête sera également déplacé dans DbConnection.cs */
            DataGridViewRow r = dGdVw_DetailFamille.Rows[indexLigne];

            
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
        private void dateTimePicker_debut_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_fin.MinDate = dateTimePicker_debut.Value; //  on sécurise afin que la date de fin ne puisse être inférieure à la date de début
        }

        private void button_visualiser_Click(object sender, EventArgs e)
        {
            

            int k = dGdVw_DetailFamille.CurrentRow.Index;
            DataGridViewRow r = dGdVw_DetailFamille.Rows[k];
            string debut = dateTimePicker_debut.Value.ToString("yyyy-MM-dd");
            string fin = dateTimePicker_fin.Value.ToString("yyyy-MM-dd");

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
                query += "  AND CONCAT(nom,' ',prenom) = '" + title + "' AND date_repas BETWEEN '" + debut + "' AND '" + fin + "' ORDER BY prenom ";


                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable t = new DataTable();
                t.Load(dr);
                dataGridView_historique.DataSource = t;

                con.Close();
                myTabPage.Controls.Add(dataGridView_historique);                // J'ajoute le DataGridView à mon onglet fraichement crée avec les données chargés 


                //===============================Pour compter les repas prisent par tuteur par type de repas=============================================

                label_chaud1.Text = compteurTypeRepas("chaud1", ref r, debut, fin);
                label_chaud2.Text = compteurTypeRepas("chaud2", ref r, debut, fin);
                label_froid.Text = compteurTypeRepas("froid", ref r, debut, fin);
                label_aucun.Text = compteurTypeRepas("aucun", ref r, debut, fin);

                //================================ Total prix par catégorie de repas ================================================================      
                label_Total_Chaud1.Text = calculTotalRepasType(1, ref r,debut,fin);
                label_Total_Chaud2.Text = calculTotalRepasType(2, ref r,debut,fin);
                label_Total_Froid.Text = calculTotalRepasType(3, ref r,debut,fin);
                label_Total_Aucun.Text = calculTotalRepasType(4, ref r,debut,fin);

            }
        }

       
        private string compteurTypeRepas(string typer, ref DataGridViewRow r, string debut, string fin)
        {
            //string retour = "";
            //con.Open();

            //SqlCommand cmd = new SqlCommand("PS_Calcul_Repas", con);

            //cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.Add("@typerepas", SqlDbType.NVarChar);
            //cmd.Parameters.Add("@dateD", SqlDbType.NVarChar);
            //cmd.Parameters.Add("@dateF", SqlDbType.NVarChar);
            //cmd.Parameters.Add("@nom", SqlDbType.NVarChar);

            //cmd.Parameters["@typerepas"].Value = typer;
            //cmd.Parameters["@nom"].Value = r.Cells[1].Value.ToString();
            //cmd.Parameters["@dateD"].Value = debut;
            //cmd.Parameters["@dateF"].Value = fin;


            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    retour = dr["Type_Repas"].ToString();
            //}
            //dr.Close();
            //con.Close();

            string retour = "";
            string query = " SELECT count(type_repas)AS 'Type_Repas' FROM tbl_personne, tbl_prix_repas, tbl_relation_repas, tbl_repas ";
            query += " WHERE tbl_personne.id = tbl_relation_repas.personne_id  AND tbl_relation_repas.repas_id = tbl_repas.id AND tbl_repas.id = tbl_prix_repas.id ";
            query += " AND type_repas = '" + typer + "' AND  tbl_personne.nom = '" + r.Cells[1].Value.ToString() + "' AND date_repas BETWEEN  '" + debut + "' AND '" + fin + "' ";

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                retour = dr["Type_Repas"].ToString();
            }
            dr.Close();
            con.Close();
            return retour;
        }

        private string calculTotalRepasType(int typeRepas, ref DataGridViewRow r, string debut, string fin)
        {
            string retour = "";
            string req = " SELECT SUM(prix)AS 'Prix' FROM tbl_personne, tbl_prix_repas, tbl_relation_repas, tbl_repas ";
            req += " WHERE tbl_personne.id = tbl_relation_repas.personne_id  AND tbl_relation_repas.repas_id = tbl_repas.id AND tbl_repas.id = tbl_prix_repas.id ";
            req += " AND  tbl_personne.nom = '" + r.Cells[1].Value.ToString() + "' AND date_repas BETWEEN  '" + debut + "' AND '" + fin + "' AND tbl_repas.id =" + typeRepas;       
            con.Open();

            SqlCommand cmd = new SqlCommand(req, con);        
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                retour = dr["Prix"].ToString() + " €";
            }
            dr.Close();
            con.Close();
            return retour;
        }

      
    }
}
