using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetCantine.Models;

namespace ProjetCantine.Controller
{
    class Ctrl_EncodageFactures
    {
        public void filtreParNomParTel(ref DataGridView tableauCible, String nom, String telephone)
        {
            DbConnection dbTalk = new DbConnection();
            dbTalk.filtreParNomParTel(ref tableauCible, nom, telephone);
        }

        public void afficheListeEnfantSelonSelection(ref DataGridView tableauCible, ref DataGridView tableauSource, int index)
        {
            DbConnection dbTalk = new DbConnection();
            // ligne du datagridview courant
            DataGridViewRow ligne = tableauSource.Rows[index];

            // requête pour l'affichage de la dataGridView_Membre
            String query = dbTalk.getQuery("listeIntermediaire_Tuteur");
            // spécification des critères pour la liste/tableau intermédiaire tuteur
            query += " Where tbl_personne.nom = '" + ligne.Cells[1].Value.ToString() + "' ), ";
            // ajout de la liste/tableau intermédiaire enfant
            query += dbTalk.getQuery("listeIntermediaire_Enfant");
            // requête utilisant les deux listes/tableaux intermédiaires pour en synthétiser la liste des enfants du tuteur sélectionné
            query += dbTalk.getQuery("listeEnfantSelonTuteur_Facture");

            // injection des données dans la datagridview
            dbTalk.injectDataToDataGridView(query, ref tableauCible);
        }

        public String get_DateCloture(ref DataGridView tableauSource, int index)
        {
            DbConnection dbTalk = new DbConnection();
            // ligne du datagridview courant
            DataGridViewRow ligne = tableauSource.Rows[index];

            // requête pour la dernière date de clôture
            String query = dbTalk.getQuery("dateCloture");
            // spécification des critères
            query += "WHERE(tbl_relation_facture.tuteur_id = " + ligne.Cells[0].Value.ToString() + ")";

            // récupérer et afficher la dernière date de clôture
            try
            {
                return dbTalk.get_date(query).ToString().Substring(0, 10);
            }
            catch (Exception)
            {
                MessageBox.Show(" La dernière facture pour ce tuteur \r\n n'a pas encore été générée");
                return "> Aucune facture existante.";
            }
        }

        public float get_sommePrixRepasEnfant(int id_enfant, String date_debut, String date_fin) // CALCULER le prix total pour 1 enfant durant une periode donnée
        {
            float total = 0.0f;
            DbConnection dbTalk = new DbConnection();
            // requête pour l'obtention de la somme de prix à payer pour 1 enfant
            String query = dbTalk.getQuery("sommeRepasUnEnfant");
            // spécification des critères
            query += "WHERE personne_id = " + id_enfant + " AND date_repas BETWEEN '" + date_debut + "' AND '" + date_fin + "';";
            // récupérer le total
            float.TryParse(dbTalk.recupDataScalar(query).ToString(), out total);
            return total;
        }

        public void show_detailsRepasUnEnfant(ref DataGridView tablecible, String date_debut, String date_fin, String id_enfant)
        {
            DbConnection dbTalk = new DbConnection();
            // requête pour le récapitulatif d'un seul enfant
            String query = dbTalk.getQuery("detailsRepasConsomesUnEnfant");
            query +=   /*AND CONCAT(nom,' ',prenom)*/ " AND personne_id = '" + id_enfant + "' AND date_repas BETWEEN '" + date_debut + "' AND '" + date_fin + "' ORDER BY prenom ";
            // injecter dans la datagridview du récapitulatif de l'enfant
            dbTalk.injectDataToDataGridView(query, ref tablecible);

        }

        //private string compteurTypeRepas(string type_repas, ref DataGridViewRow r, string debut, string fin)
        //{
        //    string retour = "";
        //    string query = " SELECT count(type_repas)AS 'Type_Repas' FROM tbl_personne, tbl_prix_repas, tbl_relation_repas, tbl_repas ";
        //    query += " WHERE tbl_personne.id = tbl_relation_repas.personne_id  AND tbl_relation_repas.repas_id = tbl_repas.id AND tbl_repas.id = tbl_prix_repas.id ";
        //    query += " AND type_repas = '" + type_repas + "' AND  tbl_personne.nom = '" + r.Cells[1].Value.ToString() + "' AND date_repas BETWEEN  '" + debut + "' AND '" + fin + "' ";

        //    con.Open();
        //    SqlCommand cmd = new SqlCommand(query, con);

        //    SqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        retour = dr["Type_Repas"].ToString();
        //    }
        //    dr.Close();
        //    con.Close();
        //    return retour;
        //}



    }
}
