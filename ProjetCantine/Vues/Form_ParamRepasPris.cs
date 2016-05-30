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
    public partial class Form_ParamRepasPrix : Form
    {
        public Form_ParamRepasPrix()
        {
            InitializeComponent();
        }

        private void Form_ParamRepasPrix_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_cantineDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.db_cantineDataSet.DataTable1);

          

        }
    }
}
