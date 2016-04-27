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

namespace ProjetCantine
{
    public partial class Form_GestionUtilisateur : Form
    {
        public Form_GestionUtilisateur()
        {
            InitializeComponent();
        }

        Form_EncodageUtilisateur form_EncodageUtilisateur;
        int flag;
        

        private void button_Nouveau_Click(object sender, EventArgs e)
        {
            flag = 0;
            form_EncodageUtilisateur = new Form_EncodageUtilisateur(flag);
            form_EncodageUtilisateur.ShowDialog();
        }

        private void button_Editer_Click(object sender, EventArgs e)
        {
            flag = 1;
            form_EncodageUtilisateur = new Form_EncodageUtilisateur(flag);
            form_EncodageUtilisateur.ShowDialog();
        }

        private void Form_GestionUtilisateur_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Cantine.utilisateurs_details' table. You can move, or remove it, as needed.
            this.tA_utilisateurs_details.Fill(this.dataSet_Cantine.utilisateurs_details);

        }
    }
}
