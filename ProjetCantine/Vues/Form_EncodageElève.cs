using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCantine
{
    public partial class Form_EncodageElève : Form
    {
        public Form_EncodageElève(int flag)
        {
            InitializeComponent();
            comboBox_Pays.SelectedIndex = 0;

            if (flag == 0)
            {
                button_Valider.Text = "Valider";
            }
            else
            {
                button_Valider.Text = "Modifier";
                String query = "Select tbl_personne.id as ID, nom as Nom, prenom as Prénom, rue as Adresse, ville as Ville, pays as Pays from tbl_personne ";
                query += "inner join tbl_adresse on tbl_adresse.id = tbl_personne.adresse_id where tbl_personne.id = "+flag+";";
            }

            //Select tbl_personne.id as ID, nom as Nom, prenom as Prénom, rue as Adresse, ville as Ville, pays as Pays, date_naissance as Dnaiss, numero as Numero, code_postal as CodePost from tbl_personne 
           // inner join tbl_adresse on tbl_adresse.id = tbl_personne.adresse_id
           //where tbl_personne.id = 5;
        }

        private void button_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_EncodageElève_Load(object sender, EventArgs e)
        {

        }
    }
}
