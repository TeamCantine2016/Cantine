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
            connexion = new SqlConnection(connectionString);
            connexion.Open();
            tableDeDonnees = new DataTable();
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
                    break;
            }

            return laRequete;
        }

        // INJECTION DES DONNEES
        private void injectionDesDonnees(ref DataGridView tableauCible)
        {
            lecteurDeDonnees = commande.ExecuteReader();
            tableDeDonnees.Load(lecteurDeDonnees);
            tableauCible.DataSource = tableDeDonnees;
            connexion.Close();
        }

        // LES METHODES PUBLIQUES

//****** SANS PROCEDURE STOCKEE
        public void afficheListeTuteurs(ref DataGridView tableauCible, ref TextBox nomDeRecherche, ref TextBox telephoneDeRecherche)
        {
            // requête pour l'affichage de la dataGridView_Famille
            String query = requete("listeTuteurDansVisualFamille");
            // spécification des critères
            query += "WHERE tbl_type_personne.type_personne = 'tuteur' and nom like '" + nomDeRecherche.Text + "%' and telephone like '" + telephoneDeRecherche.Text + "%'";

            // affectation de la variable globale avec la requête concernée
            commande = new SqlCommand(query, connexion);
            // execution de la requête
            injectionDesDonnees(ref tableauCible);
        }

        public string afficheListeEnfantSelonSelection(ref DataGridView tableauCible, int code)
        {
            // requête pour l'affichage de la dataGridView_Membre
            String query = requete("listeEnfantDansVisualFamille");
            // spécification des critères
            query += " where type_personne = 'élève' and tuteur_id = '" + code + "'";

            // affectation de la variable globale avec la requête concernée
            commande = new SqlCommand(query, connexion);
            // execution de la requête
            injectionDesDonnees(ref tableauCible);
            // renvoi le nombre de lignes du tableauCible
            return tableauCible.RowCount.ToString();
        }

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
