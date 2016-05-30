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
            return dbTalk.recupId(query);
        }

        public string constrRequeteEtablissement(String Dénomination, String Email, String NumTel, String NumFax, String BanqueBe, String BicBe, String BanqueLu, String BicLu, String Tva, String path_img)
        {

            // parametrer les valeur a mettre a jour pour l'update etablissement
            String donnée = "nom_etablissement = '" + Dénomination + "',telephone = '" + NumTel + "',fax = '" + NumFax + "',courriel = '" + Email + "',tva = '" + Tva;
            donnée += "',banque_BE = '" + BanqueBe + "',bic_BE = '" + BicBe + "',banque_LU = '" + BanqueLu + "',bic_LU = '" + BicLu + "',logo_path = '" + path_img + "'";

            return donnée;


        }

        public string constrRequeteAdresse(String Num, String Rue, String Ville, String Pays, String Cp)
        {
            // parametrer les valeur a mettre a jour pour l'update adresse
            string donnée = "pays = '" + Pays + "',ville = '" + Ville + "',code_postal = '" + Cp + "',rue = '" + Rue + "',numero = '" + Num + "'";

            return donnée;
        }

        // recupere l'id de l'etablissement
        public int recupIdEtablissement()
        {
            string query = dbTalk.getQuery("recupIdEtablissement");
            return dbTalk.recupId(query);
        }

        //recupere l'adresse_id dans la table etablissement pour pouvoir aller mettre a jour l'adresse
        public int recupAdresseId()
        {
            string query = dbTalk.getQuery("recupAdresseId");
            return dbTalk.recupId(query);
        }

        // update de l'etablissement et de l'adresse  --> utilisation de 2x cette methode
        public void update(string donnée, string table, int id)
        {
            dbTalk.update(table, id, donnée);
        }

    }
}
