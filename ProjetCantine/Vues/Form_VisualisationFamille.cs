using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetCantine.Models;

namespace ProjetCantine
{
    public partial class Form_VisualisationFamille : Form
    {
        public Form_VisualisationFamille()
        {
            InitializeComponent();           

        }
        SqlConnection maCon = new SqlConnection(DbConnection.connectionString);
        private void Form_VisualisationFamille_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'db_cantineDataSet.TA_Liste_Familles'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            // this.tA_Liste_FamillesTableAdapter.Fill_Famille(this.db_cantineDataSet.TA_Liste_Familles);

            String query = "SELECT nom as Famille, telephone as Téléphone, numero+' '+ rue as Adresse, ville as Ville,code_postal as CodePostal, pays as Pays, courriel as Email FROM tbl_personne inner join tbl_type_personne on tbl_personne.type_personne_id = tbl_type_personne.id inner join tbl_adresse on tbl_personne.adresse_id = tbl_adresse.id WHERE tbl_type_personne.type_personne = 'tuteur' and nom like '" + textBox_NomRech.Text + "%' and telephone like '" + textBox_TéléphoneRech.Text + "%'";

            maCon.Open();

            SqlCommand maCommand = new SqlCommand(query, maCon);
            SqlDataReader dr = maCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Famille.DataSource = dt;

            maCon.Close();
            

        }
               
        private void dataGridView_Famille_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          
           int id = dataGridView_Famille.CurrentRow.Index;
            DataGridViewRow ligne = dataGridView_Famille.Rows[id];
            textBox_Nom.Text = ligne.Cells[0].Value.ToString();
            textBox_Téléphone.Text = ligne.Cells[1].Value.ToString();
            textBox_Adresse.Text = ligne.Cells[2].Value.ToString() + ", " + ligne.Cells[3].Value.ToString() + ", " + ligne.Cells[5].Value.ToString().Substring(0, 1) + "-" + ligne.Cells[4].Value.ToString();
            textBox_Email.Text = ligne.Cells[6].Value.ToString();
        }

       
       
    }
}
