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

        DbConnection DbTalk = new DbConnection();

        public void InsertPrix(string table, string query)
        {
            DbTalk.insert(table, query);
        }
        public string ReqInsertPrix(String datedebut, String prix, String repasId, String datefin)
        {
            String donnees = prix  + "','" + datedebut + "','"+ datefin +"','" + repasId;

            return donnees;


        }

    }
}
