using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProjetCantine.Models;
using System.Data;

namespace ProjetCantine
{
    public partial class Form_EncodageElève : Form
    {
        string query1, query2, query3, query4 = "";
        int id_enfant, id_tuteur, id_activite,id_adresse, test = 0;
        SqlConnection maCon = new SqlConnection(DbConnection.connectionString);

        private void button_Valider_Click(object sender, EventArgs e)
        {
            if (button_Valider.Text == "Modifier")
            {
                // Cas de modification d'un élève
                

                if (textBox_Prénom.TextLength != 0 || textBox_Nom.TextLength != 0)
                {
                    id_tuteur = Convert.ToInt32(dataGridView_Tuteur.CurrentRow.Cells[0].Value);

                    query1 = "Select adresse_id from tbl_personne where tbl_personne.id = " + id_tuteur + " ";
                    maCon.Open();
                    SqlCommand maCommand = new SqlCommand(query1, maCon);
                    id_adresse = Convert.ToInt32(maCommand.ExecuteScalar());

                    query1 = "UPDATE tbl_personne set prenom = '" + textBox_Prénom.Text + "', nom = '" + textBox_Nom.Text + "', ";
                    query1 += " date_naissance = '" + dateTimePicker_DateNaissance.Text + "', adresse_id = '" + id_adresse + "'";
                    query1 += "WHERE tbl_personne.id = '" + id_enfant + "'";

                    maCommand = new SqlCommand(query1, maCon);
                    test = maCommand.ExecuteNonQuery();

                    query1 = "UPDATE tbl_relation_tuteur_enfant set tuteur_id = '" + id_tuteur + "' ";
                    query1 += "WHERE tbl_relation_tuteur_enfant.enfant_id = '" + id_enfant + "'";
                    maCommand = new SqlCommand(query1, maCon);
                    maCommand.ExecuteNonQuery();

                    if (test != 0)
                    {
                        MessageBox.Show("Elève modifié.");
                        
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Remplir les champs NOM et PRENOM");
                    }
                    maCon.Close();

                } // Sécuriser ICI ----------------------------------------------------------- !!!!!!!!!!!!!!!!!!!!!!!!!!

            }
            else
            {
                // Cas d'ajout d'un élève
                id_tuteur = Convert.ToInt32(dataGridView_Tuteur.CurrentRow.Cells[0].Value);
                
                query1 = "Select adresse_id from tbl_personne where tbl_personne.id = " + id_tuteur + " ";
                maCon.Open();
                SqlCommand maCommand = new SqlCommand(query1, maCon);
                id_adresse = Convert.ToInt32(maCommand.ExecuteScalar());


                query1 = "INSERT INTO tbl_personne(prenom,nom,date_naissance,type_personne_id,adresse_id) ";
                query1 += "values ('"+textBox_Prénom.Text+"','"+textBox_Nom.Text+"','"+dateTimePicker_DateNaissance.Text+"','1','" + id_adresse + "')";

                maCommand = new SqlCommand(query1, maCon);
                
                test = maCommand.ExecuteNonQuery();
                if (test != 0)
                {
                    maCon.Close();
                    
                    //id_tuteur = Convert.ToInt32(dataGridView_Tuteur.CurrentRow.Cells[0].Value);
                    //DbConnection dbTalk = new DbConnection();
                    //id_enfant = dbTalk.recupId("Select tbl_personne.id from tbl_personne where tbl_personne.nom = '" + textBox_Nom.Text + "' AND tbl_personne.prenom = '" + textBox_Prénom.Text + ";");

                    query1 = "Select tbl_personne.id from tbl_personne where tbl_personne.nom = '" + textBox_Nom.Text + "' AND tbl_personne.prenom = '" + textBox_Prénom.Text + "' AND tbl_personne.adresse_id = '" + id_adresse + "'";
                    maCon.Open();
                    maCommand = new SqlCommand(query1, maCon);
                    id_enfant = Convert.ToInt32(maCommand.ExecuteScalar());

                    query1 = "INSERT INTO tbl_relation_tuteur_enfant(tuteur_id,enfant_id) ";
                    query1 += "values ('" + id_tuteur + "','" + id_enfant + "')";
                    maCommand = new SqlCommand(query1, maCon);
                    maCommand.ExecuteNonQuery();

                    if (checkBox_Cantine.Checked == true)
                    {
                        query1 = "INSERT INTO tbl_relation_activite(activite_id,personne_id,date_debut) ";
                        query1 += "values ('1','" + id_enfant + "','" + DateTime.Now + "')";
                        maCommand = new SqlCommand(query1, maCon);
                        maCommand.ExecuteNonQuery();
                    }
                    if (checkBox_Natation.Checked == true)
                    {
                        query1 = "INSERT INTO tbl_relation_activite(activite_id,personne_id,date_debut) ";
                        query1 += "values ('3','" + id_enfant + "','"+ DateTime.Now +"')";
                        maCommand = new SqlCommand(query1, maCon);
                        maCommand.ExecuteNonQuery();
                    }
                    if (checkBox_Bibliothèque.Checked == true)
                    {
                        query1 = "INSERT INTO tbl_relation_activite(activite_id,personne_id,date_debut) ";
                        query1 += "values ('2','" + id_enfant + "','" + DateTime.Now + "')";
                        maCommand = new SqlCommand(query1, maCon);
                        maCommand.ExecuteNonQuery();
                    }



                    MessageBox.Show("Elève ajouté.");
                }

                this.Close();
                
            }
            maCon.Close();
        }

        public Form_EncodageElève(int flag)
        {
            InitializeComponent();


           // Test pour l'affichage du texte sur le bouton  --- 0 si nouveau nouvel élève --- Sinon flag recoit l'ID de l'élève
    
            if (flag == 0)     
            {
                button_Valider.Text = "Valider";
                textBox_Famille.Visible = false;
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
            if (button_Valider.Text == "Modifier")
            {

                // --- query1 ---

                query1 = "Select tbl_personne.id, nom, prenom, date_naissance,tbl_relation_activite.activite_id from tbl_personne ";
                query1 += "inner join tbl_relation_activite on tbl_relation_activite.personne_id = tbl_personne.id ";
                query1 += "where tbl_personne.id = " + id_enfant + "; ";

                SqlCommand maCommand = new SqlCommand(query1, maCon);
                maCon.Open();

                SqlDataReader dr = maCommand.ExecuteReader();
                dr.Read();
                id_activite = Convert.ToInt32(dr["activite_id"].ToString());
                textBox_Nom.Text = dr["nom"].ToString();
                textBox_Prénom.Text = dr["prenom"].ToString();
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

                query3 = "Select nom, tbl_personne.adresse_id from tbl_personne ";
                query3 += "inner join tbl_adresse on tbl_adresse.id = tbl_personne.adresse_id ";
                query3 += "where tbl_personne.id = " + id_tuteur + ";";

                maCommand = new SqlCommand(query3, maCon);

                dr = maCommand.ExecuteReader();
                dr.Read();

                textBox_Famille.Text = "Famille " + dr["nom"].ToString();
                id_adresse = Convert.ToInt32(dr["adresse_id"].ToString());

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

                query1 = "Select tbl_personne.id as ID, nom as Nom, prenom as Prénom, telephone as Téléphone from tbl_personne ";
                query1 += "where tbl_personne.type_personne_id = 2;";
                
                maCommand = new SqlCommand(query1, maCon);
                dr = maCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView_Tuteur.DataSource = dt;
                maCon.Close();

                dataGridView_Tuteur.Rows[1].Selected = true;
                int x = 0;
                do
                {
                    if (Convert.ToInt32(dataGridView_Tuteur.Rows[x].Cells[0].Value) == id_tuteur)
                    {
                        dataGridView_Tuteur.Rows[x].Selected = true;
                        x = 0;
                    }
                    else x++;


                } while (x != 0);


            }
            else
            {
                query1 = "Select tbl_personne.id as ID, nom as Nom, prenom as Prénom, telephone as Téléphone from tbl_personne ";
                query1 += "where tbl_personne.type_personne_id = 2;";
                maCon.Open();
                SqlCommand maCommand = new SqlCommand(query1, maCon);
                SqlDataReader dr = maCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView_Tuteur.DataSource = dt;
                maCon.Close();
            }

        }
    }
}
