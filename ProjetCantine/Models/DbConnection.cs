using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ProjetCantine.Models
{
    class DbConnection
    {
        public static SqlConnection connexion = null;
        public static SqlCommand commande = null;
        public static SqlDataReader lecteurDeDonnees = null;
        public static DataTable tableDeDonnees = null;
        public static string connectionString = ConfigurationManager.ConnectionStrings["cantineConnectionString"].ConnectionString;

        public DbConnection() // constructeur
        {
            try
            {
                connexion = new SqlConnection(connectionString);
                connexion.Open();
                tableDeDonnees = new DataTable();
            }
            catch (SystemException exception)
            {
                MessageBox.Show("Erreur connexion DB :\r\n" + exception.Message, "Erreur DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

// REGROUPPEMENT DES REQUÊTES
        private string requete(string selection)
        {

            string laRequete = null;

            switch (selection)
            {
                case "listeTuteurDansVisualFamille":
                    laRequete = "SELECT tbl_personne.id as CodeClient, nom as Famille, telephone as Téléphone, numero+' '+ rue as Adresse, ville as Ville, code_postal as CodePostal, pays as Pays, courriel as Email ";
                    laRequete += "FROM tbl_personne inner join tbl_type_personne on tbl_personne.type_personne_id = tbl_type_personne.id ";
                    laRequete += "inner join tbl_adresse on tbl_personne.adresse_id = tbl_adresse.id ";
                    break;
                case "listeEnfantDansVisualFamille":
                    laRequete = "SELECT nom as Nom, prenom as Prénom, DATEDIFF(year, date_naissance, SYSDATETIME()) as Age , date_naissance As DateNaissance";
                    laRequete += " FROM tbl_personne";
                    laRequete += " inner join tbl_type_personne on tbl_type_personne.id = tbl_personne.type_personne_id";
                    laRequete += " inner join tbl_relation_tuteur_enfant on tbl_relation_tuteur_enfant.enfant_id = tbl_personne.id";
                    break;
                case "listeIntermediaire_Tuteur": // LISTE/TABLEAU INTERMEDIAIRE
                    laRequete = "With ";
                    laRequete += "Tuteur AS (SELECT prenom, nom, tbl_personne.id ";
                    laRequete += "FROM tbl_relation_tuteur_enfant ";
                    laRequete += "INNER JOIN tbl_personne ON tbl_relation_tuteur_enfant.tuteur_id= tbl_personne.id ";
                    break;
                case "listeIntermediaire_Enfant": // LISTE/TABLEAU INTERMEDIAIRE
                    laRequete = "Enfant AS( SELECT prenom, nom, date_naissance, tbl_personne.id FROM tbl_relation_tuteur_enfant ";
                    laRequete += "INNER JOIN tbl_personne ON tbl_relation_tuteur_enfant.enfant_id= tbl_personne.id) ";
                    break;
                case "listeEnfantSelonTuteur_Facture":
                    laRequete = "SELECT DISTINCT Enfant.id AS 'ID', Enfant.nom AS 'Nom', Enfant.prenom AS 'Prénom', Enfant.date_naissance AS 'Date de Naissance' ";
                    laRequete += "FROM Tuteur, Enfant, tbl_relation_tuteur_enfant ";
                    laRequete += "WHERE Tuteur.id = tbl_relation_tuteur_enfant.tuteur_id AND tbl_relation_tuteur_enfant.enfant_id = Enfant.id";
                    break;
                case "AffichageEtablissement":
                    laRequete = "SELECT * FROM tbl_etablissement Inner join tbl_adresse on tbl_adresse.id = tbl_etablissement.adresse_id";
                    break;
                case "recupIdAdresse":
                    laRequete = "SELECT id FROM tbl_adresse";
                    break;
                case "dateCloture":
                    laRequete = "SELECT MAX(tbl_facture.fin_periode) AS 'fin_periode' FROM tbl_relation_facture INNER JOIN tbl_facture ON tbl_relation_facture.facture_id = tbl_facture.id ";
                    break;
                case "detailsRepasConsomesUnEnfant":
                    laRequete = "SELECT type_repas AS 'Type de Repas', date_repas AS 'Date de repas', CONCAT(tbl_prix_repas.prix,' €') AS 'Prix' FROM tbl_personne, tbl_prix_repas, tbl_relation_repas, tbl_repas ";
                    laRequete += "WHERE tbl_personne.id = tbl_relation_repas.personne_id  AND tbl_relation_repas.repas_id = tbl_repas.id AND tbl_repas.id=tbl_prix_repas.id ";
                    break;
                case "detailsConsomationEnfant":
                    laRequete = "SELECT repas_id, date_repas ";
                    laRequete += "FROM tbl_relation_repas";
                    break;
                case "sommeRepasUnEnfant":
                    laRequete = "SELECT SUM(prix) as 'Prix total' ";
                    laRequete += "FROM[db_cantine].[dbo].[tbl_relation_repas] ";
                    laRequete += "INNER JOIN tbl_repas ON tbl_relation_repas.repas_id = tbl_repas.id ";
                    laRequete += "INNER JOIN tbl_prix_repas ON tbl_relation_repas.repas_id = tbl_prix_repas.id ";
                    break;
                case "compteTypeRepas":
                    laRequete = " SELECT count(type_repas)AS 'Type_Repas' ";
                    laRequete += "FROM[db_cantine].[dbo].[tbl_relation_repas] ";
                    laRequete += "INNER JOIN tbl_repas ON tbl_relation_repas.repas_id = tbl_repas.id ";
                    laRequete += "INNER JOIN tbl_prix_repas ON tbl_relation_repas.repas_id = tbl_prix_repas.id ";
                    break;
                case "dernierNumeroFacture":
                    laRequete = " SELECT MAX(id) as 'facture_id' FROM tbl_facture ";
                    break;
                case "recupIdEtablissement":
                    laRequete = "SELECT id FROM tbl_etablissement";
                    break;
                case "recupAdresseId":
                    laRequete = "SELECT adresse_id FROM tbl_etablissement";
                    break;
                case "tva":
                    laRequete = "SELECT tva FROM tbl_etablissement";
                    break;
                case "listeFacture":
                    laRequete = "select tbl_historique_facture.id as IdFacture, nom + ' ' + prenom as Personne,statut_envoye as Envoyer, statut_payement as Payer,";
                    laRequete += " total_a_payer as Montant,debut_periode as Date_Début,fin_periode as Date_Fin, archive as Répertoire from tbl_historique_facture";
                    laRequete += " inner join tbl_personne on tbl_personne.id = tbl_historique_facture.tuteur_id";
                    laRequete += " inner join tbl_facture on tbl_facture.id = tbl_historique_facture.facture_id";
                    break;
                default:
                case "pathFacture":
                    laRequete = "SELECT archive FROM tbl_historique_facture";
                    break;

                    return null;
            }

            return laRequete;
        }

        private void injectionDesDonnees(ref DataGridView tableauCible)
        { // fonction "privé" d'injection des données dans le dgv référencé
            try
            {
                lecteurDeDonnees = commande.ExecuteReader();
                tableDeDonnees.Load(lecteurDeDonnees);
                tableauCible.DataSource = tableDeDonnees;

                // pour récupérer l'id de l'enfant lors de l'encodage facture uniquement
            }
            catch (SystemException exception)
            {
                MessageBox.Show("Erreur injection DB vers " + tableauCible.ToString() + ".\r\n\r\n" + exception.Message, "Load data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                try
                {
                    connexion.Close();
                }
                catch (SystemException exception)
                {
                    MessageBox.Show("Erreur fermeture connexion DB.\r\n\r\n" + exception.Message, "Close DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string nomColonnes(String table)
        { // réuni les noms des colonnes d'une table dans un "string"

            // créer un reader de la table ciblée
            String query = "SELECT * FROM " + table + ";";
            commande = new SqlCommand(query, connexion);
            lecteurDeDonnees = commande.ExecuteReader();

            // combien de colonnes sont concernées
            int nombre_colonnes = lecteurDeDonnees.FieldCount;

            // parcourir toutes les colonnes et créer le "string" avec le nom des colonnes
            string stringNomsColonnes = "( ";
            for (int i = 1; i < nombre_colonnes; i++)
            {
                stringNomsColonnes += lecteurDeDonnees.GetName(i);
                if (i != nombre_colonnes - 1)
                {
                    stringNomsColonnes += ", ";
                }
            }
            stringNomsColonnes += " )";

            lecteurDeDonnees.Close();
            // renvoyer le "string"
            return stringNomsColonnes;
        }

        // LES METHODES PUBLIQUES

        // Récupérer la requête choisie
        public String getQuery(String selection)
        { // renvoie la requete selon la selection
            String selectionResult = requete(selection);
            if (selectionResult == null)
            {
                MessageBox.Show("Get no Query in DB class !!", "Query-error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return selectionResult;
        }

        public void get_listeRepasUnEnfant(ref List<String[]> liste, int id, String d_start, String d_stop)
        { // insère les données dans la liste en référence des données de repas pour 1 enfant
            try
            {
                String[] tab;
                String query = getQuery("detailsConsomationEnfant");
                query += " WHERE personne_id = " + id + " and date_repas BETWEEN '" + d_start + "' AND '" + d_stop + "';";
                commande = new SqlCommand(query, connexion);
                lecteurDeDonnees = commande.ExecuteReader();

                while (lecteurDeDonnees.Read())
                {
                    tab = new String[] { lecteurDeDonnees[0].ToString(), lecteurDeDonnees[1].ToString().Substring(0, 10), "empty" };
                    liste.Add(tab);
                }
                lecteurDeDonnees.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erreur récupération des données repas pour 1 enfant ! \r\n\r\n" + ex.Message);
            }
        }

        public void add_unitPriceToEachLunch(ref List<String[]> liste)
        { // insère dans la liste donnée en référence le prix unitaire pour un repas selon date de consomation
            try
            {
                foreach (String[] element in liste)
                {
                    String query = "SELECT prix FROM tbl_prix_repas WHERE ('" + DateTime.Parse(element[1]).ToString("yyyyMMdd") + "' BETWEEN date_debut AND date_fin) AND repas_id = " + element[0];
                    element[2] = recupDataScalar(query).ToString();
                    if (connexion.State == ConnectionState.Closed) { connexion.Open(); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erreur insertion prix unitaire dans liste ! \r\n\r\n" + ex.Message);
            }
        }

        public void injectDataToDataGridView(String requete, ref DataGridView dataGridCible)
        { // injection des données dans un dgv donné, appel public
            try
            {
                // affectation de la variable globale avec la requête reçue
                commande = new SqlCommand(requete, connexion);
                // execution de la requête
                injectionDesDonnees(ref dataGridCible);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erreur injection dans datagridview " + dataGridCible.ToString() + " ! \r\n\r\n" + ex.Message);
            }
        }

        public DateTime get_date(String requete)
        { // récupération de la date de clôture
            DateTime dateCloture;
            DateTime.TryParse("01/01/1970", out dateCloture);

            try
            {
                // affectation de la variable globale avec la requête reçue
                commande = new SqlCommand(requete, connexion);
                // execution de la requete

                lecteurDeDonnees = commande.ExecuteReader();
                while (lecteurDeDonnees.Read())
                {
                    DateTime.TryParse(lecteurDeDonnees["fin_periode"].ToString().Substring(0, 10), out dateCloture);
                }
                lecteurDeDonnees.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erreur récupération date de clôture ! \r\n\r\n" + ex.Message);
            }

            return dateCloture;
        }

        public SqlDataReader injectDataToDataReader(String requete)
        { // recuperer des donnéee d'une requete dans une data reader
            try
            {
                // affectation de la variable globale avec la requête reçue
                commande = new SqlCommand(requete, connexion);
                // execution de la requête
                lecteurDeDonnees = commande.ExecuteReader();
                lecteurDeDonnees.Read();
            }
            catch (SystemException exception)
            {
                MessageBox.Show("1. Erreur injection DB>Reader ou \r\n2. Erreur fermeture connexion DB.\r\n\r\n" + exception.Message, "Erreur load data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lecteurDeDonnees;
        }

        public string recupDataScalar(string requete)
        { // recuperer une seule donnée d'une requete
            String temp = "";
            try
            {
                if (connexion.State == ConnectionState.Closed) { connexion.Open(); }
                commande = new SqlCommand(requete, connexion);
                temp = commande.ExecuteScalar().ToString();
            }
            catch (SystemException exception)
            {
                if (exception.Message != "Object reference not set to an instance of an object.")
                {
                    MessageBox.Show("Erreur récuperation donnée scalaire.\r\n\r\n" + exception.Message, "Erreur load data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    return temp;
                }
            }
            finally
            {
                connexion.Close();
            }
            return temp;

        }

        public int insert(String tableCible, String donnees) 
        { // insertion dans la db
            try
            {
                int nbInsertions;
                /*
                 *  ARGUMENT "donnees" sans paranthèses mais séparées par une virgule comme l'exemple ci-dessous ET sans la colonne ID : 
                 *  exemple:  
                 *              nom + "','" + prenom + "','" + date.ToString() + "','" + mail + "','" + tel  
                 *              
                 *  Faites attention aux colonnes qui sont "not null" et celles qui contiennent la relation vers une autre table 
                */
                if (connexion.State == ConnectionState.Closed)
                { // nécessaire pour des inserts qui se suivent
                    connexion.Open();
                }

                // réunir les noms des colonnes cibles de la table concernée pour la requête finale
                String lesColonnesCibles = nomColonnes(tableCible);

                // créer la requête "insert"
                String query = "INSERT INTO dbo." + tableCible;
                query += " " + lesColonnesCibles + " ";
                query += "VALUES (" + donnees + ");";

                // exécuter la requête
                commande = new SqlCommand(query, connexion);
                nbInsertions = commande.ExecuteNonQuery();
                connexion.Close();

                return nbInsertions;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur \"INSERT\"-DB \r\n\r\n" + ex.Message, "Erreur load data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }

        public void delete(String tableCible, int id)
        { 
            /*
             * pour être sûre de supprimer la bonne ligne et uniquement celle concernée, j'utilise l'id comme info!
             * Il faut donc impérativement donner l'id en argument.
            */

            // créer la requête "delete"
            String query = "DELETE FROM dbo." + tableCible + " WHERE dbo." + tableCible + " = " + id + ";";

            // exécuter la requête
            commande = new SqlCommand(query, connexion);
            commande.ExecuteNonQuery();
            connexion.Close();
        }

        public void update(String tableCible, int id, String donnees)
        { // update dans la db
            // créer la requête "insert"
            String query = "UPDATE dbo." + tableCible;
            query += " SET " + donnees + " WHERE id = " + id;

            // exécuter la requête
            commande = new SqlCommand(query, connexion);
            commande.ExecuteNonQuery();
            connexion.Close();
        }

        public void filtreParNomParTel(ref DataGridView tableauCible, String nom, String telephone)
        { // filtre avec procédure stockée
            commande = new SqlCommand("PS_Filtre_Nom_Tel", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            commande.Parameters.Add("@nom", SqlDbType.NVarChar);
            commande.Parameters.Add("@tel", SqlDbType.NVarChar);

            commande.Parameters["@nom"].Direction = ParameterDirection.Input;
            commande.Parameters["@tel"].Direction = ParameterDirection.Input;

            commande.Parameters["@nom"].Value = nom;
            commande.Parameters["@tel"].Value = telephone;

            injectionDesDonnees(ref tableauCible);
        }

        public void filtreEleve(ref DataGridView tableauCible, String nom)
        { // filtre avec procédure stockée

            commande = new SqlCommand("PS_Filtre_Eleve", connexion);

            commande.CommandType = CommandType.StoredProcedure;

            commande.Parameters.Add("@nom", SqlDbType.NVarChar);

            commande.Parameters["@nom"].Direction = ParameterDirection.Input;

            commande.Parameters["@nom"].Value = nom;

            injectionDesDonnees(ref tableauCible);
        }     

        public void afficheEtablissement(string query, ref TextBox Dénomination, ref TextBox Num, ref TextBox Rue, ref TextBox Ville, ref TextBox Pays, ref TextBox Cp, ref TextBox Email, ref TextBox NumTel, ref TextBox NumFax, ref TextBox BanqueBe, ref TextBox BicBe, ref TextBox BanqueLu, ref TextBox BicLu, ref TextBox Tva, ref string path_img)
        { // affichage des données de l'établissement dans le Form
        // Ce code a été fait avant que l'objet établissement soit fait, le code est volontairement pas supprimé et le code n'est pas ré-orienté vers l'objet

            // commande = new SqlCommand(query, connexion);
            lecteurDeDonnees = injectDataToDataReader(query);

            Dénomination.Text = lecteurDeDonnees["nom_etablissement"].ToString();
            Num.Text = lecteurDeDonnees["numero"].ToString();
            Rue.Text = lecteurDeDonnees["rue"].ToString();
            Ville.Text = lecteurDeDonnees["ville"].ToString();
            Pays.Text = lecteurDeDonnees["pays"].ToString();
            Cp.Text = lecteurDeDonnees["code_postal"].ToString();
            Email.Text = lecteurDeDonnees["courriel"].ToString();
            NumTel.Text = lecteurDeDonnees["telephone"].ToString();
            NumFax.Text = lecteurDeDonnees["fax"].ToString();
            BanqueBe.Text = lecteurDeDonnees["banque_BE"].ToString();
            BicBe.Text = lecteurDeDonnees["bic_BE"].ToString();
            BanqueLu.Text = lecteurDeDonnees["banque_LU"].ToString();
            BicLu.Text = lecteurDeDonnees["bic_LU"].ToString();
            Tva.Text = lecteurDeDonnees["tva"].ToString();
            path_img = lecteurDeDonnees["logo_path"].ToString();

            // obligé de fermé la connexion a cette endroit sinon plus d'accès aux données
            connexion.Close();
        }

        public bool existEtablissement(string query)
        { // verifié si l'établisssment existe dans la db
            bool ligneExist = false;
            lecteurDeDonnees = injectDataToDataReader(query);
            ligneExist = lecteurDeDonnees.HasRows;
            connexion.Close();
            return ligneExist;
        }

        public int recupId(string query)
        { //recupere l'id d'une adresse
            // convertir l'id recu en string en int et retourner la valeur
            return Convert.ToInt16(recupDataScalar(query));
        }
    }
}
