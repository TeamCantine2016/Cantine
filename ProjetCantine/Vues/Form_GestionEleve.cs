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
    public partial class Form_GestionEleve : Form
    {
        public Form_GestionEleve()
        {
            InitializeComponent();
        }
        int flag;

        Form_EncodageElève Form_EncodageEleve;

        private void button_Nouveau_Click(object sender, EventArgs e)
        {
            flag = 0;
            Form_EncodageEleve = new Form_EncodageElève(flag);
            Form_EncodageEleve.ShowDialog();
          
        }

        private void button_Editer_Click(object sender, EventArgs e)
        {
            flag = 1;
            Form_EncodageEleve = new Form_EncodageElève(flag);
            Form_EncodageEleve.ShowDialog();
        }

        private void Form_GestionEleve_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Cantine.tbl_personne' table. You can move, or remove it, as needed.
            this.tbl_personneTableAdapter.Fill(this.dataSet_Cantine.tbl_personne);

        }
    }
}
