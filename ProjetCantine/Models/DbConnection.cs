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
        private string requete(string selection) {

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
                    laRequete += "Enfant AS( SELECT prenom, nom, date_naissance, tbl_personne.id FROM tbl_relation_tuteur_enfant ";
                    laRequete += "INNER JOIN tbl_personne ON tbl_relation_tuteur_enfant.enfant_id= tbl_personne.id) ";
                    break;
                case "listeEnfantSelonTuteur_Facture":
                    laRequete += "SELECT DISTINCT Enfant.nom AS 'Nom', Enfant.prenom AS 'Prénom', Enfant.date_naissance AS 'Date de Naissance' ";
                    laRequete += "FROM Tuteur, Enfant, tbl_relation_tuteur_enfant ";
                    laRequete += "WHERE Tuteur.id = tbl_relation_tuteur_enfant.tuteur_id AND tbl_relation_tuteur_enfant.enfant_id = Enfant.id";
                    break;
                default:
                    return null;
            }

            return laRequete;
        }

        // INJECTION DES DONNEES
        private void injectionDesDonnees(ref DataGridView tableauCible)
        {
            try
            {
                lecteurDeDonnees = commande.ExecuteReader();
                tableDeDonnees.Load(lecteurDeDonnees);
                tableauCible.DataSource = tableDeDonnees;
                connexion.Close();
            }
            catch (SystemException exception)
            {
                MessageBox.Show("1. Erreur injection DB>DataGridView.\r\n ou \r\n2. Erreur fermeture connexion DB.\r\n\r\n" + exception.Message, "Erreur load data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // LES METHODES PUBLIQUES

        //****** INSERT - DELETE - UPDATE

        public void insert(String tableCible, String donnees) 
        {
            /*
             *  ARGUMENT "donnees" sans paranthèses mais séparées par une virgule comme l'exemple ci-dessous ET sans la colonne ID : 
             *  exemple:  
             *              'Marco','Lechef','19590612','lechef@gmail.com',86473563,3,1 
             *              
             *  Faites attention aux colonnes qui sont "not null" et celles qui contiennent la relation vers une autre table 
            */

            // réunir les noms des colonnes cibles de la table concernée pour la requête finale
            String lesColonnesCibles = nomColonnes(tableCible);

            // créer la requête "insert"
            String query = "INSERT INTO dbo." + tableCible;
            query += lesColonnesCibles + " ";
            query += "VALUES (" + donnees + ");";

            // exécuter la requête
            commande = new SqlCommand(query, connexion);
            commande.ExecuteNonQuery();
            connexion.Close();
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

        public void update()
        {
            // je ferai cette méthode plus tard, je dois vérifier quelques détails au niveau du code
        }

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

        public void injectDataToDataGridView(String requete, ref DataGridView dataGridCible)
        {
            // affectation de la variable globale avec la requête reçue
            commande = new SqlCommand(requete, connexion);
            // execution de la requête
            injectionDesDonnees(ref dataGridCible);
        }


        //****** SANS PROCEDURE STOCKEE


        public void afficheListeEnfantSelonSelection_Factures(ref DataGridView tableauCible, ref DataGridView tableauSource, int index)
        {
            // ligne du datagridview courant
            DataGridViewRow ligne = tableauSource.Rows[index];

            // requête pour l'affichage de la dataGridView_Membre
            String query = requete("listeIntermediaire_Tuteur");
            // spécification des critères pour la liste/tableau intermédiaire
            query += " Where tbl_personne.nom = '" + ligne.Cells[1].Value.ToString() + "' ), ";
            query += requete("listeIntermediaire_Enfant");
            // requête utilisant les deux listes/tableaux intermédiaires pour en synthétiser la liste des enfants du tuteur sélectionné
            query += requete("listeEnfantSelonTuteur_Facture");

            // affectation de la variable globale avec la requête concernée
            commande = new SqlCommand(query, connexion);
            // execution de la requête
            injectionDesDonnees(ref tableauCible);
        }

//****** AVEC PROCEDURE STOCKEE
        public void filtreParNomParTel(ref DataGridView tableauCible, ref TextBox nom, ref TextBox telephone)
        {
            commande = new SqlCommand("PS_Filtre_Nom_Tel", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            commande.Parameters.Add("@nom", SqlDbType.NVarChar);
            commande.Parameters.Add("@tel", SqlDbType.NVarChar);

            commande.Parameters["@nom"].Direction = ParameterDirection.Input;
            commande.Parameters["@tel"].Direction = ParameterDirection.Input;

            commande.Parameters["@nom"].Value = nom.Text;
            commande.Parameters["@tel"].Value = telephone.Text;

            injectionDesDonnees(ref tableauCible);
        }
    }
}
