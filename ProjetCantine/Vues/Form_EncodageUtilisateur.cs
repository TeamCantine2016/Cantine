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
using ProjetCantine;



//using ProjetCantine.Models;

namespace ProjetCantine
{
    public partial class Form_EncodageUtilisateur : Form
    {

        //cantineEntities ce = new cantineEntities();   
        public Form_EncodageUtilisateur(Form_GestionUtilisateurs t_lien, int flag)
        {
            InitializeComponent();
            // comboBox_Type.SelectedIndex = 0;
            lien = t_lien;
            personne = lien.psd;
            type_encodage = flag;

        }

        private void button_Annuler_Click(object sender, EventArgs e)
        {
            this.Dispose();          // A vérifier son utilité
            this.Close();
        }

        private void Form_EncodageUtilisateur_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_cantineDataSet.tbl_utilisateur' table. You can move, or remove it, as needed.
            //this.tbl_utilisateurTableAdapter.Fill(this.db_cantineDataSet.tbl_utilisateur);
            SqlConnection cnn = new SqlConnection("Data Source=localhost;Initial Catalog=db_cantine;Integrated Security=True");
          

            try
            {
                cnn.Open();
                

                //Formulaire vide
                if (type_encodage == 0)
                {
                    button_Valider.Text = "Valider";
                    saved_id_util = 0;
                    saved_id_pers = 0;
                    saved_id_typepers = 0;
                    saved_id_adr = 0;
                }
                // Remplissage des textBox
                else
                {
                    button_Valider.Text = "Modifier";


                    SqlCommand command_personne;

                    string sql_personne = "Select pseudo, mdp, mdp_controle,type_personne, nom, prenom, rue, ville, pays, numero, code_postal, telephone, courriel, etat, droits,  tbl_utilisateur.id,  tbl_personne.id,  tbl_type_personne.id,  tbl_adresse.id from  tbl_utilisateur inner join  tbl_personne on  tbl_utilisateur.personne_id =  tbl_personne.id inner join  tbl_type_personne on  tbl_type_personne.id =  tbl_personne.type_personne_id inner join  tbl_adresse on  tbl_adresse.id =  tbl_personne.adresse_id where  tbl_utilisateur.pseudo='" + personne + "';";
                    SqlDataReader dataReader_personne;


                    command_personne = new SqlCommand(sql_personne, cnn);
                    dataReader_personne = command_personne.ExecuteReader();

                    if (dataReader_personne.Read()==true)
                    {
                        for (int i = 0; i < 19; i++)
                        {
                            switch (i)
                            {
                                case 10:
                                case 15:
                                case 16:
                                case 18:
                                    tab_personne[i] = dataReader_personne.GetInt32(i).ToString();
                                    break;
                                // modif BD: tel bigint => varchar
                                //case 11:
                                  //  tab_personne[i] = dataReader_personne.GetInt64(i).ToString();
                                    //break;
                                case 13:
                                    tab_personne[i] = dataReader_personne.GetBoolean(i).ToString();
                                    break;
                                case 17:
                                    tab_personne[i] = dataReader_personne.GetByte(i).ToString();
                                    break;
                                default:
                                    tab_personne[i] = dataReader_personne.GetString(i);
                                    break;
                            }
                        }
                    }
                    dataReader_personne.Close();
                    command_personne.Dispose();
                    cnn.Close();

                    textBox_Identifiant.Text = tab_personne[0];
                    textBox_MotDePasse.Text = tab_personne[1];
                    textBox_Confirmation.Text = tab_personne[2];
                    textBox_Type_personne.Text = tab_personne[3];
                    textBox_Nom.Text = tab_personne[4];
                    textBox_Prenom.Text = tab_personne[5];
                    textBox_Rue.Text = tab_personne[6];
                    textBox_Ville.Text = tab_personne[7];
                    textBox_Pays.Text = tab_personne[8];
                    textBox_Numero.Text = tab_personne[9];
                    textBox_Cp.Text = tab_personne[10];
                    textBox_Telephone.Text = tab_personne[11];
                    textBox_Mail.Text = tab_personne[12];
                    if (tab_personne[13] == "True")
                    {
                        radioButton_Actif.Checked = true;
                    }
                    else
                    {
                        radioButton_Inactif.Checked = true;
                    }
                    comboBox_Droits.SelectedItem = tab_personne[14];

                    int.TryParse(tab_personne[15], out saved_id_util);
                    int.TryParse(tab_personne[16], out saved_id_pers);
                    int.TryParse(tab_personne[17], out saved_id_typepers);
                    int.TryParse(tab_personne[18], out saved_id_adr);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void button_Valider_Click(object sender, EventArgs e)
        {
            string msg = "";
            int err;
            int codePostal;
            string num = "";
            Byte typePers = 0;
            int tel = 0;
            int id = 0;
            int idpers = 0;
            Byte actif = 0;

            err = 0;

            // Vérification du remplissage de tous les contrôles
            if (textBox_Identifiant.TextLength == 0)
            {
                msg += "\n- Identifiant ";
                err++;
            }

            if (textBox_MotDePasse.TextLength == 0)
            {
                msg += "\n- Mot de passe";
                err++;
            }

            if (textBox_Confirmation.TextLength == 0)
            {
                msg += "\n- Confirmation du mot de passe";
                err++;
            }

            if (textBox_Type_personne.TextLength == 0)
            {
                msg += "\n- Type";
                err++;
            }

            if (textBox_Nom.TextLength == 0)
            {
                msg += "\n- Nom";
                err++;
            }

            if (textBox_Prenom.TextLength == 0)
            {
                msg += "\n- Prénom";
                err++;
            }

            if (textBox_Rue.TextLength == 0)
            {
                msg += "\n- Rue";
                err++;
            }

            if (textBox_Ville.TextLength == 0)
            {
                msg += "\n- Ville";
                err++;
            }

            if (textBox_Numero.TextLength == 0)
            {
                msg += "\n- Numéro";
                err++;
            }
            if (textBox_Pays.TextLength == 0)
            {
                msg += "\n- Pays";
                err++;
            }

            if (textBox_Cp.TextLength == 0)
            {
                msg += "\n- Code Postal";
                err++;
            }

            if (textBox_Telephone.TextLength == 0)
            {
                msg += "\n- Téléphone";
                err++;
            }

            if (textBox_Mail.TextLength == 0)
            {
                msg += "\n- Email";
                err++;
            }

            if (comboBox_Droits.SelectedIndex == -1)
            {
                msg += "\n- Droits";
                err++;
            }

            if (err != 0)
            {
                MessageBox.Show("Veuillez compléter les champs suivants:" + msg, "Formulaire incomplet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // Si tous les contrôles sont bien remplis:
            else
            {
                // Vérifie que le mot de passe est correctement encodé
                if (textBox_MotDePasse.Text != textBox_Confirmation.Text)
                {
                    MessageBox.Show("Veuillez réintroduire votre mot de passe et le confirmer.", "Mauvais mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox_Confirmation.Text = "";
                    textBox_MotDePasse.Text = "";
                    textBox_MotDePasse.Focus();
                }
                // Si le mot de passe est correct:
                else
                {
                    if (int.TryParse(textBox_Cp.Text, out codePostal))
                    {
                        
                                SqlConnection cnn = new SqlConnection("Data Source=localhost;Initial Catalog=db_cantine;Integrated Security=True");
                                SqlCommand command;
                                string sql = "";
                                object id_verif = null;

                                try
                                {
                                    cnn.Open();

                                    // Vérifie que l'identifiant n'existe pas encore
                                    if (type_encodage == 0)
                                    {
                                        sql = "select dbo.tbl_utilisateur.pseudo from dbo.tbl_utilisateur where pseudo like '" + textBox_Identifiant.Text + "' ;";
                                        command = new SqlCommand(sql, cnn);
                                        id_verif = command.ExecuteScalar();
                                        command.Dispose();
                                    }

                                    if (id_verif != null)
                                    {
                                        MessageBox.Show("Le pseudo existe déjà. \nVeuillez choisir un autre pseudo.", "Problème de pseudo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        textBox_Identifiant.Clear();
                                        textBox_Identifiant.Focus();
                                        
                                    }
                                    else {

                                        // Vérifie que la nouvelle adresse n'existe pas déjà
                                        sql = "select dbo.tbl_adresse.id from dbo.tbl_adresse where pays like '" + textBox_Pays.Text + "' and ville like '" + textBox_Ville.Text + "' and rue like '" + textBox_Rue.Text + "' and numero like '" + textBox_Numero.Text + "' and code_postal =" + codePostal + ";";
                                        command = new SqlCommand(sql, cnn);
                                        id_verif = command.ExecuteScalar();
                                        command.Dispose();

                                    // Si l'adresse n'existe pas, on l'ajoute.
                                    if (id_verif == null)
                                    {
                                        sql = "insert into dbo.tbl_adresse values ('" + textBox_Pays.Text + "', '" + textBox_Ville.Text + "', " + codePostal + ", '" + textBox_Rue.Text + "', '" + textBox_Numero.Text + "'); ";
                                        command = new SqlCommand(sql, cnn);
                                        command.ExecuteNonQuery();
                                        command.Dispose();

                                        // On récupère les clés étrangères
                                        sql = "select dbo.tbl_adresse.id from dbo.tbl_adresse where pays like '" + textBox_Pays.Text + "' and ville like '" + textBox_Ville.Text + "' and rue like '" + textBox_Rue.Text + "' and numero like '" + textBox_Numero.Text + "' and code_postal =" + codePostal + " ;";
                                        command = new SqlCommand(sql, cnn);
                                        id = (int)command.ExecuteScalar();
                                        command.Dispose();
                                    }
                                    else
                                    {
                                            if (type_encodage == 0)
                                            {
                                                id = (int)id_verif;
                                            }
                                            else
                                            {
                                                id = saved_id_adr;
                                            }
                                        }


                                    if (type_encodage == 0)
                                    {
                                        sql = "select id from  tbl_type_personne where type_personne like '" + textBox_Type_personne.Text + "';";
                                        command = new SqlCommand(sql, cnn);
                                        typePers = (Byte)command.ExecuteScalar();
                                        command.Dispose();
                                    }
                                    else
                                    {
                                        typePers = (byte)saved_id_typepers;
                                    }

                                    

                                    // Vérifie que la personne n'existe pas déjà ou va chercher id dans le cas de la modif
                                    // ATTENTION: si la personne existe déjà, l'adresse encodée est remplacée par l'adresse de la personne, si ces deux adresses sont différentes
                                    if (type_encodage == 0)
                                    {
                                            sql = "select dbo.tbl_personne.id from dbo.tbl_personne where prenom like '" + textBox_Prenom.Text + "' and nom like '" + textBox_Nom.Text + "' and courriel like '" + textBox_Mail.Text + "' and telephone = '" + textBox_Telephone.Text + "' and type_personne_id = " + typePers + " and adresse_id=" + id + ";";
                                            command = new SqlCommand(sql, cnn);
                                            id_verif = command.ExecuteScalar();
                                            command.Dispose();
                                            

                                            // Si la personne n'existe pas, on l'ajoute
                                            if (id_verif == null)
                                            {
                                                sql = "insert into  tbl_personne values ('" + textBox_Prenom.Text + "', '" + textBox_Nom.Text + "', '1900-01-01' , '" + textBox_Mail.Text + "', '" + textBox_Telephone.Text + "'," + typePers + " , " + id + "); ";
                                                command = new SqlCommand(sql, cnn);
                                                command.ExecuteNonQuery();
                                                command.Dispose();


                                                // On récupère l'id de la personne ajoutée
                                                sql = "select id from  tbl_personne where nom like '" + textBox_Nom.Text + "' and  prenom like '" + textBox_Prenom.Text + "' and courriel = '" + textBox_Mail.Text + "';";
                                                command = new SqlCommand(sql, cnn);
                                                idpers = (int)command.ExecuteScalar();
                                                command.Dispose();
                                            }
                                            else
                                            {
                                                idpers = (int)id_verif;
                                            }
                                        }
                                    else // Modification
                                    {
                                        idpers = saved_id_pers;
                                        sql = "update  tbl_personne set prenom='" + textBox_Prenom.Text + "', nom= '" + textBox_Nom.Text + "', date_naissance='1900-01-01', courriel= '" + textBox_Mail.Text + "', telephone='" + textBox_Telephone.Text + "', type_personne_id=" + typePers + " , adresse_id=" + id + " where id = " + idpers + ";";
                                        command = new SqlCommand(sql, cnn);
                                        command.ExecuteNonQuery();
                                        command.Dispose();
                                    }

                                    if (radioButton_Actif.Checked == true)
                                    {
                                        actif = 1;
                                    }
                                    else
                                    {
                                        actif = 0;
                                    }

                                    // Vérifie que l'utilisateur n'existe pas déjà 
                                    if (type_encodage == 0)
                                    {
                                        sql = "select dbo.tbl_utilisateur.id from dbo.tbl_utilisateur where pseudo like '" + textBox_Identifiant.Text + "' and mdp like '" + textBox_Identifiant.Text + "' and mdp_controle like '" + textBox_Confirmation.Text + "' and droits like '" + comboBox_Droits.SelectedItem.ToString() + "' and etat =" + actif + " and personne_id = " + idpers + ";";
                                        command = new SqlCommand(sql, cnn);
                                        id_verif = command.ExecuteScalar();
                                        command.Dispose();


                                        //Si l'utilisateur n'existe pas, on l'ajoute
                                        if (id_verif == null)
                                        {
                                            sql = "insert into dbo.tbl_utilisateur values ('" + textBox_Identifiant.Text + "', '" + textBox_MotDePasse.Text + "', '" + textBox_Confirmation.Text + "', '" + comboBox_Droits.SelectedItem.ToString() + "', " + actif + " , " + idpers + "); ";
                                            command = new SqlCommand(sql, cnn);
                                            command.ExecuteNonQuery();
                                            command.Dispose();

                                            MessageBox.Show("Opération effectuée avec succès.", "Encodage nouvel utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    else // Modification
                                    {
                                        sql = "update  tbl_utilisateur set pseudo='" + textBox_Identifiant.Text + "', mdp='" + textBox_MotDePasse.Text + "', mdp_controle='" + textBox_Confirmation.Text + "', droits='" + comboBox_Droits.SelectedItem.ToString() + "', etat=" + actif + " where id = " + saved_id_util + "; ";
                                        command = new SqlCommand(sql, cnn);
                                        command.ExecuteNonQuery();
                                        command.Dispose();

                                        MessageBox.Show("Opération effectuée avec succès.", "Mise à jour utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }
                                    lien.Form_GestionUtilisateurs_Load(this, null);
                                    this.Close();
                                    cnn.Close();

                                     }
                                }

                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                            }
                          
                    
                    else
                    {
                        MessageBox.Show("Code postal incorrect", "Erreur d'encodage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

      
    }
}
