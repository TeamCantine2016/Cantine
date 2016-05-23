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
    public partial class Form_Connexion : Form
    {
        public Form_Connexion()
        {
            InitializeComponent();
        }
        Form_Acceuil form_Acceuil;

        private void button_Connexion_Click(object sender, EventArgs e)
        {

            if (true)                       // Seulement si la connexion est validée
            {
                this.textBox_identifiant.Clear();
                this.textBox_MotDePasse.Clear();
                this.Hide();

                form_Acceuil = new Form_Acceuil();          // A contrôler si le Close() dans deconnecter.click,  detruit l'instance de form_Acceuil() ou non
                form_Acceuil.ShowDialog();

                this.Show();
            }


        }
    }
}
