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
            else button_Valider.Text = "Modifier";
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
