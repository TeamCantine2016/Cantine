using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetCantine.Models;

namespace ProjetCantine.Controller
{
    class Ctrl_VisualisationFamille
    {
        DbConnection dbTalk = new DbConnection(); // variable globale

        public void afficheListeTuteurs(ref DataGridView tableauCible, ref TextBox nomDeRecherche, ref TextBox telephoneDeRecherche)
        {
            // récupérer la requête pour l'affichage de la dataGridView_Famille
            String query = dbTalk.getQuery("listeTuteurDansVisualFamille"); 

            // spécification des critères
            query += "WHERE tbl_type_personne.type_personne = 'tuteur' and nom like '" + nomDeRecherche.Text + "%' and telephone like '" + telephoneDeRecherche.Text + "%'";

            // injection des données dans la datagridview
            dbTalk.injectDataToDataGridView(query, ref tableauCible);

        }

        public string afficheListeEnfantSelonSelection(ref DataGridView tableauCible, int code)
        {
            // récupérer la requête pour l'affichage de la dataGridView_Membre
            String query = dbTalk.getQuery("listeEnfantDansVisualFamille");

            // spécification des critères
            query += " where type_personne = 'élève' and tuteur_id = '" + code + "'";

            // injection des données dans la datagridview
            dbTalk.injectDataToDataGridView(query, ref tableauCible);

            // renvoi le nombre de lignes du tableauCible
            return tableauCible.RowCount.ToString();
        }
    }
}
