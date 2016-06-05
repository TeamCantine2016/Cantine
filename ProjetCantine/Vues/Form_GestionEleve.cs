using ProjetCantine.Models;
using System;
using System.Data;
using System.Data.SqlClient;
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
        Form_EncodageTuteur Form_EncodageTuteur;
        SqlConnection maCon = new SqlConnection(DbConnection.connectionString);

        private void button_Nouveau_Click(object sender, EventArgs e)
        {
            flag = 0;
            Form_EncodageEleve = new Form_EncodageElève(flag);
            Form_EncodageEleve.ShowDialog();

            String query = "Select tbl_personne.id as ID, nom as Nom, prenom as Prénom, rue as Adresse, ville as Ville, pays as Pays from tbl_personne ";
            query += "inner join tbl_adresse on tbl_adresse.id = tbl_personne.adresse_id where tbl_personne.type_personne_id = 1;";
            maCon.Open();

            SqlCommand maCommand = new SqlCommand(query, maCon);
            SqlDataReader dr = maCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Eleve.DataSource = dt;

            query = "Select tbl_personne.id as ID, nom as Nom, prenom as Prénom, rue as Adresse, ville as Ville, pays as Pays from tbl_personne ";
            query += "inner join tbl_adresse on tbl_adresse.id = tbl_personne.adresse_id where tbl_personne.type_personne_id = 2;";

            maCommand = new SqlCommand(query, maCon);
            dr = maCommand.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dataGridView_Tuteur.DataSource = dt;

        }

        private void button_Editer_Click(object sender, EventArgs e)
        {
            flag = Convert.ToInt32(dataGridView_Eleve.CurrentRow.Cells[0].Value);
            Form_EncodageEleve = new Form_EncodageElève(flag);
            Form_EncodageEleve.ShowDialog();

            String query = "Select tbl_personne.id as ID, nom as Nom, prenom as Prénom, rue as Adresse, ville as Ville, pays as Pays from tbl_personne ";
            query += "inner join tbl_adresse on tbl_adresse.id = tbl_personne.adresse_id where tbl_personne.type_personne_id = 1;";
            maCon.Open();

            SqlCommand maCommand = new SqlCommand(query, maCon);
            SqlDataReader dr = maCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Eleve.DataSource = dt;

            query = "Select tbl_personne.id as ID, nom as Nom, prenom as Prénom, rue as Adresse, ville as Ville, pays as Pays from tbl_personne ";
            query += "inner join tbl_adresse on tbl_adresse.id = tbl_personne.adresse_id where tbl_personne.type_personne_id = 2;";

            maCommand = new SqlCommand(query, maCon);
            dr = maCommand.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dataGridView_Tuteur.DataSource = dt;
            maCon.Close();
        }

        private void Form_GestionEleve_Load(object sender, EventArgs e)
        {

            String query = "Select tbl_personne.id as ID, nom as Nom, prenom as Prénom, rue as Adresse, ville as Ville, pays as Pays from tbl_personne ";
            query += "inner join tbl_adresse on tbl_adresse.id = tbl_personne.adresse_id where tbl_personne.type_personne_id = 1;";
            maCon.Open();

            SqlCommand maCommand = new SqlCommand(query, maCon);
            SqlDataReader dr = maCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Eleve.DataSource = dt;

            query = "Select tbl_personne.id as ID, nom as Nom, prenom as Prénom, rue as Adresse, ville as Ville, pays as Pays from tbl_personne ";
            query += "inner join tbl_adresse on tbl_adresse.id = tbl_personne.adresse_id where tbl_personne.type_personne_id = 2;";

            maCommand = new SqlCommand(query, maCon);
            dr = maCommand.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dataGridView_Tuteur.DataSource = dt;

            maCon.Close();
            button_Supprimer.Visible = false;
            button_SupprimerTuteur.Visible = false;


        }

        private void button_EditionTuteur_Click(object sender, EventArgs e)
        {
            flag = Convert.ToInt32(dataGridView_Tuteur.CurrentRow.Cells[0].Value);
            Form_EncodageTuteur = new Form_EncodageTuteur(flag);
            Form_EncodageTuteur.ShowDialog();

            String query = "Select tbl_personne.id as ID, nom as Nom, prenom as Prénom, rue as Adresse, ville as Ville, pays as Pays from tbl_personne ";
            query += "inner join tbl_adresse on tbl_adresse.id = tbl_personne.adresse_id where tbl_personne.type_personne_id = 1;";
            maCon.Open();

            SqlCommand maCommand = new SqlCommand(query, maCon);
            SqlDataReader dr = maCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Eleve.DataSource = dt;

            query = "Select tbl_personne.id as ID, nom as Nom, prenom as Prénom, rue as Adresse, ville as Ville, pays as Pays from tbl_personne ";
            query += "inner join tbl_adresse on tbl_adresse.id = tbl_personne.adresse_id where tbl_personne.type_personne_id = 2;";

            maCommand = new SqlCommand(query, maCon);
            dr = maCommand.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dataGridView_Tuteur.DataSource = dt;
            maCon.Close();
        }

        private void button_NouveauTuteur_Click(object sender, EventArgs e)
        {
            flag = 0;
            Form_EncodageTuteur = new Form_EncodageTuteur(flag);
            Form_EncodageTuteur.ShowDialog();

            String query = "Select tbl_personne.id as ID, nom as Nom, prenom as Prénom, rue as Adresse, ville as Ville, pays as Pays from tbl_personne ";
            query += "inner join tbl_adresse on tbl_adresse.id = tbl_personne.adresse_id where tbl_personne.type_personne_id = 1;";
            maCon.Open();

            SqlCommand maCommand = new SqlCommand(query, maCon);
            SqlDataReader dr = maCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Eleve.DataSource = dt;

            query = "Select tbl_personne.id as ID, nom as Nom, prenom as Prénom, rue as Adresse, ville as Ville, pays as Pays from tbl_personne ";
            query += "inner join tbl_adresse on tbl_adresse.id = tbl_personne.adresse_id where tbl_personne.type_personne_id = 2;";

            maCommand = new SqlCommand(query, maCon);
            dr = maCommand.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dataGridView_Tuteur.DataSource = dt;
            maCon.Close();

        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            // ----      Après plusieurs essais de suppressions, nous nous sommes rendu compte que les contraintes dans la BDD, nous obligeraient à supprimer l'intégralité 
            // ----      des données lié au tuteur ou à l'élève. Cependant, nous avons besoin de garder un historique de l'activité tuteur - élève pour le bon fonctionnement 
            // ----      du projet.
            // ----      Par conséquent, annulation provisoire de la fonction de suppression en raison du manque de temps pour livrer le projet avant deadline.
            // ----      La suppression sera intégrée dans une mise à jour future.

            /*flag = Convert.ToInt32(dataGridView_Eleve.CurrentRow.Cells[0].Value);
            String query = "DELETE FROM tbl_personne WHERE tbl_personne.id = " + flag + ";";
            maCon.Open();
            SqlCommand maCommand = new SqlCommand(query, maCon);
            maCommand.ExecuteNonQuery();
            maCon.Close();*/
        }

        private void button_SupprimerTuteur_Click(object sender, EventArgs e)
        {

            // ----      Après plusieurs essais de suppressions, nous nous sommes rendu compte que les contraintes dans la BDD, nous obligeraient à supprimer l'intégralité 
            // ----      des données lié au tuteur ou à l'élève. Cependant, nous avons besoin de garder un historique de l'activité tuteur - élève pour le bon fonctionnement 
            // ----      du projet.
            // ----      Par conséquent, annulation provisoire de la fonction de suppression en raison du manque de temps pour livrer le projet avant deadline.
            // ----      La suppression sera intégrée dans une mise à jour future.



            /* DialogResult result;
             String message = "Attention, supression de toutes relations tuteur - élève, adresse";
             int id_adresse = 0;
             int id_enfant = 0;
             flag = Convert.ToInt32(dataGridView_Tuteur.CurrentRow.Cells[0].Value);

             DbConnection dbTalk = new DbConnection();
             result = MessageBox.Show(message, "Attention", MessageBoxButtons.OKCancel);
             if (result == DialogResult.OK)
             {
                 do
                 {

                     id_enfant = int.Parse(dbTalk.recupDataScalar("select tbl_relation_tuteur_enfant.enfant_id from tbl_relation_tuteur_enfant where tbl_relation_tuteur_enfant.tuteur_id = " + flag + ";"));
                     dbTalk.delete("tbl_relation_activite", id_enfant,2);
                     dbTalk.delete("tbl_relation_tuteur_enfant", id_enfant, 3);
                     dbTalk.delete("tbl_personne", id_enfant,1);

                 } while (id_enfant != 0);


                 id_adresse = int.Parse(dbTalk.recupDataScalar("select tbl_personne.adresse_id from tbl_personne where tbl_personne.id =" + flag + ";"));
                 dbTalk.delete("tbl_personne", flag,1);
                 dbTalk.delete("tbl_adresse", id_adresse,1);
             }*/
        }
    }
}
