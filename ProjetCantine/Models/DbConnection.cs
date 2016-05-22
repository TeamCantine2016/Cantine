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

        // REGROUPPEMENT DES REQUETTES
        private string requette(string selection) {

            string laRequette = null;

            switch (selection)
            {
                case "listeTuteur":
                    laRequette = "SELECT tbl_personne.id as CodeClient, nom as Famille, telephone as Téléphone, numero+' '+ rue as Adresse, ville as Ville, code_postal as CodePostal, pays as Pays, courriel as Email ";
                    laRequette += "FROM tbl_personne inner join tbl_type_personne on tbl_personne.type_personne_id = tbl_type_personne.id ";
                    laRequette += "inner join tbl_adresse on tbl_personne.adresse_id = tbl_adresse.id ";
                    break;
                case "listeEnfant":
                    laRequette = "SELECT nom as Nom, prenom as Prénom, DATEDIFF(year, date_naissance, SYSDATETIME()) as Age , date_naissance As DateNaissance";
                    laRequette += " FROM tbl_personne";
                    laRequette += " inner join tbl_type_personne on tbl_type_personne.id = tbl_personne.type_personne_id";
                    laRequette += " inner join tbl_relation_tuteur_enfant on tbl_relation_tuteur_enfant.enfant_id = tbl_personne.id";
                    break;
                default:
                    break;
            }

            return laRequette;
        }

        // INJECTION DES DONNEES
        private void injectionDesDonnees(ref DataGridView tableauCible)
        {
            lecteurDeDonnees = commande.ExecuteReader();
            tableDeDonnees.Load(lecteurDeDonnees);
            tableauCible.DataSource = tableDeDonnees;
            connexion.Close();
        }

        // LES METHODES
        public void afficheListeTuteurs(ref DataGridView tableauCible, ref TextBox nomDeRecherche, ref TextBox telephoneDeRecherche)
        {
            // requette pour l'affichage de la dataGridView_Famille
            String query = requette("listeTuteur");
            // spécification des critères
            query += "WHERE tbl_type_personne.type_personne = 'tuteur' and nom like '" + nomDeRecherche.Text + "%' and telephone like '" + telephoneDeRecherche.Text + "%'";

            // afectation de la vraible globale avec la requette concernée
            commande = new SqlCommand(query, connexion);
            // execution de la requette
            injectionDesDonnees(ref tableauCible);
        }

        public string afficheListeEnfantSelonSelection(ref DataGridView tableauCible, int code)
        {
            // requette pour l'affichage de la dataGridView_Membre
            String query = requette("listeEnfant");
            // spécification des critères
            query += " where type_personne = 'élève' and tuteur_id = '" + code + "'";

            // afectation de la vraible globale avec la requette concernée
            commande = new SqlCommand(query, connexion);
            // execution de la requette
            injectionDesDonnees(ref tableauCible);
            // renvoi le nombre de lignes du tableauCible
            return tableauCible.RowCount.ToString();
        }

    }
}
