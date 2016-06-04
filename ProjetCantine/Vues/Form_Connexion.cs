using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetCantine.Controller;
using ProjetCantine.Models;

namespace ProjetCantine
{
    public partial class Form_Connexion : Form
    {
        string retour;


        public Form_Connexion()
        {
            InitializeComponent();
        }
        Form_Acceuil form_Acceuil;
        Ctrl_Connexion control = new Ctrl_Connexion();

        private void button_Connexion_Click(object sender, EventArgs e)
        {
                DataTable table = new DataTable();

                retour = control.tentative_login(textBox_identifiant.Text.Trim(), textBox_MotDePasse.Text.Trim(),table); //fonction qui check les login, avec string retour pour le label d'erreur
                textBox_MotDePasse.Clear();
                label_Erreur.Visible = false;

                switch (retour) // retour = "ok" si connexion réussie, sinon message pour label_erreur explicant le problème
                {
                    case "ok":
                        this.textBox_identifiant.Clear();
                        this.Hide();

                        form_Acceuil = new Form_Acceuil(table.Rows[0]["nom"].ToString(), table.Rows[0]["prenom"].ToString(), table.Rows[0]["droits"].ToString(), this);          // A contrôler si le Close() dans deconnecter.click,  detruit l'instance de form_Acceuil() ou non
                        form_Acceuil.ShowDialog();
                        break;

                    default:
                        label_Erreur.Visible = true;
                        label_Erreur.Text = retour;
                        break;
                }
        }

        private void Form_Connexion_Load(object sender, EventArgs e)
        {
            label_Erreur.Visible = false;
        }

        private void textBox_identifiant_KeyDown(object sender, KeyEventArgs e) // cliquer sur enter = appuyer sur bouton connexion
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_Connexion.PerformClick();
            }
        }

        private void textBox_MotDePasse_KeyDown(object sender, KeyEventArgs e) // cliquer sur enter = appuyer sur bouton connexion
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_Connexion.PerformClick();
            }
        }
    } 
}

