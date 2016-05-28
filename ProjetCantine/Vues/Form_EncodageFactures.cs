using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using ProjetCantine.Controller;
using ProjetCantine.Models;

namespace ProjetCantine.Vues
{
    public partial class Form_EncodageFactures : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        db_cantineDataSet ds = new db_cantineDataSet();
        SqlConnection con = new SqlConnection(DbConnection.connectionString);
        string debut = "";
        string fin = "";
        float prix = 0;
        string path_facture = "";

        public Form_EncodageFactures()
        {
            InitializeComponent();
        }

        private void Form_EncodageFactures_Load(object sender, EventArgs e) // 99% READY - FILL UP DATAGRIDS 
        {
            // requête du dataset pour remplir le datagridview
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


        //*****************************************************************************************************************************************
        private void btApercu_Click(object sender, EventArgs e) // CREATION FACTURE 
        {
            // création variables
            int facture_id = 0;
            // capturer la periode de la facture définie
            DateTime debut = dateTimePicker_debut.Value;
            DateTime fin = dateTimePicker_fin.Value;
            // capturer l'index de la ligne cliqué
            int i = dGdVw_DetailFamille.CurrentRow.Index;
            // capturer la ligne cliqué
            DataGridViewRow lineSelected = dGdVw_DetailFamille.Rows[i];
            // initialisation des variables dont source est la ligne cliquée
            string codeClient = lineSelected.Cells[0].Value.ToString();
            string nomClient = lineSelected.Cells[1].Value.ToString();
            string prenomClient = lineSelected.Cells[2].Value.ToString();
            string adresseClient = lineSelected.Cells[4].Value.ToString();
            string villeClient = lineSelected.Cells[5].Value.ToString();
            string paysClient = lineSelected.Cells[6].Value.ToString();
            
            //....................................................................??? toujours aller chercher la facture "max" ???
            string query = " SELECT MAX(id) as 'facture_id' FROM tbl_facture ";
            
            con.Open();
            cmd = new SqlCommand(query, con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                facture_id = (int)dr["facture_id"];
            }
            dr.Close();
            con.Close();

            // créer objet Facture
            ApercuFacture facture = new ApercuFacture();
            // créer facture avec Apercufacture.cs et récupérer chemin d'accès (path) de la facture créé
            String pathNouvelleFacture = facture.facture(lb_repasChaud1.Text, lb_repasChaud2.Text, lb_repasFroid.Text, lb_repasAucun.Text, label_chaud1.Text, label_chaud2.Text, label_froid.Text, label_aucun.Text, facture_id
                                                ,debut ,fin, codeClient, nomClient, prenomClient, adresseClient,villeClient, paysClient);

            // teste si le fichier a bien été creer           
            if (pathNouvelleFacture.LastIndexOf(".pdf") == -1)
            { // si je ne reçois pas un path, alors message d'erreur
                MessageBox.Show(pathNouvelleFacture);
            }
            else
            { // si je reçois un path, c'est ok
                MessageBox.Show("La création à bien été éffectué à l'adresse: " + pathNouvelleFacture);
                facture.affichageFacture(pathNouvelleFacture);
                path_facture = pathNouvelleFacture;
                btEnvoi.Enabled = true;
            }
        }
        //*****************************************************************************************************************************************

        public void filtre(object sender, EventArgs e) // 99% READY -  FILTRE TUTEUR / ENFANT POUR DATAGRIDVIEW-MEMBRE 
        {
            // création de l'objet pour filtrer dataGridView
            Ctrl_EncodageFactures controle = new Ctrl_EncodageFactures();
            // appelle la méthode liée à la procédure stockée
            controle.filtreParNomParTel(ref dGdVw_DetailFamille, txtBx_RechNom.Text, txtBx_RechNumTel.Text);
        }
 

        private void dGdVw_DetailFamille_CellClick(object sender, DataGridViewCellEventArgs e) // 90% READY - Remplir DGV-Membre - Gestion date dernière clôture
        {
            // débloquer zone selection periode
            groupBox1_selectperiode.Enabled = true;

            // capturer l'index de la ligne sélectionnée
            int indexLigne = dGdVw_DetailFamille.CurrentRow.Index;
            
            // création objet pour remplir datagridview
            Ctrl_EncodageFactures controle = new Ctrl_EncodageFactures();
            // appelle méthode qui affiche les tuteurs
            controle.afficheListeEnfantSelonSelection(ref dataGridView_Membres, ref dGdVw_DetailFamille, indexLigne);

            // appelle methode qui recherche la date dernière clôture
            label_dateCloture.Text = controle.get_DateCloture(ref dGdVw_DetailFamille, indexLigne);

            // mettre à jour les dateTimePicker du formulaire
            DateTime laDate; // pour y placer la date converti de puis la textbox
            if (DateTime.TryParse(label_dateCloture.Text, out laDate)) // renvoie "true" si la conversion en date est possible et affecte le résultat de la conversion à la variable "laDate"
            { 
                dateTimePicker_debut.Value = laDate.AddDays(1); // initialisation à un jour après dernière date de clôture
                dateTimePicker_fin.Value = DateTime.Now; // initialisation au jour actuel - ajourd'hui
            }
            else
            {
            /* A MODIFIER SELON COMMENTAIRE */ dateTimePicker_debut.Value = DateTime.Now; // <- C'est faux, doit être initialisé au dernier repas déjà consommé s'il existe !!
            }
            
            
         }




        //*****************************************************************************************************************************************
        private void dateTimePicker_debut_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_fin.MinDate = dateTimePicker_debut.Value; //  on sécurise afin que la date de fin ne puisse être inférieure à la date de début
            dateTimePicker_fin.Value = dateTimePicker_fin.MinDate;
        }
        //*****************************************************************************************************************************************

        //*****************************************************************************************************************************************
        private void button_visualiser_Click(object sender, EventArgs e)
        {

            int k = dGdVw_DetailFamille.CurrentRow.Index;
            DataGridViewRow r = dGdVw_DetailFamille.Rows[k];
            debut = dateTimePicker_debut.Value.ToString("yyyy-MM-dd");
            fin = dateTimePicker_fin.Value.ToString("yyyy-MM-dd");

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
                // une requete pour afficher le prix total de tous les repas par tuteur
                string requete = " SELECT SUM(prix)AS 'Prix' FROM tbl_personne, tbl_prix_repas, tbl_relation_repas, tbl_repas ";
                requete += " WHERE tbl_personne.id = tbl_relation_repas.personne_id  AND tbl_relation_repas.repas_id = tbl_repas.id AND tbl_repas.id = tbl_prix_repas.id ";
                requete += " AND  tbl_personne.nom = '" + r.Cells[1].Value.ToString() + "' AND date_repas BETWEEN  '" + debut + "' AND '" + fin + "' ";

                con.Open();
                SqlCommand cmd1 = new SqlCommand(requete, con);

                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    label_prix.Text = dr1["Prix"].ToString() + " €";
                    //==============================> devra être converti en décimal
                    prix = (float)Convert.ToDouble(dr1["Prix"].ToString()+",00");
                }
                dr1.Close();
                con.Close();


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
            if (label_chaud1.Text.Length != 0 & label_chaud2.Text.Length != 0 & label_froid.Text.Length != 0 & label_aucun.Text.Length != 0)
            {
                btApercu.Enabled = true;
            }
        }
        //*****************************************************************************************************************************************

        //*****************************************************************************************************************************************
        private string compteurTypeRepas(string typer, ref DataGridViewRow r, string debut, string fin)
        {
            //================================Est ce que c'est mieux d'utiliser les Procédures stockées=================================

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

            //============================================================================================================

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
        //*****************************************************************************************************************************************

        //*****************************************************************************************************************************************
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
        //*****************************************************************************************************************************************

        //*****************************************************************************************************************************************
        private void btEnvoi_Click(object sender, EventArgs e)
        {
            int k = dGdVw_DetailFamille.CurrentRow.Index;
            DataGridViewRow r = dGdVw_DetailFamille.Rows[k];
            int resultat = 0;
            int resultat1 = 0;
            int resultat2 = 0;
            //==================================On insere les données dans la table tbl_facture=========================
            string query = "INSERT Into tbl_facture (total_a_payer,debut_periode,fin_periode) ";
            query += "VALUES ('"+ prix +"','" + debut + "','" + fin + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            resultat = cmd.ExecuteNonQuery();
            con.Close();
            //==================================On récupère l'identifiant de la facture=================================
            int facture_id = 0;
            string query1 = " SELECT MAX(id) as 'facture_id' FROM tbl_facture ";

            con.Open();
            cmd = new SqlCommand(query1, con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                facture_id = (int)dr["facture_id"];
            }
            dr.Close();
            con.Close();
            //=================================On insère les données dans la table tbl_relation_facture======================
            int tuteur_id = Convert.ToInt32(r.Cells[0].Value.ToString());
            string query2 = "INSERT Into tbl_relation_facture (facture_id,tuteur_id) ";
            query2 += "VALUES (" + facture_id + "," + tuteur_id + ")";
            con.Open();
            cmd = new SqlCommand(query2, con);
            resultat1 = cmd.ExecuteNonQuery();
            con.Close();
            //================================On insère les données dans la table d'historique=======================
            string query3 = "INSERT Into tbl_historique_facture (facture_id,tuteur_id,statut_payement,statut_envoye,detaille,format_envoye,archive)";
            query3 += "VALUES ('" + facture_id + "','" + tuteur_id + "','0','0','0','mail','"+ path_facture + "')";
            con.Open();
            cmd = new SqlCommand(query3, con);
            resultat2 = cmd.ExecuteNonQuery();
            con.Close();

            if ((resultat + resultat1 + resultat2) == 3)
            {
                MessageBox.Show("La facture a été enregistrée avec succès.");
            }
            else
            {
                MessageBox.Show("Une erreur est intervenue lors de l'enregistrement de la facture.");
            }
        }
        //*****************************************************************************************************************************************
    }
}
