using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetCantine.Models;

namespace ProjetCantine.Controller
{
    class Ctrl_EncodageRepas
    {

        DbConnection dbTalk = new DbConnection();
        public void filtreEleve(ref DataGridView tableauCible, String nom)
        {
            DbConnection dbTalk = new DbConnection();
            dbTalk.filtreEleve(ref tableauCible, nom);
        }

        public int insertData(string table, string query)
        {
            return dbTalk.insert(table, query);
        }
        public int update(string donnée, string table, int id)
        {
            dbTalk.update(table, id, donnée);
            return 1;
        }

        public string ReqInsertRepas(String dateRepas, String eleveId, String repasId)
        {
            String donnees = dateRepas + "','" + eleveId + "','" + repasId;

            return donnees;


        }

        public string ReqUpdateRepas(String dateRepas, String eleveId, String repasId)
        {
            String donnees = "date_repas = '" + dateRepas + "', personne_id = '" + eleveId + "', repas_id = '" + repasId + "'";               
            return donnees;


        }

        public int recupIdERepas(String dateRepas, String eleveId)
        {
            string query = dbTalk.getQuery("recupIdRepas");
            query  += " WHERE(date_repas = '" + dateRepas + "' AND personne_id = '" + eleveId + "')";
            return dbTalk.recupId(query);
        }

    }
}
