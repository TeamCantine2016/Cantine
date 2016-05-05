using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProjetCantine.Models;
using ProjetCantine.DbAccess;

namespace ProjetCantine.Vues
{
    public partial class Form_EncodageRepas : Form
    {
        public Form_EncodageRepas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_Email_Click(object sender, EventArgs e)
        {

        }

        private void label_Adresse_Click(object sender, EventArgs e)
        {
  
        }

        private void Form_EncodageRepas_Load(object sender, EventArgs e)
        {
            // requête du dataset pour remplir le datagridview
            this.tA_F_EncodageRepas_query.Fill(this.db_cantineDataSet.TA_F_EncodageRepas);
            // pour adapter la largeur de colonnes
            dGdVw_DetailEleve.AutoResizeColumns();
            // pour élargir la dernière colonne horizontalement pour ne pas avoir une zone grise
            dGdVw_DetailEleve.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void tAFEncodageRepasBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
