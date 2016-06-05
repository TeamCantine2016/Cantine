using System;
using System.Windows.Forms;

namespace ProjetCantine.Vues
{
    public partial class Form_View_Facture : Form
    {
        public Form_View_Facture()
        {
            InitializeComponent();
        }

        private void Form_View_Facture_Load(object sender, EventArgs e)
        {
            // initialisation
            bt_annuler.Visible = true;
            bt_enregistrer.Visible = false;
            lb_Message.Visible = true;
            String pdfpath = this.Tag.ToString();
            // vérification
            if (pdfpath.Contains("#toolbar=0"))
            {
                bt_annuler.Visible = true;
                bt_enregistrer.Visible = true;
                lb_Message.Visible = false;
            }

            this.wb_view_pdf.Url = new Uri(String.Format("file:///{0}", pdfpath));
        }

        private void bt_annuler_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void bt_enregistrer_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
