using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

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
                case "recupIdRepas":
                    laRequete = "SELECT id FROM tbl_relation_repas";
                   
                    break;
                case "recupAdresseId":
                    laRequete = "SELECT adresse_id FROM tbl_etablissement";
                    break;
                default:
                    return null;
            }

            return laRequete;
        }

// LES METHODES PUBLIQUES

// Récupérer la requête choisie
        public String getQuery(String selection)
        {
            String selectionResult = requete(selection);
            if (selectionResult == null)
            {
                MessageBox.Show("Get no Query in DB class !!", "Query-error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return selectionResult;
        }

// INJECTION DES DONNEES

        public void injectDataToDataGridView(String requete, ref DataGridView dataGridCible)
        {
            // affectation de la variable globale avec la requête reçue
            commande = new SqlCommand(requete, connexion);
            // execution de la requête
            injectionDesDonnees(ref dataGridCible);
        }

        public DateTime get_date(String requete)
        {
            DateTime dateCloture;
            DateTime.TryParse("01/01/1970", out dateCloture);
            // affectation de la variable globale avec la requête reçue
            commande = new SqlCommand(requete, connexion);
            // execution de la requete
            
            lecteurDeDonnees = commande.ExecuteReader();
            while (lecteurDeDonnees.Read())
            {
                DateTime.TryParse(lecteurDeDonnees["fin_periode"].ToString().Substring(0,10), out dateCloture);
            }
            lecteurDeDonnees.Close();
            
            return dateCloture;
        }

        private void injectionDesDonnees(ref DataGridView tableauCible)
        {
            try
            {
                lecteurDeDonnees = commande.ExecuteReader();
                tableDeDonnees.Load(lecteurDeDonnees);
                tableauCible.DataSource = tableDeDonnees;
                
                // pour récupérer l'id de l'enfant lors de l'encodage facture uniquement
            }
            catch (SystemException exception)
            {
                MessageBox.Show("Erreur injection DB>DataGridView.\r\n\r\n" + exception.Message, "Load data", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

// recuperer des donnéee d'une requete dans une data reader
        public SqlDataReader injectDataToDataReader(String requete)
        {
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


// recuperer une seule donnée d'une requete
        public string recupDataScalar(string requete)
        {
            String temp = "";
            try
            {
                commande = new SqlCommand(requete, connexion);
                temp = commande.ExecuteScalar().ToString();
            }
            catch (SystemException exception)
            {
                MessageBox.Show("Erreur récuperation donnée scalaire.\r\n\r\n" + exception.Message, "Erreur load data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connexion.Close();
            }
            return temp;

        }

        //****** INSERT

        public int insert(String tableCible, String donnees) 
        {
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
                query += lesColonnesCibles + " ";
                query += "VALUES ('" + donnees + "');";

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

//****** DELETE
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

//****** UPDATE
        public void update(String tableCible, int id, String donnees)
        {
            // créer la requête "insert"
            String query = "UPDATE dbo." + tableCible;
            query += " SET " + donnees + " WHERE id = " + id;

            // exécuter la requête
            commande = new SqlCommand(query, connexion);
            commande.ExecuteNonQuery();
            connexion.Close();
        }

//****** AVEC PROCEDURE STOCKEE
        public void filtreParNomParTel(ref DataGridView tableauCible, String nom, String telephone)
        {
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
        {

            commande = new SqlCommand("PS_Filtre_Eleve", connexion);

            commande.CommandType = CommandType.StoredProcedure;

            commande.Parameters.Add("@nom", SqlDbType.NVarChar);

            commande.Parameters["@nom"].Direction = ParameterDirection.Input;

            commande.Parameters["@nom"].Value = nom;

            injectionDesDonnees(ref tableauCible);

        }

        // FONCTIONS PRIVEES INTERMEDIAIRES
        private string nomColonnes(String table) // réuni les noms des colonnes d'une table dans un "string"
        {
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

//******** Assigner a chaque texteBox la valeur de la Db -> pas de dgv utilisée 

        public void afficheEtablissement(string query, ref TextBox Dénomination, ref TextBox Num, ref TextBox Rue, ref TextBox Ville, ref TextBox Pays, ref TextBox Cp, ref TextBox Email, ref TextBox NumTel, ref TextBox NumFax, ref TextBox BanqueBe, ref TextBox BicBe, ref TextBox BanqueLu, ref TextBox BicLu, ref TextBox Tva, ref string path_img)
        {

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

// verifié si l'établisssment existe dans la db
        public bool existEtablissement(string query)
        {
            bool ligneExist = false;
            lecteurDeDonnees = injectDataToDataReader(query);
            ligneExist = lecteurDeDonnees.HasRows;
            connexion.Close();
            return ligneExist;
        }

//recupere l'id d'une adresse
        public int recupId(string query)
        {
            // convertir l'id recu en string en int et retourner la valeur
            return Convert.ToInt16(recupDataScalar(query));
        }
    }
}
