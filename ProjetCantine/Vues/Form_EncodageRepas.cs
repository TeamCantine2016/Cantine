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

            SqlCommand cmd = new SqlCommand("PS_Filtre_Eleve", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@nom", SqlDbType.NVarChar);

            cmd.Parameters["@nom"].Direction = ParameterDirection.Input;

            cmd.Parameters["@nom"].Value = txtBx_RechNom.Text;

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



        private void Form_EncodageRepas_Load(object sender, EventArgs e)
        {
            // requête du dataset pour remplir le datagridview
            this.tA_Listes_Personnes_query.Fill_Eleves(this.db_cantineDataSet.TA_Listes_Personnes);
            // pour adapter la largeur de colonnes
            dGdVw_DetailEleve.AutoResizeColumns();
            // pour élargir la dernière colonne horizontalement pour ne pas avoir une zone grise
            dGdVw_DetailEleve.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }



        private void txtBx_RechNumTel_TextChanged(object sender, EventArgs e)
        {
            filtre();
        }

        private void dGdVw_DetailEleve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dGdVw_DetailEleve.CurrentRow.Index;
            DataGridViewRow ligne = dGdVw_DetailEleve.Rows[i];
            txtBx_Nom.Text = ligne.Cells[1].Value.ToString();
            txtBx_Prenom.Text = ligne.Cells[2].Value.ToString();
            txtBox_Adresse.Text = ligne.Cells[4].Value.ToString();

            txtBx_DateNaissce.Text = ligne.Cells[3].Value.ToString().Substring(0,8);
            if (ligne.Cells[0].Value.ToString() != null) {
                string query = "SELECT telephone, courriel FROM tbl_personne ";
                query += "where(id = (SELECT tbl_relation_tuteur_enfant.tuteur_id FROM tbl_relation_tuteur_enfant WHERE(tbl_relation_tuteur_enfant.enfant_id = '" + Convert.ToInt32(ligne.Cells[0].Value.ToString()) + "')))";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtBx_Telephone.Text = dr["telephone"].ToString();
                    txtBx_Email.Text = dr["courriel"].ToString();
                }

                dr.Close();
                dr.Dispose();
                con.Close();
            }
            if (txtBx_Nom.Text.Length > 0)
            {
                monthCalendar.Enabled = true;
            }else
            {
                monthCalendar.Enabled = false;
            }
            //txtBx_Email.Text = ligne.Cells[0].Value.ToString();
        }


        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime startDate = e.Start;
            startDate = startDate.AddDays(1 - (double)startDate.DayOfWeek);
            monthCalendar.SelectionStart = startDate;
            labelDebut.Text = startDate.ToString("d");
            monthCalendar.SelectionEnd = startDate.AddDays(4);
            labelFin.Text = startDate.AddDays(4).ToString("d");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




        //static void GetSchemaInfo(SqlConnection connection,string query)
        //{
        //    using (connection)
        //    {
        //        SqlCommand command = new SqlCommand(
        //          query,
        //          connection);
        //        connection.Open();

        //        SqlDataReader reader = command.ExecuteReader();
        //        DataTable schemaTable = reader.GetSchemaTable();

        //        foreach (DataRow row in schemaTable.Rows)
        //        {
        //            foreach (DataColumn column in schemaTable.Columns)
        //            {
        //                Console.WriteLine(String.Format("{0} = {1}",
        //                   column.ColumnName, row[column]));
        //            }
        //        }
        //    }
        //}
    }
}
