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
        // création de l'objet de communication avec la db
        DbConnection dbTalk = new DbConnection();

        public void filtreEleve(ref DataGridView tableauCible, String nom)
        { // filtre entre la dgv tuteur et enfant
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

        public string PeriodeDebut(int eleveId, string date,bool retourVide)
        {
            //On récupère l'id du dernier prix de ce repas type
            string periodeDebut;
            DbConnection DbTalk = new DbConnection();
            periodeDebut = DbTalk.recupDataScalarSiVide(
                "SELECT tbl_facture.debut_periode"
                + " FROM tbl_facture INNER JOIN"
                + " tbl_relation_facture ON tbl_facture.id = tbl_relation_facture.facture_id"
                + " WHERE(tbl_relation_facture.tuteur_id = (SELECT tbl_relation_tuteur_enfant.tuteur_id FROM tbl_relation_tuteur_enfant WHERE(tbl_relation_tuteur_enfant.enfant_id = " + eleveId + ")) and '" + date + "' between tbl_facture.debut_periode and tbl_facture.fin_periode )");
            if (periodeDebut == "")
            {
                if (retourVide)
                {
                    return "2000-01-01";
                }

                else{
                    periodeDebut = DbTalk.recupDataScalarSiVide(
                   "SELECT max(tbl_facture.debut_periode)"
                   + " FROM tbl_facture INNER JOIN"
                   + " tbl_relation_facture ON tbl_facture.id = tbl_relation_facture.facture_id"
                   + " WHERE(tbl_relation_facture.tuteur_id = (SELECT tbl_relation_tuteur_enfant.tuteur_id FROM tbl_relation_tuteur_enfant WHERE(tbl_relation_tuteur_enfant.enfant_id =" + eleveId + ")))");
                }
            }
            
                return periodeDebut;
        }

        public string PeriodeFin(int eleveId, string date, bool retourVide)
        {
            //On récupère l'id du dernier prix de ce repas type
            string periodeFin;
            DbConnection DbTalk = new DbConnection();
                periodeFin = DbTalk.recupDataScalarSiVide(
                "SELECT tbl_facture.fin_periode"
                + " FROM tbl_facture INNER JOIN"
                + " tbl_relation_facture ON tbl_facture.id = tbl_relation_facture.facture_id"
                + " WHERE(tbl_relation_facture.tuteur_id = (SELECT tbl_relation_tuteur_enfant.tuteur_id FROM tbl_relation_tuteur_enfant WHERE(tbl_relation_tuteur_enfant.enfant_id =" + eleveId + ")) and '" + date + "' between tbl_facture.debut_periode and tbl_facture.fin_periode )");

            if (periodeFin == "")
            {
                if (retourVide)
                {
                    return "2000-01-01";
                }
                else
                {
                    periodeFin = DbTalk.recupDataScalarSiVide(
                   "SELECT max(tbl_facture.fin_periode)"
                   + " FROM tbl_facture INNER JOIN"
                   + " tbl_relation_facture ON tbl_facture.id = tbl_relation_facture.facture_id"
                   + " WHERE(tbl_relation_facture.tuteur_id = (SELECT tbl_relation_tuteur_enfant.tuteur_id FROM tbl_relation_tuteur_enfant WHERE(tbl_relation_tuteur_enfant.enfant_id =" + eleveId + ")))");
                }
            }


            return periodeFin;
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
