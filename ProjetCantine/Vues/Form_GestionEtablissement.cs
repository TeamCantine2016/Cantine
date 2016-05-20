using ProjetCantine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCantine.Vues
{
    public partial class Form_GestionEtablissement : Form
    {
        public Form_GestionEtablissement()
        {
            InitializeComponent();
        }
        SqlConnection maCon = new SqlConnection(DbConnection.connectionString);
        String img_path = "";

        private void Form_GestionEtablissement_Load(object sender, EventArgs e)
        {
            //Affichage des informations
            String query = "SELECT * FROM tbl_etablissement Inner join tbl_adresse on tbl_adresse.id = tbl_etablissement.adresse_id";
            SqlCommand maCommand = new SqlCommand(query, maCon);
            maCon.Open();

            SqlDataReader dr = maCommand.ExecuteReader();
            dr.Read();

            // Test pour voir si il y a déjà des infos dans la db
            if (dr.HasRows == true)
            {

                textBox_Dénomination.Text = dr["nom_etablissement"].ToString();
                textBox_Num.Text = dr["numero"].ToString();
                textBox_Rue.Text = dr["rue"].ToString();
                textBox_Ville.Text = dr["ville"].ToString();
                textBox_Pays.Text = dr["pays"].ToString();
                textBox_CodePostal.Text = dr["code_postal"].ToString();
                textBox_Email.Text = dr["courriel"].ToString();
                textBox_NumTelephone.Text = dr["telephone"].ToString();
                textBox_NumFax.Text = dr["fax"].ToString();
                textBox_banqueBe.Text = dr["banque_BE"].ToString();
                textBox_bicBE.Text = dr["bic_BE"].ToString();
                textBox_banqueLu.Text = dr["banque_LU"].ToString();
                textBox_bicLU.Text = dr["bic_LU"].ToString();
                textBox_tva.Text = dr["tva"].ToString();

                img_path = dr["logo_path"].ToString();

                // Verifie si l'image existe 
                if (File.Exists(img_path))
                {
                    FileStream fs = new FileStream(img_path, FileMode.Open);
                    pictureBox_Logo.Image = Image.FromStream(fs);
                    fs.Close();
                    label_erreur.Visible = false;
                }
                else
                {
                    label_erreur.Text = "La photo est manquante ou introuvable";
                    label_erreur.ForeColor = Color.Red;
                }

                // gestion affichage
                textBox_Dénomination.Enabled = false;
                textBox_Num.Enabled = false;
                textBox_Rue.Enabled = false;
                textBox_Ville.Enabled = false;
                textBox_Pays.Enabled = false;
                textBox_CodePostal.Enabled = false;
                textBox_Email.Enabled = false;
                textBox_NumTelephone.Enabled = false;
                textBox_NumFax.Enabled = false;
                textBox_banqueBe.Enabled = false;
                textBox_bicBE.Enabled = false;
                textBox_banqueLu.Enabled = false;
                textBox_bicLU.Enabled = false;
                textBox_tva.Enabled = false;
                button_Parcourir.Visible = false;
                button_Ajouter.Text = "Modifier";
                button_Annuler.Enabled = false;


            }
            else
            {
                label_erreur.Visible = false;
            }
            maCon.Close();

        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            // Teste au niveau du bouton pour voir s'il faut faire un INSERT ou un UPDATE
            switch (button_Ajouter.Text.ToString())
            {
                case "Ajouter":

                    int resultAd = 0;
                    int resultEtab = 0;
                    String id_adresse = "";
                    string requeteAdresse = "INSERT INTO tbl_adresse(pays, ville, code_postal, rue, numero)";
                    requeteAdresse += " VALUES('" + textBox_Pays.Text + "','" + textBox_Ville.Text + "','" + textBox_CodePostal.Text + "','" + textBox_Rue.Text + "','" + textBox_Num.Text + "')";

                    maCon.Open();

                    SqlCommand cmd = new SqlCommand(requeteAdresse, maCon);
                    resultAd = cmd.ExecuteNonQuery();

                    //Teste Si la première requette est ok avant de passer a la suite 
                    if (resultAd != 0)
                    {
                        cmd = new SqlCommand("SELECT id FROM tbl_adresse where rue = '" + textBox_Rue.Text + "' and numero = '" + textBox_Num.Text + "'", maCon);
                        id_adresse = cmd.ExecuteScalar().ToString();


                        String requeteEtabl = "INSERT INTO tbl_etablissement (nom_etablissement, telephone, fax, courriel, tva, banque_BE, bic_BE, banque_LU, bic_LU, logo_path, adresse_id)";
                        requeteEtabl += " VALUES ('" + textBox_Dénomination.Text + "','" + Convert.ToInt32(textBox_NumTelephone.Text) + "','" + Convert.ToInt32(textBox_NumFax.Text) + "','" + textBox_Email.Text;
                        requeteEtabl += "','" + textBox_tva.Text + "','" + textBox_banqueBe.Text + "','" + textBox_bicBE.Text + "','" + textBox_banqueLu.Text + "','" + textBox_bicLU.Text + "','" + img_path + "','" + id_adresse + "')";


                        cmd = new SqlCommand(requeteEtabl, maCon);
                        resultEtab = cmd.ExecuteNonQuery();



                        // gestion affichage
                        if (resultEtab == 0)
                        { MessageBox.Show("L'établissement n'à pas pu etre enregistré "); }
                        else
                        {
                            MessageBox.Show("L'établissement à bien été enregistré ");
                            textBox_Dénomination.Enabled = false;
                            textBox_Num.Enabled = false;
                            textBox_Rue.Enabled = false;
                            textBox_Ville.Enabled = false;
                            textBox_Pays.Enabled = false;
                            textBox_CodePostal.Enabled = false;
                            textBox_Email.Enabled = false;
                            textBox_NumTelephone.Enabled = false;
                            textBox_NumFax.Enabled = false;
                            textBox_banqueBe.Enabled = false;
                            textBox_bicBE.Enabled = false;
                            textBox_banqueLu.Enabled = false;
                            textBox_bicLU.Enabled = false;
                            textBox_tva.Enabled = false;
                            button_Parcourir.Visible = false;
                            button_Ajouter.Text = "Modifier";
                            button_Annuler.Enabled = false;
                        }

                    }
                    break;


                case "Modifier":

                    // gestion affichage
                    textBox_Dénomination.Enabled = true;
                    textBox_Num.Enabled = true;
                    textBox_Rue.Enabled = true;
                    textBox_Ville.Enabled = true;
                    textBox_Pays.Enabled = true;
                    textBox_CodePostal.Enabled = true;
                    textBox_Email.Enabled = true;
                    textBox_NumTelephone.Enabled = true;
                    textBox_NumFax.Enabled = true;
                    textBox_banqueBe.Enabled = true;
                    textBox_bicBE.Enabled = true;
                    textBox_banqueLu.Enabled = true;
                    textBox_bicLU.Enabled = true;
                    textBox_tva.Enabled = true;
                    button_Parcourir.Visible = true;
                    button_Ajouter.Text = "Valider";
                    button_Annuler.Enabled = true;
                    label_erreur.Visible = false;
                    break;

                case "Valider":

                    // Partie pour faire le UPDATE de l'adresse et de l'établissement --> recherche de id de l'établissement et de l'adresse_id pour pouvoir faire les requetes suivante
                    maCon.Open();
                    cmd = new SqlCommand("SELECT id as id , adresse_id as adresse FROM tbl_etablissement", maCon);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    String id = dr["id"].ToString();
                    String ad_id = dr["adresse"].ToString();
                    maCon.Close();

                    maCon.Open();
                    String updateEtab = "UPDATE tbl_etablissement SET nom_etablissement = '" + textBox_Dénomination.Text + "',";
                    updateEtab += "telephone = '" + textBox_NumTelephone.Text + "',fax = '" + textBox_NumFax.Text + "',courriel = '" + textBox_Email.Text + "',";
                    updateEtab += "tva = '" + textBox_tva.Text + "',banque_BE = '" + textBox_banqueBe.Text + "',bic_BE = '" + textBox_bicBE.Text + "',";
                    updateEtab += "banque_LU = '" + textBox_banqueLu.Text + "',bic_LU = '" + textBox_bicLU.Text + "',logo_path = '" + img_path + "' where id = " + id;
                    cmd = new SqlCommand(updateEtab, maCon);
                    resultEtab = cmd.ExecuteNonQuery();
                    maCon.Close();

                    maCon.Open();
                    String updateAdr = "UPDATE tbl_adresse SET pays = '" + textBox_Pays.Text + "',ville = '" + textBox_Ville.Text + "',code_postal = '" + textBox_CodePostal.Text + "',";
                    updateAdr += "rue = '" + textBox_Rue.Text + "',numero = '" + textBox_Num.Text + "'WHERE id =" + ad_id;
                    cmd = new SqlCommand(updateAdr, maCon);
                    resultEtab = cmd.ExecuteNonQuery();
                    maCon.Close();

                    // gestion affichage
                    textBox_Dénomination.Enabled = false;
                    textBox_Num.Enabled = false;
                    textBox_Rue.Enabled = false;
                    textBox_Ville.Enabled = false;
                    textBox_Pays.Enabled = false;
                    textBox_CodePostal.Enabled = false;
                    textBox_Email.Enabled = false;
                    textBox_NumTelephone.Enabled = false;
                    textBox_NumFax.Enabled = false;
                    textBox_banqueBe.Enabled = false;
                    textBox_bicBE.Enabled = false;
                    textBox_banqueLu.Enabled = false;
                    textBox_bicLU.Enabled = false;
                    textBox_tva.Enabled = false;
                    button_Parcourir.Visible = false;
                    button_Ajouter.Text = "Modifier";
                    button_Annuler.Enabled = false;

                    break;


            }

            maCon.Close();
        }

        private void button_Parcourir_Click(object sender, EventArgs e)
        {

            // permetre a l'utilisateure de choisir une image des documents et de l'afficher
            OpenFileDialog openFileDialog_image = new OpenFileDialog();
            openFileDialog_image.InitialDirectory = "c:\\";
            openFileDialog_image.Filter = "TOUS (*.*)| *.*| JPEG (*.jpeg)|*.jpeg| GIF (*.gif)|*.gif| PNG (*.png)|*.png)";


            if (openFileDialog_image.ShowDialog() == DialogResult.OK)
            {
                img_path = openFileDialog_image.FileName;

                if (File.Exists(img_path))
                {
                    FileStream fs = new FileStream(img_path, FileMode.Open);
                    pictureBox_Logo.Image = Image.FromStream(fs);
                    fs.Close();
                }
                else
                {
                    label_erreur.Text = "La photo est manquante ou introuvable";
                    label_erreur.ForeColor = Color.Red;
                }
            }

        }
    }
}
