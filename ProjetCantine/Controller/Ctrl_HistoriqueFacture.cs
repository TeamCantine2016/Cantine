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

        public void afficheHistorique(ref DataGridView dtg)
        {
            String query = dbTalk.getQuery("listeFacture");
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
