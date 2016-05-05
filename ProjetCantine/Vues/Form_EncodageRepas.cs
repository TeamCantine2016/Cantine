using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProjetCantine.Models;
using ProjetCantine.DbAccess;

namespace ProjetCantine.Vues
{
    public partial class Form_EncodageRepas : Form
    {
        //SqlCommand cmd = new SqlCommand();
        //SqlDataAdapter da = new SqlDataAdapter();
        //cantineDataSet ds = new cantineDataSet();

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
            //cmd.Connection = DbConnection.getConnection(); 
            //cmd.CommandText = "SELECT tbl_personne.id, Prenom, nom, date_naissance, rue, numero, ville, code_postal, pays FROM tbl_personne INNER JOIN tbl_type_personne ON tbl_type_personne.id = tbl_personne.type_personne_id INNER JOIN tbl_adresse ON tbl_personne.adresse_id = tbl_adresse.id WHERE type_personne = 'élève'";
            //da.SelectCommand = cmd;

            //da.Fill(ds, "Eleve");
            //dGdVw_DetailEleve.DataSource = ds.Tables["Eleve"];
        }
    }
}
