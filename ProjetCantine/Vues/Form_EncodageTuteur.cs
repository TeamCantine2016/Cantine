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
    public partial class Form_EncodageTuteur : Form
    {
        string query1, query2, query3, query4 = "";
        int id_tuteur,id_adresse, test = 0;

        SqlConnection maCon = new SqlConnection(DbConnection.connectionString);

        private void button_Valider_Click(object sender, EventArgs e)
        {
            if (button_Valider.Text == "Modifier")
            {
                // Cas de modification d'un tuteur
                if (textBox_Prénom.TextLength != 0 && textBox_Nom.TextLength != 0 && textBox_Rue.TextLength != 0 &&
                    textBox_Numéro.TextLength != 0 && textBox_CP.TextLength != 0 && textBox_Ville.TextLength != 0 &&
                    textBox_Pays.TextLength != 0 && textBox_Téléphone.TextLength != 0 && textBox_Mail.TextLength != 0)
                {

                    // UPDATE de l'adresse 
                    query1 = "UPDATE tbl_adresse set pays = '" + textBox_Pays.Text + "', ville = '" + textBox_Ville.Text + "', ";
                    query1 += " code_postal = '" + Convert.ToInt32(textBox_CP.Text) + "', rue = '" + textBox_Rue.Text + "', numero ='"+ Convert.ToInt32(textBox_Numéro.Text) +"' ";
                    query1 += " WHERE tbl_adresse.id = '" + id_adresse + "'";
                    maCon.Open();
                    SqlCommand maCommand = new SqlCommand(query1, maCon);
                    maCommand.ExecuteNonQuery();

                    // UPDATE de personne
                    query2 = "UPDATE tbl_personne set prenom = '" + textBox_Prénom.Text + "', nom = '" + textBox_Nom.Text + "', ";
                    query2 += " date_naissance = '" + dateTimePicker_DateNaissance.Text + "'";
                    query2 += "WHERE tbl_personne.id = '" + id_tuteur + "'";

                    maCommand = new SqlCommand(query2, maCon);
                    test = maCommand.ExecuteNonQuery();
                    if (test != 0)
                    {
                        MessageBox.Show("Tuteur modifié.");
                        this.Close();
                    }
                    maCon.Close();
                }
                else MessageBox.Show("Veuillez remplir tous les champs!");

            }
            else
            {
                // Cas d'ajout d'un tuteur

                // Encodage d'une nouvelle adresse
                query1 = "INSERT INTO tbl_adresse(pays,ville,code_postal,rue,numero) ";
                query1 += "values ('" + textBox_Pays.Text + "','" + textBox_Ville.Text + "','" + Convert.ToInt32(textBox_CP.Text) + "','"+textBox_Rue.Text+"','"+ Convert.ToInt32(textBox_Numéro.Text)+"')";

                SqlCommand maCommand = new SqlCommand(query1, maCon);
                maCon.Open();
                maCommand.ExecuteNonQuery();


                // Récupération de l'id de la nouvelle adresse encodé
                query1 = "select * from tbl_adresse ";
                query1 += "where pays = '" + textBox_Pays.Text + "' and ville = '" + textBox_Ville.Text + "' and code_postal = '" + Convert.ToInt32(textBox_CP.Text) + "'and rue = '" + textBox_Rue.Text + "' and numero = '" + Convert.ToInt32(textBox_Numéro.Text) + "';";

                maCommand = new SqlCommand(query1, maCon);
                id_adresse = Convert.ToInt32(maCommand.ExecuteScalar());

                // Ajout d'un nouveau tuteur 
                query1 = "INSERT INTO tbl_personne(prenom,nom,date_naissance,courriel,telephone,type_personne_id,adresse_id) ";
                query1 += "values ('" + textBox_Prénom.Text + "','" + textBox_Nom.Text + "','" + dateTimePicker_DateNaissance.Text + "','" + textBox_Mail.Text + "','" + textBox_Téléphone.Text + "','2','" +id_adresse+"')";

                maCommand = new SqlCommand(query1, maCon);
                test = maCommand.ExecuteNonQuery();
                if (test != 0)
                {
                    MessageBox.Show("Tuteur ajouté.");
                    this.Close();
                }

            }
            maCon.Close();
        }



        private void Form_EncodageTuteur_Load(object sender, EventArgs e)
        {
            if (button_Valider.Text == "Modifier")
            {

                // --- query1 ---

                query1 = "Select tbl_personne.id, nom, prenom, rue, ville, pays, date_naissance, numero, code_postal,courriel,telephone from tbl_personne ";
                query1 += "inner join tbl_adresse on tbl_adresse.id = tbl_personne.adresse_id ";
                query1 += "where tbl_personne.id = " + id_tuteur + "; ";

                SqlCommand maCommand = new SqlCommand(query1, maCon);
                maCon.Open();

                SqlDataReader dr = maCommand.ExecuteReader();
                dr.Read();
                textBox_Nom.Text = dr["nom"].ToString();
                textBox_Prénom.Text = dr["prenom"].ToString();
                textBox_Rue.Text = dr["rue"].ToString();
                textBox_Numéro.Text = dr["numero"].ToString();
                textBox_Ville.Text = dr["ville"].ToString();
                textBox_CP.Text = dr["code_postal"].ToString();
                textBox_Pays.Text = dr["pays"].ToString();
                textBox_Mail.Text = dr["courriel"].ToString();
                textBox_Téléphone.Text = dr["telephone"].ToString();
                textBox_Famille.Text = id_tuteur+ " / Famille "+ dr["nom"].ToString();
                dateTimePicker_DateNaissance.Value = Convert.ToDateTime(dr["date_naissance"].ToString());
                dr.Close();

                // Récupération de l'id de l'adresse
                query1 = "select tbl_adresse.id from tbl_adresse ";
                query1 += "where pays = '" + textBox_Pays.Text + "' and ville = '" + textBox_Ville.Text + "' and code_postal = '" + Convert.ToInt32(textBox_CP.Text) + "' and rue = '" + textBox_Rue.Text + "' and numero = '" + Convert.ToInt32(textBox_Numéro.Text) + "';";

                maCommand = new SqlCommand(query1, maCon);
                id_adresse = Convert.ToInt32(maCommand.ExecuteScalar());

                
                maCon.Close();
            }
        }

        private void button_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Form_EncodageTuteur(int flag)
        {
            InitializeComponent();

            if (flag == 0)
            {
                button_Valider.Text = "Valider";
                textBox_Famille.Visible = false;
            }
            else
            {
                button_Valider.Text = "Modifier";
                id_tuteur = flag;

            }
        }
    }
}
