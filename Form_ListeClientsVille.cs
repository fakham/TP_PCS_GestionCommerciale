using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PCS_GestionCommerciale2
{
    public partial class Form_ListeClientsVille : Form
    {
        public Form_ListeClientsVille()
        {
            InitializeComponent();
        }

        private void Form_ListeClientsVille_Load(object sender, EventArgs e)
        {
            comboBox_ville.DisplayMember = "Ville";
            comboBox_ville.ValueMember = "Ville";

            comboBox_ville.DataSource = Program.ExecuteCmdsSelection("select distinct ville from Client");
        }

        private void comboBox_ville_SelectedIndexChanged(object sender, EventArgs e)
        {
            string req = "select * from Client where ville = '" + comboBox_ville.Text + "'";
            dataGridView_clients.DataSource = Program.ExecuteCmdsSelection(req);
        }
    }
}
