using System;
using System.Windows.Forms;
using ProjetCantine.Models;
using System.Collections.Generic;
using System.Data;

namespace ProjetCantine.Controller
{
    class Ctrl_EncodageFactures
    {
        public void filtreParNomParTel(ref DataGridView tableauCible, String nom, String telephone)
        { // gestion filtre  des tuteurs avec procédure stockée par le nom ou le téléphone
            try
            {
                DbConnection dbTalk = new DbConnection();
                dbTalk.filtreParNomParTel(ref tableauCible, nom, telephone);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erreur filtre tuteurs ! \r\n\r\n" + ex.Message);
            }
        }

        public void afficheListeEnfantSelonSelection(ref DataGridView tableauCible, ref DataGridView tableauSource, int index)
        { // affichage de la liste des enfants selon le tuteur sélectionné
            try
            {
                // création de l'objet de communication avec la db
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
            catch (Exception ex)
            {
                MessageBox.Show(" Erreur affichage liste enfants ! \r\n\r\n" + ex.Message);
            }
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

        public DataTable convertList(List<String[]> liste)
        {
            DataTable table = new DataTable();
            try
            {
                

                int columns = 0;
                foreach (String[] element in liste)
                { // le nombre de colonnes
                    if (element.Length > columns) { columns = element.Length; }
                }

                for (int i = 0; i < columns; i++)
                { // ajouter les colonnes
                    table.Columns.Add();
                }

                foreach (String[] element in liste)
                {
                    table.Rows.Add(element);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erreur convertion liste vers datatable ! \r\n\r\n" + ex.Message);
            }
            
            return table;

            
        }

        public float get_sommePrixRepasParType(int id_enfant, String type, String date_debut, String date_fin) // CALCULER le prix total pour 1 enfant durant une periode donnée par type de repas
        {
            float total = 0.0f;
            DbConnection dbTalk = new DbConnection();
            try
            {
                // requête pour l'obtention de la somme de prix à payer pour 1 enfant
                String query = dbTalk.getQuery("sommeRepasUnEnfant");
                // spécification des critères
                query += "WHERE personne_id = " + id_enfant + " AND type_repas = '" + type + "' AND date_repas BETWEEN '" + date_debut + "' AND '" + date_fin + "';";
                // récupérer le total
                float.TryParse(dbTalk.recupDataScalar(query).ToString(), out total);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erreur calcul total repas par type ! \r\n\r\n" + ex.Message);
            }
            return total;
        }

        public String compteurTypeRepas(String type, String id_enfant, String date_debut, String date_fin)
        {
            DbConnection dbTalk = new DbConnection();
            try
            {
                String query = dbTalk.getQuery("compteTypeRepas");
                query += " WHERE personne_id = '" + id_enfant + "' AND type_repas = '" + type + "' AND date_repas BETWEEN '" + date_debut + "' AND '" + date_fin + "';";
                return dbTalk.recupDataScalar(query).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erreur compteur type de repas ! \r\n\r\n" + ex.Message);
            }

            return "0";
        }

        public int get_dernierNumeroFactureDisponible()
        {
            DbConnection dbTalk = new DbConnection();
            try
            {
                String query = dbTalk.getQuery("dernierNumeroFacture");

                return int.Parse(dbTalk.recupDataScalar(query)) + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erreur recherche numero de facture disponible ! \r\n\r\n" + ex.Message);
            }
            return 0;
        }

        public void saveFacture(String path, String solde, String date_debut, String date_fin, int id, String tuteur_id)
        {
            DbConnection dbTalk = new DbConnection();
            try
            {
                dbTalk.insert("tbl_facture", solde.Replace(",",".") + ",'" + date_debut + "','" + date_fin + "'");
                dbTalk.insert("tbl_historique_facture", id + "," + int.Parse(tuteur_id) + ",0,0,0,null,'" + path + "'");
                dbTalk.insert("tbl_relation_facture", id + "," + int.Parse(tuteur_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erreur de sauvegarde ! \r\n\r\n" + ex.Message);
            }
        }
        

    }
}
