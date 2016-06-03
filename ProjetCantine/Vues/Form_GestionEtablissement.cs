using ProjetCantine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        
        String img_path = "";

        private void Form_GestionEtablissement_Load(object sender, EventArgs e)
        {
            // création de l'objet de contrôle pour comuniquer avec le contrôleur    
            Ctrl_GestionEtablissement controle = new Ctrl_GestionEtablissement();
            bool verif = controle.verifExistEtablissement();

            // Test pour voir si il y a déjà des infos dans la db
            if (verif == true)
            {
                // création de l'objet de contrôle pour comuniquer avec le contrôleur              
                Ctrl_GestionEtablissement controle1 = new Ctrl_GestionEtablissement();
                controle1.afficheEtablissement(ref textBox_Dénomination, ref textBox_Num, ref textBox_Rue, ref textBox_Ville, ref textBox_Pays, ref textBox_CodePostal, ref textBox_Email, ref textBox_NumTelephone, ref textBox_NumFax, ref textBox_banqueBe, ref textBox_bicBE, ref textBox_banqueLu, ref textBox_bicLU, ref textBox_tva, ref img_path);

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
        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            // Teste au niveau du bouton pour voir s'il faut faire un INSERT ou un UPDATE
            switch (button_Ajouter.Text.ToString())
            {
                case "Ajouter":


                    Ctrl_GestionEtablissement controle = new Ctrl_GestionEtablissement();
                    int resultAd = controle.insertData("tbl_adresse","'"+ textBox_Pays.Text + "','" + textBox_Ville.Text + "','" + textBox_CodePostal.Text + "','" + textBox_Rue.Text + "','" + textBox_Num.Text+"'");

                    if (resultAd != 0)
                    {

                        Ctrl_GestionEtablissement controle1 = new Ctrl_GestionEtablissement();

                        String valInsert = "'" +textBox_Dénomination.Text + "','" + Convert.ToInt32(textBox_NumTelephone.Text) + "','" + Convert.ToInt32(textBox_NumFax.Text) + "','" + textBox_Email.Text;
                        valInsert += "','" + textBox_tva.Text + "','" + textBox_banqueBe.Text + "','" + textBox_bicBE.Text + "','" + textBox_banqueLu.Text;
                        valInsert += "','" + textBox_bicLU.Text + "','" + img_path + "','" + controle1.recupId(textBox_Rue.Text, textBox_Num.Text+ "'");

                        Ctrl_GestionEtablissement controle2 = new Ctrl_GestionEtablissement();
                        int resultEtab = controle.insertData("tbl_etablissement", valInsert);

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

                String donnée = "";
                int id = 0;

                //Construction de la requete pour l'update de l'établissement
                Ctrl_GestionEtablissement controleDonnée = new Ctrl_GestionEtablissement();
                donnée = controleDonnée.constrRequeteEtablissement(textBox_Dénomination.Text, textBox_Email.Text, textBox_NumTelephone.Text, textBox_NumFax.Text, textBox_banqueBe.Text, textBox_bicBE.Text, textBox_banqueLu.Text, textBox_bicLU.Text, textBox_tva.Text, img_path);
                //recuperer l'id de l'établissement
                Ctrl_GestionEtablissement controleRequete = new Ctrl_GestionEtablissement();
                id = controleRequete.recupIdEtablissement();
                //update de l'etablissement
                Ctrl_GestionEtablissement controleUpdate = new Ctrl_GestionEtablissement();
                controleUpdate.update(donnée, "tbl_etablissement", id);


                //Construction de la requete pour l'update de l'établissement
                Ctrl_GestionEtablissement controleDonnéeAdresse = new Ctrl_GestionEtablissement();
                donnée = controleDonnée.constrRequeteAdresse(textBox_Num.Text, textBox_Rue.Text, textBox_Ville.Text, textBox_Pays.Text, textBox_CodePostal.Text);
                //recuperer l'id de l'établissement
                Ctrl_GestionEtablissement controleID = new Ctrl_GestionEtablissement();
                id = controleID.recupAdresseId();
                //update de l'etablissement
                Ctrl_GestionEtablissement controleUpdateAdresse = new Ctrl_GestionEtablissement();
                controleUpdateAdresse.update(donnée, "tbl_adresse", id);

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
