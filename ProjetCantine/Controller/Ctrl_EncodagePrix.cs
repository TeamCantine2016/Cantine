using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetCantine.Models;

namespace ProjetCantine.Controller
{
    class Ctrl_EncodagePrix
    {

        public void InsertPrix(string table, string donnees, string repasId, string datedebut)
        {
            //On récupère l'id du dernier prix de ce repas type
            DbConnection DbTalk1 = new DbConnection();
            string lastId = DbTalk1.recupDataScalar("Select Max(id) from tbl_prix_repas where repas_id =" + repasId);
            //On actualise la date de fin de l'ancien prix de ce repas
            DbConnection DbTalk2 = new DbConnection();
            DbTalk2.update("tbl_prix_repas", Convert.ToInt16(lastId), "date_fin ='" + datedebut + "'");
            //On insère les données de prix du nouveau repas dans la table
            DbConnection DbTalk3 = new DbConnection();
            DbTalk3.insert(table, donnees);
        }


        public string ReqInsertPrix(String datedebut, String prix, String repasId, String datefin)
        {
            String donnees = "'" + prix + "','" + datedebut + "','" + datefin + "','" + repasId +"'";

            return donnees;


        }

    }
}
