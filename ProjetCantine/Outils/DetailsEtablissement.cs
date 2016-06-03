using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetCantine.Models;

namespace ProjetCantine.Outils
{
    class DetailsEtablissement
    {
        //attributs de l'établissement
        String nom;
        String numEtRue;
        String cpEtVille;
        String tel;
        String fax;
        String courriel;
        String banque_BE;
        String bic_BE;
        String banque_LU;
        String bic_LU;
        String pays;

        public DetailsEtablissement()
        {
            // récupérations des données de l'établissement dans la db dé la création de l'objet
            DbConnection dbTalk = new DbConnection();
            String id_adresse = "";

            nom = dbTalk.recupDataScalar("SELECT nom_etablissement From tbl_etablissement;");
            id_adresse = dbTalk.recupDataScalar("SELECT adresse_id From tbl_etablissement;");
            numEtRue = dbTalk.recupDataScalar("SELECT CONCAT(numero, ', ', rue) FROM tbl_adresse WHERE id = " + id_adresse);
            cpEtVille = dbTalk.recupDataScalar("SELECT CONCAT(code_postal, ' ', ville) FROM tbl_adresse WHERE id = " + id_adresse);
            pays = dbTalk.recupDataScalar("SELECT pays FROM tbl_adresse WHERE id = " + id_adresse);
            tel = dbTalk.recupDataScalar("SELECT telephone From tbl_etablissement;");
            fax = dbTalk.recupDataScalar("SELECT fax From tbl_etablissement;");
            courriel = dbTalk.recupDataScalar("SELECT courriel From tbl_etablissement;");
            banque_BE = dbTalk.recupDataScalar("SELECT banque_BE From tbl_etablissement;");
            banque_LU = dbTalk.recupDataScalar("SELECT banque_LU From tbl_etablissement;");
            bic_BE = dbTalk.recupDataScalar("SELECT bic_BE From tbl_etablissement;");
            bic_LU = dbTalk.recupDataScalar("SELECT bic_LU From tbl_etablissement;");

        }

        // les "getters" de l'établissement
        public String get_nom() { return nom; }
        public String get_numEtRue() { return numEtRue; }
        public String get_cpEtVille() { return cpEtVille; }
        public String get_pays() { return pays; }
        public String get_tel() { return tel; }
        public String get_fax() { return fax; }
        public String get_courriel() { return courriel; }
        public String get_banque_BE() { return banque_BE; }
        public String get_banque_LU() { return banque_LU; }
        public String get_bic_BE() { return bic_BE; }
        public String get_bic_LU() { return bic_LU; }

    }
}
