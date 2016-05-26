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
        public void afficheListeTuteurs(ref DataGridView tableauCible, ref TextBox nomDeRecherche, ref TextBox telephoneDeRecherche)
        {
            // crééer objet de communication avec la classe DB qui communique avec la DB
            DbConnection dbTalk = new DbConnection();

            // récupérer la requête pour l'affichage de la dataGridView_Famille
            String query = dbTalk.getQuery("listeTuteurDansVisualFamille"); 

            // spécification des critères
            query += "WHERE tbl_type_personne.type_personne = 'tuteur' and nom like '" + nomDeRecherche.Text + "%' and telephone like '" + telephoneDeRecherche.Text + "%'";

            // injection des données dans la datagridview
            dbTalk.injectDataToDataGridView(query, ref tableauCible);

        }
    }
}
