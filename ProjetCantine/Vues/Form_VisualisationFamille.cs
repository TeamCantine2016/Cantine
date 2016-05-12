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

            // requette pour l'affichage de la dataGridView_Famille
            // la requette est identique pour la recherche sur le nom ou le numéro de téléphone
            String query = "SELECT tbl_personne.id as CodeClient, nom as Famille, telephone as Téléphone, numero+' '+ rue as Adresse, ville as Ville, ";
            query += "code_postal as CodePostal, pays as Pays, courriel as Email ";
            query += "FROM tbl_personne inner join tbl_type_personne on tbl_personne.type_personne_id = tbl_type_personne.id ";
            query += "inner join tbl_adresse on tbl_personne.adresse_id = tbl_adresse.id ";
            query += "WHERE tbl_type_personne.type_personne = 'tuteur' and nom like '" + textBox_NomRech.Text + "%' and telephone like '" + textBox_TéléphoneRech.Text + "%'";

            // Connection, recuperation des données dans une datatable et gestion de l'affichage pour la dataGridView_Famille
            maCon.Open();
            SqlCommand maCommand = new SqlCommand(query, maCon);
            SqlDataReader dr = maCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            maCon.Close();
            dataGridView_Famille.DataSource = dt;

        }
               
        private void dataGridView_Famille_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            //Affichage des données contenues dans la dataGridView_Famille dans les textbox en fonction du chois de la ligne 
                // que l'utilisateur aura selectionné
            int id = dataGridView_Famille.CurrentRow.Index;
            DataGridViewRow ligne = dataGridView_Famille.Rows[id];
            textBox_Nom.Text = ligne.Cells[1].Value.ToString();
            textBox_Téléphone.Text = ligne.Cells[2].Value.ToString();
            textBox_Adresse.Text = ligne.Cells[3].Value.ToString() + ", " + ligne.Cells[4].Value.ToString() + ", " + ligne.Cells[6].Value.ToString().Substring(0, 1) + "-" + ligne.Cells[5].Value.ToString();
            textBox_Email.Text = ligne.Cells[7].Value.ToString();


            // Partie pour l'affichage des enfants en fonction de la ligne selectionné dans la dataGridView_Famille
            int codeClient = Convert.ToInt16(ligne.Cells[0].Value.ToString());

            String query = "SELECT nom as Nom, prenom as Prénom, DATEDIFF(year, date_naissance, SYSDATETIME()) as Age , date_naissance As DateNaissance";
            query += " FROM tbl_personne";
            query += " inner join tbl_type_personne on tbl_type_personne.id = tbl_personne.type_personne_id";
            query += " inner join tbl_relation_tuteur_enfant on tbl_relation_tuteur_enfant.enfant_id = tbl_personne.id";
            query += " where type_personne = 'élève' and tuteur_id = '" + codeClient + "'";

            maCon.Open();

            SqlCommand cmd = new SqlCommand(query, maCon);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);

            maCon.Close();
            dataGridView_Membre.DataSource = t;
            
        }

        private void button_Annuler_Click(object sender, EventArgs e)
        {
            textBox_NomRech.Text = "";
            textBox_TéléphoneRech.Text = "";
            comboBox_Envoi.SelectedIndex = -1;
            comboBox_Génération.SelectedIndex = -1;
        }
    }
}
