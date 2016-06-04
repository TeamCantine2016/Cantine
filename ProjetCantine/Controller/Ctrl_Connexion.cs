using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetCantine.Models;
using System.Data.SqlClient;
using System.Data;
namespace ProjetCantine.Controller
{
    class Ctrl_Connexion
    {
        DbConnection dbTalk = new DbConnection();
        SqlConnection con_log = new SqlConnection(DbConnection.connectionString);
        SqlCommand cmd_log = new SqlCommand();

        public string tentative_login(string login, string password, DataTable table)  
        {
            try
            {
                if (login.Length == 0 || password.Length == 0) // si une des 2 cases est vide
                {
                    return "Toutes les cases n'ont pas été remplies";
                }
                else
                {
                    // ouverture connexion, requete sql et DataReader
                    try
                    {
                        con_log.Open();
                        string requete = "SELECT * FROM tbl_utilisateur INNER JOIN tbl_personne ON tbl_utilisateur.personne_id = tbl_personne.id  WHERE pseudo = '" + login + "' AND mdp = '" + password + "'";
                        SqlDataAdapter dataA = new SqlDataAdapter(requete, con_log);
                        dataA.Fill(table);
                        con_log.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur de connexion à la base de données", "Connexion impossible", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        MessageBox.Show(ex.ToString(), "Description erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (table.Rows.Count != 0) // contient une rangée uniquement si il y a une correspondance entre login & base de données
                    {

                        if (table.Rows[0]["etat"].ToString() == "True")  // si état = 1 alors le compte est actif, sinon c'est qu'il est désactivé
                        {
                            return "ok";
                        }
                        else
                        {
                            return "Ce compte est désactivé";
                        }
                    }
                    else
                    {
                        return "Identifiant et/ou password non valide";
                    }
                }
            }
            finally
            {
                con_log.Close();
            }
        }
    }
}
