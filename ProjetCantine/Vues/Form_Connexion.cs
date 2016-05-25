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
    public partial class Form_Connexion : Form
    {
        string login, password;
        SqlConnection con_log = new SqlConnection(DbConnection.connectionString);
        SqlCommand cmd_log = new SqlCommand();

        public Form_Connexion()
        {
            InitializeComponent();
        }
        Form_Acceuil form_Acceuil;
        private void button_Connexion_Click(object sender, EventArgs e)
        {
            label_Erreur.Visible = false;

            // vérifie si au moins une des case n'est pas vide
            if (this.textBox_identifiant.Text.Length == 0 || this.textBox_MotDePasse.Text.Length == 0)
            {
                label_Erreur.Visible = true;
                label_Erreur.Text = "Toutes les cases n'ont pas été remplies";
            }
            else
            {
                // login non cryptés
                login = textBox_identifiant.Text.Trim();
                password = textBox_MotDePasse.Text.Trim();
                textBox_MotDePasse.Clear();

                // ouverture connexion, requete sql et DataReader
                con_log.Open();
                cmd_log = new SqlCommand("SELECT pseudo FROM tbl_utilisateur WHERE pseudo = '" + login + "' AND mdp = '" + password + "'", con_log);
                SqlDataReader dr_log = cmd_log.ExecuteReader();

                if (dr_log.HasRows)                       // contient une rangée uniquement si il y a une correspondance entre login & base de données
                {
                    this.textBox_identifiant.Clear();
                    this.textBox_MotDePasse.Clear();
                    this.Hide();

                    form_Acceuil = new Form_Acceuil();          // A contrôler si le Close() dans deconnecter.click,  detruit l'instance de form_Acceuil() ou non
                    form_Acceuil.ShowDialog();

                    this.Show();
                }
                else
                {
                    label_Erreur.Visible = true;
                    label_Erreur.Text = "Identifiant et/ou password non valide";
                }
                con_log.Close();
            }
        }

        private void Form_Connexion_Load(object sender, EventArgs e)
        {
            label_Erreur.Visible = false;
        }
    }
}
