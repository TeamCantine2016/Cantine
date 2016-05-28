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
        public void filtreParNomParTel(ref DataGridView tableauCible, String nom, String telephone)
        {
            DbConnection dbTalk = new DbConnection();
            dbTalk.filtreParNomParTel(ref tableauCible, nom, telephone);
        }

        public void afficheListeEnfantSelonSelection(ref DataGridView tableauCible, ref DataGridView tableauSource, int index)
        {
            DbConnection dbTalk = new DbConnection();
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

            // injection des données dans la datagridview
            dbTalk.injectDataToDataGridView(query, ref tableauCible);
        }

        public String get_DateCloture(ref DataGridView tableauSource, int index)
        {
            DbConnection dbTalk = new DbConnection();
            // ligne du datagridview courant
            DataGridViewRow ligne = tableauSource.Rows[index];

            // requête pour la dernière date de clôture
            String query = dbTalk.getQuery("dateCloture");
            // spécification des critères
            query += "WHERE(tbl_relation_facture.tuteur_id = " + ligne.Cells[0].Value.ToString() + ")";

            // récupérer et afficher la dernière date de clôture
            try
            {
                return dbTalk.get_date(query).ToString().Substring(0, 10);
            }
            catch (Exception)
            {
                MessageBox.Show(" La dernière facture pour ce tuteur \r\n n'a pas encore été générée");
                return "> Aucune facture existante.";
            }
        }






    }
}
