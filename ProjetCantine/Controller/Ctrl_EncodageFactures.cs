using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetCantine.Models;

namespace ProjetCantine.Controller
{
    class Ctrl_EncodageFactures
    {
        DbConnection dbTalk = new DbConnection(); // variable globale

        public void filtreParNomParTel(ref DataGridView tableauCible, ref TextBox nom, ref TextBox telephone)
        {
            dbTalk.filtreParNomParTel(ref tableauCible, ref nom, ref telephone);
        }

        public void afficheListeEnfantSelonSelection(ref DataGridView tableauCible, ref DataGridView tableauSource, int index)
        {
            // ligne du datagridview courant
            DataGridViewRow ligne = tableauSource.Rows[index];

            // requête pour l'affichage de la dataGridView_Membre
            String query = dbTalk.getQuery("listeIntermediaire_Tuteur");
            // spécification des critères pour la liste/tableau intermédiaire tuteur
            query += " Where tbl_personne.nom = '" + ligne.Cells[1].Value.ToString() + "' ), ";
            // ajout de la liste/tableau intermédiaire enfant
            query += dbTalk.getQuery("listeIntermediaire_Enfant");
            // requête utilisant les deux listes/tableaux intermédiaires pour en synthétiser la liste des enfants du tuteur sélectionné
            query += dbTalk.getQuery("listeEnfantSelonTuteur_Facture");

            // inhection des données dans la datagridview
            dbTalk.injectDataToDataGridView(query, ref tableauCible);
        }

    }
}
