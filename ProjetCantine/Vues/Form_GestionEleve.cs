using ProjetCantine.Models;
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

namespace ProjetCantine
{
    public partial class Form_GestionEleve : Form
    {
        public Form_GestionEleve()
        {
            InitializeComponent();
        }
        int flag;
        Form_EncodageElève Form_EncodageEleve;
        SqlConnection maCon = new SqlConnection(DbConnection.connectionString);

        private void button_Nouveau_Click(object sender, EventArgs e)
        {
            flag = 0;
            Form_EncodageEleve = new Form_EncodageElève(flag);
            Form_EncodageEleve.ShowDialog();
          
        }

        private void button_Editer_Click(object sender, EventArgs e)
        {
            flag = 1;
            Form_EncodageEleve = new Form_EncodageElève(flag);
            Form_EncodageEleve.ShowDialog();
        }

        private void Form_GestionEleve_Load(object sender, EventArgs e)
        {
            /* // requête du dataset pour remplir le datagridview
             this.tA_Listes_Personnes_query.Fill_Eleves(this.db_cantineDataSet.TA_Listes_Personnes);
             // pour adapter la largeur de colonnes
             dataGridView_Eleve.AutoResizeColumns();
             // pour élargir la dernière colonne horizontalement pour ne pas avoir une zone grise
             dataGridView_Eleve.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
             */

            String query = "Select nom as Nom, prenom as Prénom, rue as Adresse, ville as Ville, pays as Pays from tbl_personne ";
            query += "inner join tbl_adresse on tbl_adresse.id = tbl_personne.adresse_id where tbl_personne.type_personne_id = 1;";
            maCon.Open();

            SqlCommand maCommand = new SqlCommand(query, maCon);
            SqlDataReader dr = maCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Eleve.DataSource = dt;

            maCon.Close();


        }
    }
}
