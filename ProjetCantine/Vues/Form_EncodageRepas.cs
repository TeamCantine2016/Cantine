using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetCantine.Models;
using System.Data.SqlClient;


namespace ProjetCantine.Vues
{
    public partial class Form_EncodageRepas : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        db_cantineDataSet ds = new db_cantineDataSet();
        SqlConnection con = new SqlConnection(DbConnection.connectionString);
        public Form_EncodageRepas()
        {
            InitializeComponent();
        }
        public void filtre()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("PS_Filtre_Nom_Tel", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@nom", SqlDbType.NVarChar);
            cmd.Parameters.Add("@tel", SqlDbType.NVarChar);

            cmd.Parameters["@nom"].Direction = ParameterDirection.Input;
            cmd.Parameters["@tel"].Direction = ParameterDirection.Input;

            cmd.Parameters["@nom"].Value = txtBx_RechNom.Text;
            cmd.Parameters["@tel"].Value = txtBx_RechNumTel.Text;

            DataTable t = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            t.Load(dr);
            con.Close();

            dGdVw_DetailEleve.DataSource = t;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filtre();
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
            this.tA_Listes_Personnes_query.Fill_Eleves(this.db_cantineDataSet.TA_Listes_Personnes);
            // pour adapter la largeur de colonnes
            dGdVw_DetailEleve.AutoResizeColumns();
            // pour élargir la dernière colonne horizontalement pour ne pas avoir une zone grise
            dGdVw_DetailEleve.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void tAFEncodageRepasBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btApercu_Click(object sender, EventArgs e)
        {

        }

        private void tAListesPersonnesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label_RechID_Click(object sender, EventArgs e)
        {

        }
    }
}
