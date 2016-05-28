using ProjetCantine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCantine
{
    class Ctrl_GestionEtablissement
    {
        DbConnection dbTalk = new DbConnection();

        public void afficheEtablissement(ref TextBox Dénomination, ref TextBox Num, ref TextBox Rue, ref TextBox Ville, ref TextBox Pays, ref TextBox Cp, ref TextBox Email, ref TextBox NumTel, ref TextBox NumFax, ref TextBox BanqueBe, ref TextBox BicBe, ref TextBox BanqueLu, ref TextBox BicLu, ref TextBox Tva, ref string path_img)
        {
            // récupérer la requête pour l'affichage des textbox de la form_gestionEtablissement
            String query = dbTalk.getQuery("AffichageEtablissement");

            dbTalk.afficheEtablissement(query, ref Dénomination, ref Num, ref Rue, ref Ville, ref Pays, ref Cp, ref Email, ref NumTel, ref NumFax, ref BanqueBe, ref BicBe, ref BanqueLu, ref BicLu, ref Tva, ref path_img);

        }

        public bool verifExistEtablissement()
        {
            // récupérer la requête pour l'affichage des textbox de la form_gestionEtablissement
            String query = dbTalk.getQuery("AffichageEtablissement");

            // retourne la valeur si la db comptient une ligne
            return dbTalk.existEtablissement(query);
        }

        public int insertData(string table, string query)
        {
            return dbTalk.insert(table, query);
        }

        public int recupId(string rue, string numero)
        {
            String query = dbTalk.getQuery("recupIdAdresse");
            query += " where rue = '" + rue + "' and numero = '" + numero + "'";

            //retourne l'id de l'adresse
            return dbTalk.idAdresse(query);
        }

    }
}
