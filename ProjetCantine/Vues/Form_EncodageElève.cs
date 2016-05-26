using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProjetCantine.Models;

namespace ProjetCantine
{
    public partial class Form_EncodageElève : Form
    {
        string query1, query2, query3, query4 = "";
        int id_enfant, id_tuteur, id_activite, test = 0;
        SqlConnection maCon = new SqlConnection(DbConnection.connectionString);

        private void button_Valider_Click(object sender, EventArgs e)
        {
            if (button_Valider.Text == "Modifier")
            {
                // Cas de modification d'un élève
                if (textBox_Prénom.TextLength != 0 || textBox_Nom.TextLength != 0)
                {
                    query1 = "UPDATE tbl_personne set prenom = '" + textBox_Prénom.Text + "', nom = '" + textBox_Nom.Text + "', ";
                    query1 += " date_naissance = '" + dateTimePicker_DateNaissance.Text + "', courriel = '" + textBox_Mail.Text + "', telephone = '" + textBox_Téléphone.Text + "' ";
                    query1 += "WHERE tbl_personne.id = '" + id_enfant + "'";

                    SqlCommand maCommand = new SqlCommand(query1, maCon);
                    maCon.Open();
                    test = maCommand.ExecuteNonQuery();
                    if (test != 0)
                    {
                        MessageBox.Show("Elève modifié.");
                    }
                    else
                    {
                        MessageBox.Show("Remplir les champs NOM et PRENOM");
                    }

                }

            }
            else
            {
                // Cas d'ajout d'un élève
                query1 = "";
                query1 = "INSERT INTO tbl_personne(prenom,nom,date_naissance,courriel,telephone,type_personne_id,adresse_id) ";
                query1 += "values ('"+textBox_Prénom.Text+"','"+textBox_Nom.Text+"','"+dateTimePicker_DateNaissance.Text+"','"+textBox_Mail+"','"+textBox_Téléphone.Text+"','1','4')";

                SqlCommand maCommand = new SqlCommand(query1, maCon);
                maCon.Open();
                test = maCommand.ExecuteNonQuery();
                if (test != 0)
                {
                    MessageBox.Show("Elève ajouté.");
                }

                this.Close();
            }
        }

        public Form_EncodageElève(int flag)
        {
            InitializeComponent();
            

            // Test pour l'affichage du texte sur le bouton  --- 0 si nouveau nouveau membre --- Sinon flag recoit l'ID du membre
            //
            if (flag == 0)     
            {
                button_Valider.Text = "Valider";
            }
            else
            {
                button_Valider.Text = "Modifier";
                id_enfant = flag;

            }

        }

        private void button_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_EncodageElève_Load(object sender, EventArgs e)
        {
            if(button_Valider.Text == "Modifier")
            {

                // --- query1 ---

                query1 = "Select tbl_personne.id, nom, prenom, rue, ville, pays, date_naissance, numero, code_postal, tbl_relation_activite.activite_id from tbl_personne ";
                query1 += "inner join tbl_adresse on tbl_adresse.id = tbl_personne.adresse_id ";
                query1 += "inner join tbl_relation_activite on tbl_relation_activite.personne_id = tbl_personne.id ";
                query1 += "where tbl_personne.id = "+ id_enfant +"; ";

                SqlCommand maCommand = new SqlCommand(query1, maCon);
                maCon.Open();

                SqlDataReader dr = maCommand.ExecuteReader();
                dr.Read();
                id_activite = Convert.ToInt32(dr["activite_id"].ToString());
                textBox_Nom.Text = dr["nom"].ToString();
                textBox_Prénom.Text = dr["prenom"].ToString();
                textBox_Rue.Text = dr["rue"].ToString();
                textBox_Numéro.Text = dr["numero"].ToString();
                textBox_Ville.Text = dr["ville"].ToString();
                textBox_CP.Text = dr["code_postal"].ToString();
                textBox_Pays.Text = dr["pays"].ToString();
                dateTimePicker_DateNaissance.Value = Convert.ToDateTime(dr["date_naissance"].ToString());

                dr.Close();

                // --- query2 ---

                query2 = "Select tuteur_id from tbl_relation_tuteur_enfant ";
                query2 += " where tbl_relation_tuteur_enfant.enfant_id = " + id_enfant + ";";

                maCommand = new SqlCommand(query2, maCon);

                dr = maCommand.ExecuteReader();
                dr.Read();

                id_tuteur = Convert.ToInt32(dr["tuteur_id"].ToString());

                dr.Close();

                // --- query3 ---

                query3 = "Select nom, courriel, telephone from tbl_personne ";
                query3 += "where tbl_personne.id = " + id_tuteur + ";";

                maCommand = new SqlCommand(query3, maCon);

                dr = maCommand.ExecuteReader();
                dr.Read();

                textBox_Mail.Text = dr["courriel"].ToString();
                textBox_Téléphone.Text = dr["telephone"].ToString();
                textBox_Famille.Text = "Famille " + dr["nom"].ToString();

                dr.Close();

                //---query4-- -

                query4 = "Select tbl_activite.type_activite from tbl_activite ";
                query4 += "where tbl_activite.id = " + id_activite + ";";

                maCommand = new SqlCommand(query4, maCon);

                dr = maCommand.ExecuteReader();
                dr.Read();

                switch (dr["type_activite"].ToString())
                {
                    case "cantine":
                        checkBox_Cantine.Checked = true;
                        break;

                    case "bibliotheque":
                        checkBox_Bibliothèque.Checked = true;
                        break;

                    case "natation":
                        checkBox_Natation.Checked = true;
                        break;
                }
                dr.Close();

                maCon.Close();

            }

        }
    }
}
