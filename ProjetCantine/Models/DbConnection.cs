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
                case "listeTuteur":
                    laRequete = "SELECT tbl_personne.id as CodeClient, nom as Famille, telephone as Téléphone, numero+' '+ rue as Adresse, ville as Ville, code_postal as CodePostal, pays as Pays, courriel as Email ";
                    laRequete += "FROM tbl_personne inner join tbl_type_personne on tbl_personne.type_personne_id = tbl_type_personne.id ";
                    laRequete += "inner join tbl_adresse on tbl_personne.adresse_id = tbl_adresse.id ";
                    break;
                case "listeEnfant":
                    laRequete = "SELECT nom as Nom, prenom as Prénom, DATEDIFF(year, date_naissance, SYSDATETIME()) as Age , date_naissance As DateNaissance";
                    laRequete += " FROM tbl_personne";
                    laRequete += " inner join tbl_type_personne on tbl_type_personne.id = tbl_personne.type_personne_id";
                    laRequete += " inner join tbl_relation_tuteur_enfant on tbl_relation_tuteur_enfant.enfant_id = tbl_personne.id";
                    break;
                default:
                    break;
            }

            return laRequete;
        }

        //// REGROUPPEMENT DES PROCEDURES STOCKEES
        //private SqlCommand procedure(string nomProcedure)
        //{
        //    switch (nomProcedure)
        //    {
        //        case "PS_Filtre_Nom_Tel":
        //            commande = new SqlCommand(nomProcedure, connexion);
                    
        //            break;
        //        default:
        //            break;
        //    }

        //    return commande;
        //}



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
            String query = requete("listeTuteur");
            // spécification des critères
            query += "WHERE tbl_type_personne.type_personne = 'tuteur' and nom like '" + nomDeRecherche.Text + "%' and telephone like '" + telephoneDeRecherche.Text + "%'";

            // afectation de la vraible globale avec la requête concernée
            commande = new SqlCommand(query, connexion);
            // execution de la requête
            injectionDesDonnees(ref tableauCible);
        }

        public string afficheListeEnfantSelonSelection(ref DataGridView tableauCible, int code)
        {
            // requête pour l'affichage de la dataGridView_Membre
            String query = requete("listeEnfant");
            // spécification des critères
            query += " where type_personne = 'élève' and tuteur_id = '" + code + "'";

            // afectation de la vraible globale avec la requête concernée
            commande = new SqlCommand(query, connexion);
            // execution de la requête
            injectionDesDonnees(ref tableauCible);
            // renvoi le nombre de lignes du tableauCible
            return tableauCible.RowCount.ToString();
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
