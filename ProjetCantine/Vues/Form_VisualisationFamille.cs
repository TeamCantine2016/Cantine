using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCantine
{
    public partial class Form_VisualisationFamille : Form
    {
        public Form_VisualisationFamille()
        {
            InitializeComponent();           

        }
        private void Form_VisualisationFamille_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'db_cantineDataSet.TA_Liste_Familles'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.tA_Liste_FamillesTableAdapter.Fill_Famille(this.db_cantineDataSet.TA_Liste_Familles);
          
        }

        private void dataGridView_Famille_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = dataGridView_Famille.CurrentRow.Index;
            DataGridViewRow ligne = dataGridView_Famille.Rows[id];
            textBox_Nom.Text = ligne.Cells[0].Value.ToString();
            textBox_Téléphone.Text = ligne.Cells[1].Value.ToString();
            textBox_Adresse.Text =  ligne.Cells[2].Value.ToString() + ", " +  ligne.Cells[3].Value.ToString()+ ", " + ligne.Cells[5].Value.ToString().Substring(0,1) + "-" + ligne.Cells[4].Value.ToString();
            textBox_Email.Text = ligne.Cells[6].Value.ToString();
        }

      
    }
}
