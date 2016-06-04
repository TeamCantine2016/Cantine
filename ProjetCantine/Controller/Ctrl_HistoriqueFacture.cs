using ProjetCantine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCantine.Controller
{
    class Ctrl_HistoriqueFacture
    {
        DbConnection dbTalk = new DbConnection();

        public void afficheHistorique(ref DataGridView dtg, string typeDEnvoie, string typePayement, string date_Début, string date_Fin, bool avecDate, string nom)
        {

            String query = dbTalk.getQuery("listeFacture");

            query += " Where nom like '" + nom + "%'";

            if (typeDEnvoie != "Tous")
            {

                switch (typeDEnvoie)
                {
                    case "Envoyer":
                        query += " and statut_envoye = '1'";
                        break;
                    case "PasEnvoyer":
                        query += " and statut_envoye = '0'";
                        break;
                    case "Tous":
                        // je le met comme sa, si il y a un autre condition derrière sa ne pose pas de problème avec le "and"
                        //query += " where statut_envoye = '0' or statut_envoye = '1'";
                        break;
                }
            }

            if (typePayement != "Tous")
            {
                switch (typePayement)
                {
                    case "Payer":
                        query += " and statut_payement = '1'";
                        break;
                    case "PasPayer":
                        query += " and statut_payement = '0'";
                        break;
                    case "Tous":
                        // je le met comme sa, si il y a un autre condition derrière sa ne pose pas de problème avec le "and"
                        // query += " and statut_payement = '0' or statut_payement = '1'";
                        break;
                }
            }

            if (avecDate == true)
            {
                query += "and fin_periode >= '" + date_Début + "' and fin_periode <= '" + date_Fin + "'";

            }







            dbTalk.injectDataToDataGridView(query, ref dtg);

        }

        public string constrRequete(String path)
        {
            // paramettrer la requete en donnant l'argument
            String donnée = "archive = '" + path + "'";

            return donnée;
        }

        public string pathfacture(int id)
        {
            String query = dbTalk.getQuery("pathFacture");
            query += " WHERE id = " + id;
            return dbTalk.recupDataScalar(query);
        }

        public void update(string donnée, string table, int id)
        {
            dbTalk.update(table, id, donnée);
        }
    }
}
