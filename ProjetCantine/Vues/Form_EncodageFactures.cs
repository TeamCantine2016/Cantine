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
    public partial class Form_EncodageFactures : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        db_cantineDataSet ds = new db_cantineDataSet();
        SqlConnection con = new SqlConnection(DbConnection.connectionString);
        public Form_EncodageFactures()
        {
            InitializeComponent();
        }

        private void Form_EncodageFactures_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_cantineDataSet.TA_Remplir_CB_FormatEnvoie' table. You can move, or remove it, as needed.
            this.tA_Remplir_CB_FormatEnvoieTableAdapter.Fill_FormatEnvoi(this.db_cantineDataSet.TA_Remplir_CB_FormatEnvoie);
            // requête du dataset pour remplir le datagridview
            this.tA_Listes_Personnes_query.Fill_Tuteurs(this.db_cantineDataSet.TA_Listes_Personnes);
            // pour adapter la largeur de colonnes
            dGdVw_DetailFamille.AutoResizeColumns();
            // pour élargir la dernière colonne horizontalement pour ne pas avoir une zone grise
            dGdVw_DetailFamille.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGdVw_DetailFamille.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView_Membres.AutoResizeColumns();
        }



        private void btApercu_Click(object sender, EventArgs e)
        {
            ApercuFacture facture = new ApercuFacture();
            String msgRetour = facture.facture();

            // teste si le fichier a bien été creer           
            if (msgRetour.LastIndexOf(".pdf") == -1)
            {
                MessageBox.Show(msgRetour);
            }
            else
            {
                MessageBox.Show("La création à bien été éffectué à l'adresse: " + msgRetour);
                facture.affichageFacture(msgRetour);
            }
        }

        private void txtBx_RechNom_TextChanged(object sender, EventArgs e)
        {
           // String query = "SELECT prenom, nom, telephone, rue, numero, code_postal, ville, pays FROM tbl_personne INNER JOIN tbl_adresse ON tbl_personne.adresse_id = tbl_adresse.id INNER JOIN tbl_type_personne ON tbl_personne.type_personne_id = tbl_type_personne.id where (nom like '%" + txtBx_RechNom.Text + "%' and tbl_type_personne.type_personne = 'tuteur')";
           String query = "SELECT nom AS 'Nom', prenom AS 'Prénom', telephone AS 'Numéro de Téléphone', date_naissance AS 'Date de naissance', { fn CONCAT({ fn CONCAT(CAST(tbl_adresse.numero AS VARCHAR(3)), ', ') }, tbl_adresse.rue)} AS 'Adresse', { fn CONCAT({ fn CONCAT(CAST(tbl_adresse.code_postal AS varchar(5)), ' - ') }, tbl_adresse.ville) } AS 'Ville', tbl_adresse.pays AS 'Pays' FROM tbl_personne INNER JOIN tbl_adresse ON tbl_personne.adresse_id = tbl_adresse.id INNER JOIN tbl_type_personne ON tbl_personne.type_personne_id = tbl_type_personne.id WHERE (nom like '%" + txtBx_RechNom.Text + "%' and tbl_type_personne.type_personne = 'tuteur')";
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            dGdVw_DetailFamille.DataSource = t;

            con.Close();
        }

        private void txtBx_RechNumTel_TextChanged(object sender, EventArgs e)
        {
            // String query = "SELECT prenom, nom, telephone, rue, numero, code_postal, ville, pays FROM tbl_personne INNER JOIN tbl_adresse ON tbl_personne.adresse_id = tbl_adresse.id INNER JOIN tbl_type_personne ON tbl_personne.type_personne_id = tbl_type_personne.id where (telephone like '%" + txtBx_RechNumTel.Text + "%' and tbl_type_personne.type_personne = 'tuteur')";

            String query = "SELECT nom AS 'Nom', prenom AS 'Prénom', telephone AS 'Numéro de Téléphone', date_naissance AS 'Date de naissance', { fn CONCAT({ fn CONCAT(CAST(tbl_adresse.numero AS VARCHAR(3)), ', ') }, tbl_adresse.rue)} AS 'Adresse', { fn CONCAT({ fn CONCAT(CAST(tbl_adresse.code_postal AS varchar(5)), ' - ') }, tbl_adresse.ville) } AS 'Ville', tbl_adresse.pays AS 'Pays' FROM tbl_personne INNER JOIN tbl_adresse ON tbl_personne.adresse_id = tbl_adresse.id INNER JOIN tbl_type_personne ON tbl_personne.type_personne_id = tbl_type_personne.id WHERE (telephone like '%" + txtBx_RechNumTel.Text + "%' and tbl_type_personne.type_personne = 'tuteur')";
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            dGdVw_DetailFamille.DataSource = t;

            con.Close();
        }

        private void dGdVw_DetailFamille_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            int cmp = dGdVw_DetailFamille.CurrentRow.Index;
            DataGridViewRow line = dGdVw_DetailFamille.Rows[cmp];
            String query = "WITH Tuteur AS(SELECT prenom, nom, id FROM tbl_relation_tuteur_enfant INNER JOIN tbl_personne ON tbl_relation_tuteur_enfant.tuteur_id= tbl_personne.id Where tbl_personne.nom = '"+ line.Cells[0].Value.ToString() + "' ),Enfant AS( SELECT prenom, nom, date_naissance, id FROM tbl_relation_tuteur_enfant INNER JOIN tbl_personne ON tbl_relation_tuteur_enfant.enfant_id= tbl_personne.id) SELECT DISTINCT Enfant.nom AS 'Nom', Enfant.prenom AS 'Prénom', Enfant.date_naissance AS 'Date de Naissance' FROM Tuteur, Enfant, tbl_relation_tuteur_enfant WHERE Tuteur.id = tbl_relation_tuteur_enfant.tuteur_id AND tbl_relation_tuteur_enfant.enfant_id = Enfant.id";
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            dataGridView_Membres.DataSource = t;

            con.Close();


        }
    }
}
